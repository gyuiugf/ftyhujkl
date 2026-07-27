using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ReceiptParserException : IapException
	{
		public ReceiptParserException()
		{
		}

		public ReceiptParserException(string message)
		{
		}

		protected ReceiptParserException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
