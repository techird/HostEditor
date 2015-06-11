using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.Threading;

namespace HostEditor
{
	public partial class FrmMain : Form
	{
		private HostList hostList;

		private bool edited = true;
		private bool Edited
		{
			get
			{
				return edited;
			}
			set
			{
				if (edited != value)
				{
					edited = value;
					this.Text = edited ? "* " : "";
					this.Text += "Host编辑工具";
					if (edited)
						txtStatus.Text = "有未保存的修改";
					btnSave.Enabled = edited;
				}
			}
		}

		public FrmMain()
		{
			InitializeComponent();
		}

		#region Host模块

		/// <summary>
		/// 添加Host
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void New(object sender , EventArgs e)
		{
			FrmHostEditor HostEditor = new FrmHostEditor() { Text = "添加Host" , Host = new Host() { Container = hostList } };
			HostEditor.ShowDialog();

			if (HostEditor.DialogResult == DialogResult.OK)
			{
				hostList.Add(HostEditor.Host);
				listViewHost.ReloadList();
				Edited = true;
			}
		}

		/// <summary>
		/// 编辑Host
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Edit(object sender , EventArgs e)
		{
			if (listViewHost.SelectedItems.Count != 1)
				return;

			FrmHostEditor hostEditor = new FrmHostEditor()
			{
				Text = "编辑Host" ,
				Host = listViewHost.SelectedItems[0].Tag as Host
			};

			if (hostEditor.ShowDialog() == DialogResult.OK)
			{
				listViewHost.ReloadList();
				Edited = true;
			}
		}

		/// <summary>
		/// 删除Host
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Remove(object sender , EventArgs e)
		{

			// 获得删除列表和数量
			var removeList = listViewHost.SelectedItems.OfType<ListViewItem>().ToList();
			int count = removeList.Count();
			if (count == 0)
				return;

			// 生成确认对话
			const int maxDisp = 6;
			string question = String.Format("确认删除以下 {0} 条记录吗?" , count);
			for (int i = 0; i < Math.Min(maxDisp , count); ++i)
				question += Environment.NewLine + "  " + (removeList[i].Tag as Host).ServerName;
			if (count > maxDisp)
				question += Environment.NewLine + "  ...";

			// 不删除
			if (MessageBoxEx.Confirm(question) != DialogResult.Yes)
				return;

			// 删除
			while (count > 0)
			{
				Host toDelete = removeList[--count].Tag as Host;
				hostList.Remove(toDelete);
			}
			Edited = true;
			listViewHost.ReloadList();
		}

		/// <summary>
		/// 从默认位置读取Host
		/// </summary>
		private void LoadHostFile(string hostFile)
		{
			try
			{
				this.hostList = new HostList(hostFile);
			}
			catch (FileNotFoundException)
			{
				MessageBoxEx.Exclamation("以下Host文件读取失败：\r\n" + hostFile , "读取失败");
			}
		}

		private readonly string cacheFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\host.cache";
		/// <summary>
		/// 将HostList保存到默认Host文件中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Save(object sender , EventArgs e)
		{

			if (!Edited)
			{
				txtStatus.Text = "没有需要保存的修改";
				return;
			}

			string savePath = Security.IsAdministrator
				? Host.SYSTEM_HOST_PATH
				: cacheFilePath;

			if (btnEditSource.Checked)
				File.WriteAllText(savePath , (btnEditSource.Tag as TextBox).Text , System.Text.Encoding.Default);
			else
				hostList.SaveToFile(savePath);

			// 不是管理员，需要重启
			if (!Security.IsAdministrator)
			{
				ProcessStartInfo startInfo = new ProcessStartInfo();
				startInfo.UseShellExecute = true;
				startInfo.WorkingDirectory = Environment.CurrentDirectory;
				startInfo.FileName = Application.ExecutablePath;
				startInfo.Arguments = "-savecache";
				if (btnEditSource.Checked)
					startInfo.Arguments += " -source";
				startInfo.Verb = "runas";
				try
				{
					Process p = Process.Start(startInfo);
					Edited = false;
					Application.Exit();
				}
				catch (System.ComponentModel.Win32Exception)
				{
					MessageBoxEx.Exclamation("保存到系统Host文件需要管理员权限！");
					return;
				}
			}

			Edited = false;
			txtStatus.Text = "修改已保存于 " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
		}

		/// <summary>
		/// 导入
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Import(object sender , EventArgs e)
		{
			FrmImport frmImport = new FrmImport();
			frmImport.ResultHostList = hostList;

			if (sender.GetType() == typeof(string))
				frmImport.FileToImport = sender as string;

			if (frmImport.ShowDialog() == DialogResult.OK)
			{
				listViewHost.ReloadList();
				MessageBoxEx.Information(String.Format("导入/更新了 {0} 条记录" , frmImport.ImportedCount));
				Edited = true;
			}
		}

		/// <summary>
		/// 导出
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Export(object sender , EventArgs e)
		{
			exportDialog.ShowDialog();
			if (exportDialog.FileName.Trim().Length == 0)
				return;

			hostList.SaveToFile(exportDialog.FileName);
		}

		#endregion

		#region 控件事件
		/// <summary>
		/// 显示关于窗体
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShowAboutClick(object sender , EventArgs e)
		{
			MessageBoxEx.Information("Host小工具v3.0，Power By Techird.\r\nDate 2011/08/04" , "关于");
		}

		/// <summary>
		/// 窗体加载
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnFormLoad(object sender , EventArgs e)
		{
			this.Edited = false;
			string args = Program.GetCommandArgs();

			if (args.Contains("-savecache") && Security.IsAdministrator && File.Exists(cacheFilePath))
			{
				LoadHostFile(cacheFilePath);
				this.Edited = true;
				Save(sender , e);
				if (args.Contains("-source"))
				{
					OnEditSourceClick(sender , e);
					return;
				}
			}

			LoadHostFile(Host.SYSTEM_HOST_PATH);
			if (File.Exists(args))
			{
				Import(args , e);
			}

			listViewHost.SetHostList(hostList);

            LoadIPListFromSystem();
		}


		/// <summary>
		/// 直接编辑Host文件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEditSourceClick(object sender , EventArgs e)
		{

			if (!btnEditSource.Checked)
			{
				// 请求查看源代码
				if (Edited)
					Save(sender , e);

				TextBox txtSource = new TextBox()
				{
					Text = File.ReadAllText(Host.SYSTEM_HOST_PATH , System.Text.Encoding.Default) ,
					Font = new System.Drawing.Font("Consolas" , 9) ,
					Multiline = true ,
					ScrollBars = ScrollBars.Vertical ,
					Location = listViewHost.Location ,
					Size = listViewHost.Size ,
					Anchor = listViewHost.Anchor ,
					Parent = listViewHost.Parent
				};
				txtSource.TextChanged += OnSourceChanged;
				txtSource.KeyDown += OnKeyDown;
				btnEditSource.Tag = txtSource;
				listViewHost.Visible = false;
				btnEditSource.Checked = true;
			}
			else
			{
				// 退出源代码查看模式
				TextBox txtSource = btnEditSource.Tag as TextBox;
				if (Edited)
				{
					var result = MessageBoxEx.Confirm("是否保存源代码的修改?");

					if (result == DialogResult.Cancel)
						return;

					if (Edited && result == DialogResult.Yes)
						Save(sender , e);
					Edited = false;
				}

				hostList = new HostList(Host.SYSTEM_HOST_PATH);
				listViewHost.SetHostList(hostList);

				txtSource.Dispose();
				listViewHost.Visible = true;
				btnEditSource.Checked = false;
			}
			btnAdd.Enabled
				= btnEdit.Enabled
				= btnDelete.Enabled
				= btnImport.Enabled
				= btnExport.Enabled
				= dropDownView.Enabled
				= !btnEditSource.Checked;
		}

		/// <summary>
		/// 源代码改变
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnSourceChanged(object sender , EventArgs e)
		{
			var txtSource = sender as TextBox;
			txtSource.Tag = true;
			Edited = true;
		}

		/// <summary>
		/// 关闭前提示保存
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnFormClosing(object sender , FormClosingEventArgs e)
		{
			if (Edited && MessageBoxEx.Confirm("希望保存修改吗？" , "有需要保存的修改") == System.Windows.Forms.DialogResult.Yes)
			{
				Save(sender , e);
			}
		}

		/// <summary>
		/// 更改显示方式的功能
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnViewChange(object sender , ToolStripItemClickedEventArgs e)
		{

			if (Enum.IsDefined(typeof(View) , e.ClickedItem.Tag))
			{
				View? view = Enum.Parse(typeof(View) , e.ClickedItem.Tag.ToString()) as View?;

				this.dropDownView.DropDownItems.OfType<ToolStripMenuItem>()
					.Single(x => x.Tag.ToString() == listViewHost.View.ToString()).Checked = false;
				this.menuView.DropDownItems.OfType<ToolStripMenuItem>()
					.Single(x => x.Tag.ToString() == listViewHost.View.ToString()).Checked = false;

				listViewHost.View = view.Value;

				this.dropDownView.DropDownItems.OfType<ToolStripMenuItem>()
					.Single(x => x.Tag.ToString() == view.ToString()).Checked = true;
				this.menuView.DropDownItems.OfType<ToolStripMenuItem>()
					.Single(x => x.Tag.ToString() == view.ToString()).Checked = true;
			}

			if (e.ClickedItem.Tag.ToString() == "ShowGroup")
			{
				listViewHost.ShowGroups = !listViewHost.ShowGroups;
				this.dropDownView.DropDownItems.OfType<ToolStripMenuItem>()
					.Single(x => x.Tag.ToString() == "ShowGroup").Checked = listViewHost.ShowGroups;
				this.menuView.DropDownItems.OfType<ToolStripMenuItem>()
					.Single(x => x.Tag.ToString() == "ShowGroup").Checked = listViewHost.ShowGroups;
			}
		}

		#endregion

		#region IP地址模块
		/// <summary>
		/// 单击某个IP地址
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnIPClick(object sender , EventArgs e)
		{
			ToolStripItem item = (ToolStripItem)sender;
			FrmIPAddressInfo ipi = new FrmIPAddressInfo();
			ipi.ip = (IPAddress)item.Tag;
			ipi.ShowDialog();
		}

		/// <summary>
		/// 比较两个IP地址用于排序
		/// </summary>
		/// <param name="ip1"></param>
		/// <param name="ip2"></param>
		/// <returns></returns>
		private static int IPComparer(IPAddress ip1 , IPAddress ip2)
		{
			string ips1 = ip1.ToString();
			string ips2 = ip2.ToString();
			if (ips1.IndexOf(":") * ips2.IndexOf(":") > 0)
				return ip1.ToString().CompareTo(ip2.ToString());
			else
				return ips1.IndexOf(":") - ips2.IndexOf(":");
		}

		/// <summary>
		/// 获得系统IP地址列表
		/// </summary>
		private void LoadIPListFromSystem()
		{
			List<IPAddress> ipas = Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToList();
			ipas.Sort(IPComparer);

			foreach (IPAddress ipa in ipas)
			{
				cboIp.DropDownItems.Add(ipa.ToString() , null , OnIPClick).Tag = ipa;

			}
		}
		#endregion

		private void OnContextMenuOpening(object sender , System.ComponentModel.CancelEventArgs e)
		{

			var selected = listViewHost.SelectedItems;
			int count = selected.Count;

			menuEnabled.Enabled = count > 0;
			menuEdit.Enabled = count == 1;
			menuDelete.Enabled = count > 0;
			menuSetGroup.Enabled = count > 0 && listViewHost.View != View.List && listViewHost.ShowGroups;
			menuPing.Enabled = count == 1;
			menuBrowser.Enabled = count == 1;

			menuEnabled.Checked = menuEnabled.Enabled;

			string groupText = null;
			foreach (ListViewItem item in selected)
			{
				Host host = item.Tag as Host;
				if (host.Enabled == false)
					menuEnabled.Checked = false;
				if (groupText == null)
					groupText = host.GroupName;
				else if (groupText != host.GroupName)
					groupText = "选择或输入组名";
			}

			txtGroupName.Text = "";
			txtGroupName.Enabled = menuSetGroup.Enabled;
			if (!txtGroupName.Enabled)
				return;
			txtGroupName.Items.Clear();
			txtGroupName.Items.AddRange(hostList.HostGroups.Select(x => x.Key).ToArray());
			txtGroupName.Text = groupText;

			menuEnabled.Text = menuEnabled.Checked ? "禁用 (&B)" : "启用 (&B)";
		}

		private void SetEnabled(object sender , EventArgs e)
		{
			menuEnabled.Checked = !menuEnabled.Checked;
			listViewHost.SetSelectedItemEnabled(menuEnabled.Checked);
			Edited = true;
		}

		private void SetGroup(object sender , KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				var selected = listViewHost.SelectedItems;
				foreach (ListViewItem item in selected)
				{
					Host host = item.Tag as Host;
					host.GroupName = txtGroupName.Text;
				}
				listViewHost.ReloadList();
				Edited = true;
				contextMenuStrip.Close();
			}
		}

		private void OnMenuPingClick(object sender , EventArgs e)
		{
			Host host = listViewHost.SelectedItems[0].Tag as Host;

			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = "cmd";
			if (sender == menuPing)
				startInfo.Arguments = "/c ping " + host.ServerName;
			if (sender == menuPingt)
				startInfo.Arguments = "/c ping -t " + host.ServerName;
			if (sender == menuPing6)
				startInfo.Arguments = "/c ping -6 " + host.ServerName;
			if (sender == menuPingAddress)
				startInfo.Arguments = "/c ping " + host.ServerAddress;
			startInfo.Arguments += " & @echo ---------------------------------------------------------------------------- & pause";
			startInfo.CreateNoWindow = false;
			startInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);

			Process.Start(startInfo);
		}

		private void OnKeyDown(object sender , KeyEventArgs e)
		{
			if (sender.GetType() == typeof(TextBox))
			{
				if (e.Control && e.KeyCode == Keys.C)
					(sender as TextBox).Copy();
				else if (e.Control && e.KeyCode == Keys.V)
					(sender as TextBox).Paste();
				else if (e.Control && e.KeyCode == Keys.A)
					(sender as TextBox).SelectAll();
				else if (e.Control && e.KeyCode == Keys.Z)
					(sender as TextBox).Undo();
				if (e.Control)
					e.SuppressKeyPress = true;
				else
					return;
			}

			if (sender != this)
				e.SuppressKeyPress = true;

			if (e.Control && e.KeyCode == Keys.S)
				Save(sender , e);
			if (e.KeyData == Keys.F1)
				OnShowAboutClick(sender , e);
			if (e.KeyData == Keys.Enter && listViewHost.Visible == true)
				Edit(sender , e);

		}

		private Thread t1 = null , t2 = null;
		private void OnStatusChange(object sender , EventArgs e)
		{
			if (t1 != null)
				t1.Abort();
			t1 = new Thread(new ThreadStart(delegate
			{

				Thread.Sleep(500);
				txtStatus.ImageAlign = ContentAlignment.TopLeft;
				Thread.Sleep(90);
				txtStatus.ImageAlign = ContentAlignment.MiddleLeft;
				Thread.Sleep(60);
				txtStatus.ImageAlign = ContentAlignment.BottomLeft;
				Thread.Sleep(60);
				txtStatus.ImageAlign = ContentAlignment.MiddleLeft;
				Thread.Sleep(90);
				txtStatus.ImageAlign = ContentAlignment.MiddleLeft;
				Thread.Sleep(120);
			}));

			if (t2 != null)
				t2.Abort();
			t2 = new Thread(new ThreadStart(delegate
			{
				int i = 0;
				while (i++ < 240)
				{
					SetStatusForcolor(Color.FromArgb(i , i / 4 , 0));
					Thread.Sleep(2);
				}
				Thread.Sleep(800);
				while (--i > 0)
				{
					SetStatusForcolor(Color.FromArgb(i , i / 4 , 0));
					Thread.Sleep(8);
				}
			}));
			try
			{
				t1.Start();
				t2.Start();
			}
			catch (Exception ex)
			{ }
		}

		private delegate void SetStatusForcolorCallback(Color color);

		private void SetStatusForcolor(Color color)
		{
			try
			{
				if (txtStatus.GetCurrentParent().InvokeRequired)
				{
					SetStatusForcolorCallback d = new SetStatusForcolorCallback(SetStatusForcolor);
					this.Invoke(d , new object[] { color });
				}
				else
				{
					txtStatus.ForeColor = color;
				}
			}
			catch
			{
				t1.Abort();
				t2.Abort();
				return;
			}
		}

		private void OnMenuBrowserOpening(object sender , EventArgs e)
		{
			string server = (this.listViewHost.SelectedItems[0].Tag as Host).ServerName;
			menuOpenHttp.Text = String.Format("打开 http://{0}/" , server);
			menuOpenSMB.Text = string.Format("打开 \\\\{0}\\" , server);
			menuOpenFtp.Text = string.Format("打开 ftp://{0}/" , server);
		}

		private void OpenHttp(object sender , EventArgs e)
		{
			string server = (this.listViewHost.SelectedItems[0].Tag as Host).ServerName;
			string address = String.Format("http://{0}/" , server);
			shell(address);
		}

		private void shell(string content)
		{
			Process.Start(new ProcessStartInfo()
			{
				UseShellExecute = true ,
				FileName = content
			});
		}
	}
}
