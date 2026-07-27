using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class NullReceiptException : ReceiptParserException
	{
		public NullReceiptException()
		{
		}

		public NullReceiptException(string message)
		{
		}

		protected NullReceiptException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
