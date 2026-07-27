using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class NullProductIdException : ReceiptParserException
	{
		public NullProductIdException()
		{
		}

		public NullProductIdException(string message)
		{
		}

		protected NullProductIdException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
