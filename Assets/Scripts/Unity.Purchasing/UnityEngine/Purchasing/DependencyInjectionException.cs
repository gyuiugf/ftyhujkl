using System;
using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	internal class DependencyInjectionException : Exception
	{
		internal DependencyInjectionException()
		{
		}

		internal DependencyInjectionException(string message)
		{
		}

		protected DependencyInjectionException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
