using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;

namespace HostEditor
{
	#region Related to privileges

	public static class Security
	{
		[DllImport("user32")]
		public static extern UInt32 SendMessage(IntPtr hWnd , UInt32 msg , UInt32 wParam , UInt32 lParam);

		internal const int BCM_FIRST = 0x1600;
		internal const int BCM_SETSHIELD = (BCM_FIRST + 0x000C);

		public static void AddShieldToControl(Control b)
		{
			if (b.GetType() == typeof(Button))
				(b as Button).FlatStyle = FlatStyle.System;
			SendMessage(b.Handle , BCM_SETSHIELD , 0 , 0xFFFFFFFF);
		}

		private static bool isAdmin
			= new WindowsPrincipal(WindowsIdentity.GetCurrent())
			.IsInRole(WindowsBuiltInRole.Administrator);

		public static bool IsAdministrator
		{
			get
			{ //获得当前登录的Windows用户标示
				return isAdmin;
			}
		}

		public static void RestartElevated()
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.UseShellExecute = true;
			startInfo.WorkingDirectory = Environment.CurrentDirectory;
			startInfo.FileName = Application.ExecutablePath;
			startInfo.Verb = "runas";
			try
			{
				Process p = Process.Start(startInfo);
			}
			catch (System.ComponentModel.Win32Exception ex)
			{
				return; // 假如取消操作，那么就什么也不干
			}
			Application.Exit();
		}
	}



	#endregion

}
