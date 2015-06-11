using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HostEditor
{


	public partial class FrmImport : Form
	{
		private enum Step { ChooseFile = 0 , ChooseRecord = 1 , Finish = 2 }
		private Step step = Step.ChooseFile;
		private Step CurrentStep
		{
			get
			{
				return step;
			}
			set
			{
				step = value;
				switch (step)
				{
					case Step.ChooseFile:
						tabStepChooseFile.ImageKey = "current";
						tabStepChooseHost.ImageKey = null;
						tabStepFinish.ImageKey = null;
						tabWinzard.SelectedTab = tabStepChooseFile;
						break;
					case Step.ChooseRecord:
						tabStepChooseFile.ImageKey = "finished";
						tabStepChooseHost.ImageKey = "current";
						tabStepFinish.ImageKey = null;
						tabWinzard.SelectedTab = tabStepChooseHost;
						break;
					case Step.Finish:
						tabStepChooseFile.ImageKey = "finished";
						tabStepChooseHost.ImageKey = "finished";
						tabStepFinish.ImageKey = "finished";
						tabWinzard.SelectedTab = tabStepFinish;
						txtImportLable.Text = String.Format("点击完成开始导入 {0} 条记录" , hostListViewImport.CheckedItems.Count);
						break;
				}
				btnPrev.Enabled = (int)step > (int)Step.ChooseFile;
				btnNext.Enabled = (int)step < (int)Step.Finish && importPrepared;
			}
		}
		private bool importPrepared = false;

		/// <summary>
		/// 获取或设置需要导入的文件的位置
		/// </summary>
		public string FileToImport
		{
			get;
			set;
		}

		/// <summary>
		/// 设置或获取导入筛选的结果
		/// </summary>
		public HostList ResultHostList
		{
			get;
			set;
		}

		public int ImportedCount
		{
			get;
			private set;
		}

		private void Import(object sender = null , EventArgs e = null)
		{
			if (!importPrepared)
				return;

			var selected =
				hostListViewImport.Items
				.OfType<ListViewItem>()
				.Where(x => x.Checked)
				.Select(x => x.Tag as Host);

			if (ResultHostList == null)
				ResultHostList = new HostList();

			if (chkReplace.Checked)
				ResultHostList.RemoveAll(x => true);
			else
				ResultHostList.RemoveAll(x => selected.FirstOrDefault(c => c.ServerName == x.ServerName) != null);

			ResultHostList.AddRange(selected);
			ImportedCount = hostListViewImport.CheckedItems.Count;
			this.DialogResult = DialogResult.OK;
		}

		public FrmImport()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender , EventArgs e)
		{
			if (this.FileToImport != null)
			{
				OpenHostFile();
				if (importPrepared)
					NextStep(sender , e);
			}
			else
			{
				CurrentStep = Step.ChooseFile;
			}
		}

		private void SelectAll(object sender = null , EventArgs e = null)
		{
			Boolean check = true;
			if (sender != null && hostListViewImport.CheckedItems.Count > 0)
				check = false;

			foreach (ListViewItem item in hostListViewImport.Items)
			{
				item.Checked = check;
			}
		}

		private void OpenHostFile()
		{
			txtReport.Text = "";
			txtReport.Text += "要导入的文件：" + FileToImport + Environment.NewLine;
			try
			{
				if (!string.IsNullOrEmpty(FileToImport) && File.Exists(FileToImport))
				{
					txtPreview.Text = File.ReadAllText(FileToImport , Encoding.Default);
					if (txtPreview.Text.Length > 10240
						&& MessageBoxEx.Confirm("文件较大，确定要继续加载么？") != DialogResult.Yes)
						return;
				}
				txtReport.Text += "文件打开成功" + Environment.NewLine + Environment.NewLine;
			}
			catch (Exception ex)
			{
				MessageBoxEx.Exclamation(ex.Message , "打开文件失败");
				return;
			}
			txtHostFile.Text = this.FileToImport;

			HostList hostForSelecting = null;
			try
			{
				hostForSelecting = new HostList(this.FileToImport);
			}
			catch (Exception ex)
			{
				txtReport.Text += "读取错误：" + ex.Message;
				return;
			}

			if (hostForSelecting.HeadString != null)
				txtReport.Text += Environment.NewLine
					+ "## Host文件声明部分" + Environment.NewLine
					+ hostForSelecting.HeadString
					+ "## 声明结束" + Environment.NewLine;

			foreach (var ex in hostForSelecting.LoadExceptions)
			{
				txtReport.Text += String.Format("无效记录行（{0}）：  {1}" , ex.LineNumber , ex.HostLine + Environment.NewLine);
			}

			txtReport.Text += Environment.NewLine + String.Format("共读取了{0}条记录" , hostForSelecting.Count);
			txtReport.SelectAll();
			txtReport.ScrollToCaret();

			hostListViewImport.SetHostList(hostForSelecting);
			this.SelectAll();
			btnFinish.Enabled = true;
			btnNext.Enabled = true;
			importPrepared = true;
		}

		private void OnBtnChooseFileClick(object sender , EventArgs e)
		{
			var result = openFileDialog.ShowDialog();
			if (result != DialogResult.OK)
				return;
			this.FileToImport = openFileDialog.FileName;
			this.OpenHostFile();
		}

		private void NextStep(object sender , EventArgs e)
		{
			CurrentStep = (Step)((int)CurrentStep + 1);
		}

		private bool CanGotoStep(Step step)
		{
			return step == Step.ChooseFile
				|| importPrepared;
		}

		private void OnTabStepChange(object sender , TabControlCancelEventArgs e)
		{
			Step stepGoingTo = (Step)e.TabPageIndex;
			e.Cancel = !CanGotoStep(stepGoingTo);
			if (!e.Cancel)
			{
				this.CurrentStep = stepGoingTo;
			}
		}

		private void OnBtnCancelClick(object sender , EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void PrevStep(object sender , EventArgs e)
		{
			CurrentStep = (Step)((int)CurrentStep - 1);
		}
	}
}
