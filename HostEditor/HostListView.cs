using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostEditor
{
	public partial class HostListView : ListViewExtended
	{
		private HostList hostList;
		public const int ENABLED_IMAGE = 0;
		private ImageList imageListSmall;
		private IContainer components;
		private ImageList imageListLarge;
		public const int DISABLED_IMAGE = 1;

		public void SetHostList(HostList hostList)
		{
			
			this.hostList = hostList;
			ReloadList();			
		}

		private ListViewItem BuildItemFromHost(Host host)
		{
			ListViewItem item = new ListViewItem();
			item.ImageIndex = host.Enabled ? ENABLED_IMAGE : DISABLED_IMAGE;
			item.Tag = host;
			item.Text = host.ServerName;
			var group = this.Groups[host.GroupName];
			item.Group = group != null ? group : this.Groups.Add(host.GroupName , host.GroupName);
			item.SubItems.Add(host.ServerAddress).Name = "Address";
			item.SubItems.Add(host.Comment).Name = "Comment";
			if (host.Enabled)
				item.SubItems.Add("已启用").Name = "Enabled";
			else
				item.SubItems.Add("未启用").Name = "Enabled";

			return item;
		}

		public void ReloadList()
		{
			this.Visible = false;
			this.Parent.UseWaitCursor = true;
			this.Items.Clear();
			this.Groups.Clear();
			foreach (Host host in hostList)
			{
				var item = BuildItemFromHost(host);
				Items.Add(item);
			}
			AdjustUI();
			this.Visible = true;
			this.Parent.UseWaitCursor = false;
		}

		public void SetSelectedItemEnabled(bool enabled)
		{
			var selected = this.SelectedItems;
			foreach (ListViewItem item in selected)
			{
				Host host = item.Tag as Host;
				host.Enabled = enabled;

				item.ImageIndex = host.Enabled ? HostListView.ENABLED_IMAGE : HostListView.DISABLED_IMAGE;
				item.SubItems["Enabled"].Text = host.Enabled ? "已启用" : "禁用";
			}
		}

		private void AdjustUI()
		{

			foreach (ColumnHeader column in this.Columns)
			{
				column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
				column.Width += Math.Max(column.Width / 10 , 30);
			}
			foreach (ListViewGroup group in this.Groups)
			{
				this.SetGroupFooter(group , String.Format("共 {0} 条记录" , group.Items.Count));
			}
			if (this.ShowGroups)
			{
				this.ShowGroups = false;
				this.ShowGroups = true;
			}
			this.GroupState = ListViewGroupState.Collapsible;
		}

		public HostListView()
		{
			this.InitializeComponent();

			this.Columns.Add("服务器");
			this.Columns.Add("地址");
			this.Columns.Add("注释");
			this.Columns.Add("已启用");
			this.GroupState = ListViewGroupState.Collapsible;
			this.ShowGroups = true;
			this.View = System.Windows.Forms.View.Details;
			this.LargeImageList = imageListLarge;
			this.SmallImageList = imageListSmall;

			Host exampleHost = new Host()
			{
				ServerName = "ExampleServer" ,
				Enabled = true ,
				GroupName = "默认" ,
				ServerAddress = "127.0.0.1"
			};

			this.Items.Add(BuildItemFromHost(exampleHost));
			AdjustUI();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostListView));
			this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
			this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// imageListSmall
			// 
			this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
			this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListSmall.Images.SetKeyName(0 , "monitor.png");
			this.imageListSmall.Images.SetKeyName(1 , "monitor_off.png");
			// 
			// imageListLarge
			// 
			this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
			this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListLarge.Images.SetKeyName(0 , "Computer On.png");
			this.imageListLarge.Images.SetKeyName(1 , "Computer Off.png");
			this.ResumeLayout(false);

		}
	}
}
