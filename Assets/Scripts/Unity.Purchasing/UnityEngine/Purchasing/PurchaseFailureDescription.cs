using System;

namespace UnityEngine.Purchasing
{
	public class PurchaseFailureDescription
	{
		public CartItem item { get; private set; }

		[Obsolete("Use item.Product instead")]
		public Product product => null;

		public PurchaseFailureReason reason { get; private set; }

		public string message { get; private set; }

		public PurchaseFailureDescription(CartItem item, PurchaseFailureReason reason, string message)
		{
		}

		internal FailedOrder ConvertToFailedOrder(string? transactionId = "")
		{
			return null;
		}
	}
}
