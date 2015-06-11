namespace HostEditor
{
	partial class FrmMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("默认", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ExampleServer",
            "127.0.0.1",
            "",
            "已启用"}, 0);
			HostEditor.Host host1 = new HostEditor.Host();
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("ExampleServer", 0);
			HostEditor.Host host2 = new HostEditor.Host();
			this.toolStripHostEditor = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnEditSource = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImport = new System.Windows.Forms.ToolStripButton();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAbout = new System.Windows.Forms.ToolStripButton();
			this.statusStripHostEditor = new System.Windows.Forms.StatusStrip();
			this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.cboIp = new System.Windows.Forms.ToolStripDropDownButton();
			this.txtSpring = new System.Windows.Forms.ToolStripStatusLabel();
			this.dropDownView = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemList = new System.Windows.Forms.ToolStripMenuItem();
			this.exportDialog = new System.Windows.Forms.SaveFileDialog();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.menuEnabled = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSetGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.txtGroupName = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuPing = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPingt = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPing6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.menuPingAddress = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.menuBrowser = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenHttp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenSMB = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFtp = new System.Windows.Forms.ToolStripMenuItem();
			this.listViewHost = new HostEditor.HostListView();
			this.toolStripHostEditor.SuspendLayout();
			this.statusStripHostEditor.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripHostEditor
			// 
			this.toolStripHostEditor.AllowItemReorder = true;
			this.toolStripHostEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStripHostEditor.AutoSize = false;
			this.toolStripHostEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStripHostEditor.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripHostEditor.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripHostEditor.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStripHostEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnSave,
            this.btnEditSource,
            this.toolStripSeparator1,
            this.btnImport,
            this.btnExport,
            this.toolStripSeparator2,
            this.btnAbout});
			this.toolStripHostEditor.Location = new System.Drawing.Point(8, 2);
			this.toolStripHostEditor.Name = "toolStripHostEditor";
			this.toolStripHostEditor.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStripHostEditor.Size = new System.Drawing.Size(772, 46);
			this.toolStripHostEditor.TabIndex = 0;
			this.toolStripHostEditor.Text = "toolStrip1";
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(68, 43);
			this.btnAdd.Text = "新建";
			this.btnAdd.ToolTipText = "新建Host记录 (Ctrl + N)\r\n添加一条具有指定服务器名称、地址、分组和注释的Host记录";
			this.btnAdd.Click += new System.EventHandler(this.New);
			// 
			// btnEdit
			// 
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(68, 43);
			this.btnEdit.Text = "编辑";
			this.btnEdit.ToolTipText = "编辑Host记录\r\n编辑当前选中的Host记录";
			this.btnEdit.Click += new System.EventHandler(this.Edit);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(68, 43);
			this.btnDelete.Text = "删除";
			this.btnDelete.ToolTipText = "删除Host记录 (Delete)\r\n删除选中一条或多条的Host记录";
			this.btnDelete.Click += new System.EventHandler(this.Remove);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Black;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(72, 43);
			this.btnSave.Text = "保存 ";
			this.btnSave.ToolTipText = "保存 (Ctrl + S)\r\n将当前修改保存到系统默认的Host文件中";
			this.btnSave.Click += new System.EventHandler(this.Save);
			// 
			// btnEditSource
			// 
			this.btnEditSource.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSource.Image")));
			this.btnEditSource.ImageTransparentColor = System.Drawing.Color.Black;
			this.btnEditSource.Name = "btnEditSource";
			this.btnEditSource.Size = new System.Drawing.Size(80, 43);
			this.btnEditSource.Text = "源文件";
			this.btnEditSource.ToolTipText = "编辑源文件\r\n直接编辑系统的Host文件";
			this.btnEditSource.Click += new System.EventHandler(this.OnEditSourceClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
			// 
			// btnImport
			// 
			this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
			this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(68, 43);
			this.btnImport.Text = "导入";
			this.btnImport.ToolTipText = "导入Host记录\r\n打开导入向导，你可以合并Host记录";
			this.btnImport.Click += new System.EventHandler(this.Import);
			// 
			// btnExport
			// 
			this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(68, 43);
			this.btnExport.Text = "导出";
			this.btnExport.ToolTipText = "导出Host记录\r\n将选中的Host记录导出到.host文件中，\r\n如果并未选择记录，则导出整个文件";
			this.btnExport.Click += new System.EventHandler(this.Export);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
			// 
			// btnAbout
			// 
			this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
			this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(68, 43);
			this.btnAbout.Text = "关于";
			this.btnAbout.ToolTipText = "关于 (F1)\r\n这是Techird写的\r\n至于你信不信，反正我是信了";
			this.btnAbout.Click += new System.EventHandler(this.OnShowAboutClick);
			// 
			// statusStripHostEditor
			// 
			this.statusStripHostEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus,
            this.cboIp,
            this.txtSpring,
            this.dropDownView});
			this.statusStripHostEditor.Location = new System.Drawing.Point(0, 524);
			this.statusStripHostEditor.Name = "statusStripHostEditor";
			this.statusStripHostEditor.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStripHostEditor.Size = new System.Drawing.Size(784, 26);
			this.statusStripHostEditor.TabIndex = 2;
			this.statusStripHostEditor.Text = "statusStrip1";
			// 
			// txtStatus
			// 
			this.txtStatus.AutoSize = false;
			this.txtStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.txtStatus.Image = ((System.Drawing.Image)(resources.GetObject("txtStatus.Image")));
			this.txtStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
			this.txtStatus.MergeAction = System.Windows.Forms.MergeAction.Replace;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(300, 21);
			this.txtStatus.Text = "状态";
			this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtStatus.TextChanged += new System.EventHandler(this.OnStatusChange);
			// 
			// cboIp
			// 
			this.cboIp.AutoSize = false;
			this.cboIp.Image = ((System.Drawing.Image)(resources.GetObject("cboIp.Image")));
			this.cboIp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cboIp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cboIp.Name = "cboIp";
			this.cboIp.Size = new System.Drawing.Size(72, 24);
			this.cboIp.Text = "本机IP";
			this.cboIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSpring
			// 
			this.txtSpring.AutoSize = false;
			this.txtSpring.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.txtSpring.Name = "txtSpring";
			this.txtSpring.Size = new System.Drawing.Size(332, 21);
			this.txtSpring.Spring = true;
			this.txtSpring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dropDownView
			// 
			this.dropDownView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem6,
            this.toolStripMenuItemLargeIcon,
            this.toolStripMenuItemSmallIcon,
            this.toolStripMenuItemTile,
            this.toolStripMenuItemDetail,
            this.toolStripMenuItemList});
			this.dropDownView.Image = ((System.Drawing.Image)(resources.GetObject("dropDownView.Image")));
			this.dropDownView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.dropDownView.Name = "dropDownView";
			this.dropDownView.Size = new System.Drawing.Size(61, 24);
			this.dropDownView.Text = "查看";
			this.dropDownView.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnViewChange);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Checked = true;
			this.toolStripMenuItem8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem8.Tag = "ShowGroup";
			this.toolStripMenuItem8.Text = "分组 (&G)";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(142, 6);
			// 
			// toolStripMenuItemLargeIcon
			// 
			this.toolStripMenuItemLargeIcon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemLargeIcon.Image")));
			this.toolStripMenuItemLargeIcon.Name = "toolStripMenuItemLargeIcon";
			this.toolStripMenuItemLargeIcon.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItemLargeIcon.Tag = "LargeIcon";
			this.toolStripMenuItemLargeIcon.Text = "大图标 (&R)";
			// 
			// toolStripMenuItemSmallIcon
			// 
			this.toolStripMenuItemSmallIcon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSmallIcon.Image")));
			this.toolStripMenuItemSmallIcon.Name = "toolStripMenuItemSmallIcon";
			this.toolStripMenuItemSmallIcon.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItemSmallIcon.Tag = "SmallIcon";
			this.toolStripMenuItemSmallIcon.Text = "小图标 (&N)";
			// 
			// toolStripMenuItemTile
			// 
			this.toolStripMenuItemTile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTile.Image")));
			this.toolStripMenuItemTile.Name = "toolStripMenuItemTile";
			this.toolStripMenuItemTile.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItemTile.Tag = "Tile";
			this.toolStripMenuItemTile.Text = "平铺 (&S)";
			// 
			// toolStripMenuItemDetail
			// 
			this.toolStripMenuItemDetail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDetail.Image")));
			this.toolStripMenuItemDetail.Name = "toolStripMenuItemDetail";
			this.toolStripMenuItemDetail.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItemDetail.Tag = "List";
			this.toolStripMenuItemDetail.Text = "列表 (&L)";
			// 
			// toolStripMenuItemList
			// 
			this.toolStripMenuItemList.Checked = true;
			this.toolStripMenuItemList.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemList.Image")));
			this.toolStripMenuItemList.Name = "toolStripMenuItemList";
			this.toolStripMenuItemList.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItemList.Tag = "Details";
			this.toolStripMenuItemList.Text = "详细信息 (&D)";
			// 
			// exportDialog
			// 
			this.exportDialog.DefaultExt = "host";
			this.exportDialog.Filter = "Host文件|*.host";
			this.exportDialog.Title = "选择导出位置";
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuView,
            this.toolStripMenuItem7,
            this.menuEnabled,
            this.toolStripMenuItem3,
            this.menuAdd,
            this.menuEdit,
            this.menuDelete,
            this.toolStripMenuItem1,
            this.menuSetGroup,
            this.txtGroupName,
            this.toolStripMenuItem2,
            this.menuPing,
            this.toolStripMenuItem4,
            this.menuBrowser});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.contextMenuStrip.Size = new System.Drawing.Size(213, 239);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuOpening);
			// 
			// menuView
			// 
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripSeparator4,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
			this.menuView.Image = ((System.Drawing.Image)(resources.GetObject("menuView.Image")));
			this.menuView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(212, 22);
			this.menuView.Text = "查看 (&V)";
			this.menuView.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnViewChange);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Checked = true;
			this.toolStripMenuItem9.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem9.Tag = "ShowGroup";
			this.toolStripMenuItem9.Text = "分组 (&G)";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem10.Tag = "LargeIcon";
			this.toolStripMenuItem10.Text = "大图标 (&R)";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem11.Tag = "SmallIcon";
			this.toolStripMenuItem11.Text = "小图标 (&N)";
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem12.Tag = "Tile";
			this.toolStripMenuItem12.Text = "平铺 (&S)";
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem13.Image")));
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem13.Tag = "List";
			this.toolStripMenuItem13.Text = "列表 (&L)";
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.Checked = true;
			this.toolStripMenuItem14.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem14.Image")));
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem14.Tag = "Details";
			this.toolStripMenuItem14.Text = "详细信息 (&D)";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(209, 6);
			// 
			// menuEnabled
			// 
			this.menuEnabled.Image = ((System.Drawing.Image)(resources.GetObject("menuEnabled.Image")));
			this.menuEnabled.Name = "menuEnabled";
			this.menuEnabled.Size = new System.Drawing.Size(212, 22);
			this.menuEnabled.Text = "启用 (A)";
			this.menuEnabled.Click += new System.EventHandler(this.SetEnabled);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 6);
			// 
			// menuAdd
			// 
			this.menuAdd.Image = ((System.Drawing.Image)(resources.GetObject("menuAdd.Image")));
			this.menuAdd.Name = "menuAdd";
			this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuAdd.Size = new System.Drawing.Size(212, 22);
			this.menuAdd.Text = "添加 (&N)";
			this.menuAdd.Click += new System.EventHandler(this.New);
			// 
			// menuEdit
			// 
			this.menuEdit.Image = ((System.Drawing.Image)(resources.GetObject("menuEdit.Image")));
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Size = new System.Drawing.Size(212, 22);
			this.menuEdit.Text = "编辑 (&E)";
			this.menuEdit.Click += new System.EventHandler(this.Edit);
			// 
			// menuDelete
			// 
			this.menuDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuDelete.Image")));
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.menuDelete.Size = new System.Drawing.Size(212, 22);
			this.menuDelete.Text = "删除 (&R)";
			this.menuDelete.Click += new System.EventHandler(this.Remove);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
			// 
			// menuSetGroup
			// 
			this.menuSetGroup.Image = ((System.Drawing.Image)(resources.GetObject("menuSetGroup.Image")));
			this.menuSetGroup.Name = "menuSetGroup";
			this.menuSetGroup.Size = new System.Drawing.Size(212, 22);
			this.menuSetGroup.Text = "设置分组";
			this.menuSetGroup.ToolTipText = "在下拉框输入或选择组名\r\n按Enter确认修改\r\n按Esc取消";
			// 
			// txtGroupName
			// 
			this.txtGroupName.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(152, 25);
			this.txtGroupName.Text = "输入新组";
			this.txtGroupName.ToolTipText = "按Enter确认修改\r\n按Esc取消";
			this.txtGroupName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetGroup);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
			// 
			// menuPing
			// 
			this.menuPing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPingt,
            this.menuPing6,
            this.toolStripMenuItem5,
            this.menuPingAddress});
			this.menuPing.Image = ((System.Drawing.Image)(resources.GetObject("menuPing.Image")));
			this.menuPing.Name = "menuPing";
			this.menuPing.Size = new System.Drawing.Size(212, 22);
			this.menuPing.Text = "&Ping";
			this.menuPing.Click += new System.EventHandler(this.OnMenuPingClick);
			// 
			// menuPingt
			// 
			this.menuPingt.Name = "menuPingt";
			this.menuPingt.Size = new System.Drawing.Size(164, 22);
			this.menuPingt.Text = "循环ping -t";
			this.menuPingt.Click += new System.EventHandler(this.OnMenuPingClick);
			// 
			// menuPing6
			// 
			this.menuPing6.Name = "menuPing6";
			this.menuPing6.Size = new System.Drawing.Size(164, 22);
			this.menuPing6.Text = "强制使用IPv6 -6";
			this.menuPing6.Click += new System.EventHandler(this.OnMenuPingClick);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(161, 6);
			// 
			// menuPingAddress
			// 
			this.menuPingAddress.Name = "menuPingAddress";
			this.menuPingAddress.Size = new System.Drawing.Size(164, 22);
			this.menuPingAddress.Text = "直接ping地址";
			this.menuPingAddress.Click += new System.EventHandler(this.OnMenuPingClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 6);
			// 
			// menuBrowser
			// 
			this.menuBrowser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenHttp,
            this.menuOpenSMB,
            this.menuOpenFtp});
			this.menuBrowser.Name = "menuBrowser";
			this.menuBrowser.Size = new System.Drawing.Size(212, 22);
			this.menuBrowser.Text = "浏览 (&B)";
			this.menuBrowser.DropDownOpening += new System.EventHandler(this.OnMenuBrowserOpening);
			// 
			// menuOpenHttp
			// 
			this.menuOpenHttp.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenHttp.Image")));
			this.menuOpenHttp.Name = "menuOpenHttp";
			this.menuOpenHttp.Size = new System.Drawing.Size(231, 22);
			this.menuOpenHttp.Text = "打开 http://www.baidu.com";
			this.menuOpenHttp.Click += new System.EventHandler(this.OpenHttp);
			// 
			// menuOpenSMB
			// 
			this.menuOpenSMB.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenSMB.Image")));
			this.menuOpenSMB.Name = "menuOpenSMB";
			this.menuOpenSMB.Size = new System.Drawing.Size(231, 22);
			this.menuOpenSMB.Text = "打开 \\\\techird";
			// 
			// menuOpenFtp
			// 
			this.menuOpenFtp.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenFtp.Image")));
			this.menuOpenFtp.Name = "menuOpenFtp";
			this.menuOpenFtp.Size = new System.Drawing.Size(231, 22);
			this.menuOpenFtp.Text = "打开 ftp://www.baidu.com";
			// 
			// listViewHost
			// 
			this.listViewHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewHost.ContextMenuStrip = this.contextMenuStrip;
			this.listViewHost.FullRowSelect = true;
			listViewGroup1.Header = "默认";
			listViewGroup1.Name = "默认";
			listViewGroup2.Header = "默认";
			listViewGroup2.Name = "默认";
			listViewGroup3.Header = "默认";
			listViewGroup3.Name = "默认";
			listViewGroup4.Header = "默认";
			listViewGroup4.Name = "默认";
			listViewGroup5.Header = "默认";
			listViewGroup5.Name = "默认";
			listViewGroup6.Header = "默认";
			listViewGroup6.Name = "默认";
			listViewGroup7.Header = "默认";
			listViewGroup7.Name = "默认";
			listViewGroup8.Header = "默认";
			listViewGroup8.Name = "默认";
			this.listViewHost.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
			this.listViewHost.GroupState = HostEditor.ListViewGroupState.Normal;
			this.listViewHost.HideSelection = false;
			listViewItem1.Group = listViewGroup1;
			host1.Comment = null;
			host1.Container = null;
			host1.Enabled = true;
			host1.GroupName = "默认";
			host1.ServerAddress = "127.0.0.1";
			host1.ServerName = "ExampleServer";
			listViewItem1.Tag = host1;
			listViewItem2.Group = listViewGroup8;
			host2.Comment = null;
			host2.Container = null;
			host2.Enabled = true;
			host2.GroupName = "默认";
			host2.ServerAddress = "127.0.0.1";
			host2.ServerName = "ExampleServer";
			listViewItem2.Tag = host2;
			this.listViewHost.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.listViewHost.Location = new System.Drawing.Point(3, 51);
			this.listViewHost.Name = "listViewHost";
			this.listViewHost.Size = new System.Drawing.Size(777, 473);
			this.listViewHost.TabIndex = 1;
			this.listViewHost.UseCompatibleStateImageBehavior = false;
			this.listViewHost.View = System.Windows.Forms.View.Details;
			this.listViewHost.DoubleClick += new System.EventHandler(this.Edit);
			this.listViewHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 550);
			this.Controls.Add(this.listViewHost);
			this.Controls.Add(this.statusStripHostEditor);
			this.Controls.Add(this.toolStripHostEditor);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Host编辑工具";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			this.toolStripHostEditor.ResumeLayout(false);
			this.toolStripHostEditor.PerformLayout();
			this.statusStripHostEditor.ResumeLayout(false);
			this.statusStripHostEditor.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion


		private System.Windows.Forms.ToolStrip toolStripHostEditor;
		private System.Windows.Forms.StatusStrip statusStripHostEditor;
		private HostListView listViewHost;

		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnEditSource;
		private System.Windows.Forms.ToolStripButton btnAbout;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripStatusLabel txtStatus;
		private System.Windows.Forms.ToolStripStatusLabel txtSpring;
		private System.Windows.Forms.ToolStripDropDownButton cboIp;
		private System.Windows.Forms.ToolStripButton btnImport;
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.SaveFileDialog exportDialog;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuAdd;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuPing;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem menuSetGroup;
		private System.Windows.Forms.ToolStripMenuItem menuEnabled;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripComboBox txtGroupName;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem menuBrowser;
		private System.Windows.Forms.ToolStripMenuItem menuOpenHttp;
		private System.Windows.Forms.ToolStripMenuItem menuOpenSMB;
		private System.Windows.Forms.ToolStripMenuItem menuOpenFtp;
		private System.Windows.Forms.ToolStripMenuItem menuPingt;
		private System.Windows.Forms.ToolStripMenuItem menuPing6;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem menuPingAddress;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripDropDownButton dropDownView;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLargeIcon;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSmallIcon;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDetail;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemList;
		private System.Windows.Forms.ToolStripMenuItem menuView;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

	}
}

