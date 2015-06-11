using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostEditor
{
	public static class MessageBoxEx
	{
		public static void Information(String information , String caption = "提示")
		{
			MessageBox.Show(information , caption , MessageBoxButtons.OK , MessageBoxIcon.Information , MessageBoxDefaultButton.Button1);
		}

		public static void Exclamation(String message , String caption = "警告")
		{
			MessageBox.Show(message , caption , MessageBoxButtons.OK , MessageBoxIcon.Exclamation , MessageBoxDefaultButton.Button1);
		}

		public static DialogResult Confirm(String question , string caption = "确认操作")
		{
			return MessageBox.Show(question , caption , MessageBoxButtons.YesNoCancel , MessageBoxIcon.Question , MessageBoxDefaultButton.Button3);			
		}
	}
}
