using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class StoreConnectionFailureDescription : IRetryableRequestFailureDescription
	{
		public string message;

		public bool isRetryable;

		public string Message => null;

		public bool IsRetryable => false;

		public StoreConnectionFailureDescription(string message, bool isRetryable = false)
		{
		}
	}
}
