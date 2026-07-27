using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class InvalidCartException : IapException
	{
		public InvalidCartException()
		{
		}

		public InvalidCartException(string message)
		{
		}

		protected InvalidCartException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
