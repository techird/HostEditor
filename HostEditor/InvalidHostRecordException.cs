using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HostEditor
{
	[Serializable]
	public class InvalidHostRecordException : Exception
	{
		public string HostLine
		{
			get;
			private set;
		}
		public int LineNumber = -1;
		public InvalidHostRecordException() { }
		public InvalidHostRecordException(string message) : base(message) { }
		public InvalidHostRecordException(string message , string hostLine , Exception inner)
			: base(message , inner)
		{
			HostLine = hostLine;
		}
		protected InvalidHostRecordException(
		  System.Runtime.Serialization.SerializationInfo info ,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info , context) { }
	}
}
