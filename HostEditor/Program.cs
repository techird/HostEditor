using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security;
using Microsoft.Win32;
using System.Threading;
using System.Security.Principal;
using System.Diagnostics;

namespace HostEditor
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				AssosiateHostFile();
			}
			catch (Exception)
			{
			}
			Application.Run(new FrmMain());
			//RunAsAdministrator();
		}

		public static string GetCommandArgs()
		{
			string[] args = Environment.CommandLine.Split('\"');
			if (args.Length >= 3)
				return args[2].Trim();
			return "";
		}



		public static void RunAsAdministrator()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//UAC请求
			if (!Security.IsAdministrator)
			{
#if DEBUG
				MessageBox.Show("调试模式下请手动使用管理员身份运行！" , "Debug提示" , MessageBoxButtons.OK , MessageBoxIcon.Information);
#else
				//创建启动对象
				ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

				//设置运行文件
				startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;

				startInfo.Arguments = GetCommandArgs();

				//设置启动动作,确保以管理员身份运行
				startInfo.Verb = "runas";

				//以管理员身份运行
				try
				{
					Process.Start(startInfo);
				}
				catch (Exception)
				{
					//MessageBox.Show("请以管理员身份运行！" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information);
				}
#endif
			}
			else
			{
				AssosiateHostFile();
				Application.Run(new FrmMain());
				//Application.Run(new FrmImport());
			}
		}

		/// <summary>
		/// 关联Host文件
		/// </summary>
		public static void AssosiateHostFile()
		{
			FileTypeRegInfo fileReg = new FileTypeRegInfo(".host");
			fileReg.ExePath = Application.ExecutablePath;
			fileReg.IcoPath = Application.ExecutablePath + ", 1";
			fileReg.Description = "本地静态地址解析文件";
			FileTypeRegister.RegisterFileType(fileReg);
			/*
			string MyFileName = Application.ExecutablePath;
			string MyExtName = ".host";
			string MyType = "静态地址解析文件";
			string MyContent = "text/host";
			RegistryKey MyReg = Registry.ClassesRoot.CreateSubKey(MyExtName);
			MyReg.SetValue("" , MyType);
			MyReg.SetValue("Content Type" , MyContent);
			MyReg = MyReg.CreateSubKey("shell\\open\\command");
			MyReg.SetValue("" , MyFileName + " %1");
			MyReg.Close();
			 * */
		}
	}
}
