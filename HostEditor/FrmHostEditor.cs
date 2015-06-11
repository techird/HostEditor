using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace HostEditor
{
	public partial class FrmHostEditor : Form
	{
		public Host Host = new Host();
		public FrmHostEditor()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender , EventArgs e)
		{
			txtServerName.Text = Host.ServerName;
			txtServerAddress.Text = Host.ServerAddress;
			txtComment.Text = Host.Comment;
			if (Host.Container != null)
			{
				txtGroup.Items.Clear();
				txtGroup.Items.AddRange(Host.Container.HostGroups.Select(x => x.Key).ToArray());
			}
			txtGroup.Text = Host.GroupName;
		}

		private void OnBtnOKClick(object sender , EventArgs e)
		{
			if (txtServerName.Text.Trim().Length == 0)
			{
				MessageBox.Show("服务器名不可为空！");
				txtServerName.Focus();
				return;
			}
			if (txtServerAddress.Text.Trim().Length == 0)
			{
				MessageBox.Show("服务器地址不可为空！");
				txtServerAddress.Focus();
				return;
			}
			bool edited = false;
			if (Host.ServerName != txtServerName.Text)
			{
				Host.ServerName = txtServerName.Text;
				edited = true;
			}
			if (Host.GroupName != txtGroup.Text)
			{
				Host.GroupName = txtGroup.Text;
				edited = true;
			}
			if (String.IsNullOrEmpty(Host.GroupName))
				Host.GroupName = "默认";
			if (Host.ServerAddress != txtServerAddress.Text)
			{
				try
				{
					Host.ServerAddress = txtServerAddress.Text;
				}
				catch (InvalidHostRecordException ex)
				{
					MessageBoxEx.Exclamation(ex.Message);
					txtServerAddress.SelectAll();
					txtServerAddress.Focus();
					return;
				}
				edited = true;
			}
			if (Host.Comment != txtComment.Text
				&& !(String.IsNullOrEmpty(Host.Comment) && String.IsNullOrEmpty(txtComment.Text))
				)
			{
				Host.Comment = txtComment.Text;
				edited = true;
			}

			this.DialogResult = edited ? DialogResult.OK : DialogResult.Cancel;
		}

		private void OnBtnCancelClick(object sender , EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void txtServerAddress_DropDown(object sender , EventArgs e)
		{
			txtServerAddress.Items.AddRange(new string[] { "text1" , "text2" });
		}

		WaitHandle dnsHandle = null;
		private void OnDnsSolveRequest(object sender , EventArgs e)
		{
			btnSolve.Enabled = false;
			txtServerAddress.Text = String.Format("正在解析 “{0}” ..." , txtServerName.Text);
			txtServerAddress.Focus();
			if (dnsHandle != null)
				dnsHandle.Close();
			dnsHandle = Dns.BeginGetHostAddresses(txtServerName.Text , OnDnsResolveResponse , null).AsyncWaitHandle;
		}


		private void OnDnsResolveResponse(IAsyncResult result)
		{
			if (result.IsCompleted && !this.IsDisposed)
			{
				IPAddress[] address = null;
				try
				{
					address = Dns.EndGetHostAddresses(result);
				}
				catch (SocketException)
				{

				}
				finally
				{
					try
					{
						this.Invoke(new ReceiveDnsResultCallBack(ReceiveDnsResult) , new object[] { address });
					}
					catch (Exception) { }
				}
			}
		}

		private delegate void ReceiveDnsResultCallBack(IPAddress[] address);
		private void ReceiveDnsResult(IPAddress[] address)
		{
			if (address != null)
			{
				txtServerAddress.Text = "";
				txtServerAddress.Items.Clear();
				address.OrderBy(x => x.ToString().IndexOf(":"));
				txtServerAddress.Items.AddRange(address);

				if (txtServerAddress.Items.Count > 0)
					txtServerAddress.SelectedItem = address[0];
			}
			else
			{
				txtServerAddress.Text = "<未能解析该主机，可手动指定>";
			}

			txtServerAddress.Focus();
			btnSolve.Enabled = true;
		}

		private void FrmHostEditor_FormClosing(object sender , FormClosingEventArgs e)
		{
			if (dnsHandle != null)
				dnsHandle.Close();
		}

	}
}
