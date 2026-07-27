using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public abstract class IapException : Exception
	{
		internal IapException()
		{
		}

		internal IapException(string message)
		{
		}

		protected IapException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
