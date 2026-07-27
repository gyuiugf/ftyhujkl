using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class InvalidProductTypeException : ReceiptParserException
	{
		public InvalidProductTypeException()
		{
		}

		public InvalidProductTypeException(string message)
		{
		}

		protected InvalidProductTypeException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
