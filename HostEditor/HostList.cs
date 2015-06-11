using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace HostEditor
{
	public class HostList : List<Host>
	{
		/// <summary>
		/// 识别分组的头字符串
		/// </summary>
		private const string GROUP_HEAD = "#Group: ";
		private const string DEFAULT_GROUP = "默认";
		private const string SIGNATRUE =
@"#This host file is build by HostEditorV3 (Power by Techird)
#Last update: 2011/08/04";
		List<InvalidHostRecordException> exceptionList = new List<InvalidHostRecordException>();

		public List<InvalidHostRecordException> LoadExceptions
		{
			get
			{
				return exceptionList;
			}
		}

		/// <summary>
		/// HostList的说明
		/// </summary>
		public string HeadString { get; set; }

		/// <summary>
		/// 默认构造
		/// </summary>
		public HostList() { }

		/// <summary>
		/// 从一个Host文件构造
		/// </summary>
		/// <param name="HostFile">Host文件位置</param>
		public HostList(string HostFile)
		{

			//判断文件是否存在
			if (File.Exists(HostFile) == false)
			{
				throw new FileNotFoundException("找不到该Host文件" , HostFile);
			}

			//读取文件
			string[] hostLines = File.ReadAllLines(HostFile , Encoding.Default);

			string hostLine;
			string currentGroup = DEFAULT_GROUP;

			bool readingHead = true;

			int lineNumber = 0;
			foreach (string line in hostLines)
			{
				++lineNumber;
				// 读取一行
				hostLine = line.Trim();

				// 忽略空行
				if (hostLine.Length == 0)
					continue;

				// 读取分组说明
				if (hostLine.StartsWith(GROUP_HEAD))
				{
					currentGroup = hostLine.Substring(GROUP_HEAD.Length);
					continue;
				}

				Boolean disabled;
				// 被禁用的记录
				if (disabled = hostLine.StartsWith(Host.DISABLED_HEAD))
					hostLine = hostLine.Substring(Host.DISABLED_HEAD.Length);

				// 读取头内容
				if (hostLine[0] == '#')
				{
					if (readingHead)
						this.HeadString += hostLine + Environment.NewLine;
					continue;
				}
				readingHead = false;

				// 添加有效Host记录到列表中
				try
				{
					Host host = new Host(hostLine) { GroupName = currentGroup , Container = this , Enabled = !disabled };
					this.Add(host);
				}
				catch (Exception innerException)
				{
					exceptionList.Add(new InvalidHostRecordException("Host记录行无效" , hostLine , innerException) { LineNumber = lineNumber });
					continue;
				}
			}

		}

		/// <summary>
		/// 比较两个域名字符串用于排序
		/// </summary>
		private int DomainCompairer(Host host1 , Host host2)
		{
			if (host1.ServerName == host2.ServerName)
				return 0;
			var domain1 = host1.ServerName.Split('.').Reverse().ToList();
			var domain2 = host2.ServerName.Split('.').Reverse().ToList();
			if (domain1.Count != domain2.Count)
				return domain1.Count - domain2.Count;

			int i = 0;
			while (i < Math.Min(domain1.Count , domain2.Count) && domain1[i] == domain2[i])
				i++;
			if (i == domain1.Count)
				return -1;
			if (i == domain2.Count)
				return 1;
			return domain1[i].CompareTo(domain2[i]);
		}

		/// <summary>
		/// 获得Host列表存在的分组
		/// </summary>
		public IEnumerable<IGrouping<string , Host>> HostGroups
		{
			get
			{
				return from host in this
					   group host by host.GroupName into hostGroup
					   select hostGroup;
			}
		}

		private void OnChange()
		{

		}

		/// <summary>
		/// 返回HostList生成的Host文件字符串
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string fileString = this.HeadString + Environment.NewLine;

			foreach (var hostGroup in this.HostGroups)
			{
				string groupName = String.IsNullOrEmpty(hostGroup.Key) ? DEFAULT_GROUP : hostGroup.Key;
				fileString += GROUP_HEAD + groupName + Environment.NewLine;
				foreach (var host in hostGroup)
				{
					fileString += host.ToString() + Environment.NewLine;
				}
				fileString += Environment.NewLine;
			}
			return fileString + SIGNATRUE;
		}

		/// <summary>
		/// 将HostList保存到文件
		/// </summary>
		/// <param name="hostFile">保存位置</param>
		public void SaveToFile(string hostFile)
		{
			try
			{
				File.WriteAllText(hostFile , this.ToString() , Encoding.Default);
			}
			catch (IOException)
			{
				throw;
			}
		}
	}
}
