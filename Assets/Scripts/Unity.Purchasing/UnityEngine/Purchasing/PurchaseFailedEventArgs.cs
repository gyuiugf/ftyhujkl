using System;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class PurchaseFailedEventArgs
	{
		public Product purchasedProduct { get; private set; }

		public PurchaseFailureReason reason { get; private set; }

		public string message { get; private set; }

		internal PurchaseFailedEventArgs(Product purchasedProduct, PurchaseFailureReason reason, string message)
		{
		}
	}
}
