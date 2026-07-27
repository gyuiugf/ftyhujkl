using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class ProductFetchFailureDescription : IRetryableRequestFailureDescription
	{
		public ProductFetchFailureReason reason;

		public string message;

		public bool isRetryable;

		public ProductFetchFailureReason Reason => default(ProductFetchFailureReason);

		public string Message => null;

		public bool IsRetryable => false;

		public ProductFetchFailureDescription(ProductFetchFailureReason reason, string message, bool isRetryable = false)
		{
		}
	}
}
