using System.Runtime.Serialization;

namespace UnityEngine.Purchasing
{
	public class ServiceCreationException : IapException
	{
		internal ServiceCreationException()
		{
		}

		internal ServiceCreationException(string message)
		{
		}

		protected ServiceCreationException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
