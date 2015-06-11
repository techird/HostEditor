using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;

namespace HostEditor
{
	public class Host
	{
		private static readonly string sys_path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
		public static string SYSTEM_HOST_PATH
		{
			get
			{
				return sys_path;
			}
		}

		public static int NextID = 0;
		public const string DISABLED_HEAD = "#Off";

		#region Properties

		/// <summary>
		/// 标识
		/// </summary>
		public int ID
		{
			get;
			private set;
		}

		/// <summary>
		/// 服务器名称
		/// </summary>
		public string ServerName
		{
			set;
			get;
		}

		private string serverAddress;
		/// <summary>
		/// 服务器地址
		/// </summary>
		public string ServerAddress
		{
			set
			{
				IPAddress address;
				if (IPAddress.TryParse(value , out address) == false)
				{
					throw new InvalidHostRecordException("IP地址不合法，请输入正确的IP地址");
				}
				serverAddress = value;
			}
			get
			{
				return serverAddress;
			}
		}

		/// <summary>
		/// 所在分组
		/// </summary>
		public string GroupName { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Comment
		{
			set;
			get;
		}

		/// <summary>
		/// 是否启用
		/// </summary>
		public bool Enabled
		{
			get;
			set;
		}

		/// <summary>
		/// 包含该Host的集合
		/// </summary>
		public HostList Container
		{
			get;
			set;
		}

		#endregion

		/// <summary>
		/// 默认构造
		/// </summary>
		public Host()
		{
			ID = NextID++;
			Enabled = true;
		}

		/// <summary>
		/// 根据Host里的一条字符串记录构造
		/// </summary>
		/// <param name="hostLine"></param>
		public Host(string hostLine)
			: this()
		{
			string[] tmp;
			tmp = hostLine.Split('#');

			if (tmp.Length > 1)
				this.Comment = tmp[1];

			tmp = tmp[0]
				.Trim()
				.Split(new char[] { ' ' , '\t' } , StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			if (tmp.Length == 2)
			{
				this.ServerAddress = tmp[0];
				this.ServerName = tmp[1];
			}
			else
			{
				throw new InvalidHostRecordException("找不到完整的服务器地址和域名的信息" , hostLine , null);
			}
		}

		/// <summary>
		/// 返回Host对象的字符串形式
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string addressField = this.ServerAddress;
			if (!this.Enabled)
				addressField = DISABLED_HEAD + " " + addressField;

			int span = 6 - addressField.Length / 8;

			string spilt = "";
			while (span-- > 0)
				spilt += "\t";
			if (spilt.Length == 0)
				spilt = " ";

			addressField += spilt;

			if (String.IsNullOrEmpty(this.Comment))
				return string.Format("{0}{1}" , addressField , this.ServerName);
			else
				return string.Format("{0}{1} #{2}" , addressField , this.ServerName , this.Comment);
		}
	}
}
