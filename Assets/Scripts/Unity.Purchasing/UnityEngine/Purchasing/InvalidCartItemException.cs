using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class InvalidCartItemException : IapException
	{
		public InvalidCartItemException()
		{
		}

		public InvalidCartItemException(string message)
		{
		}

		protected InvalidCartItemException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
