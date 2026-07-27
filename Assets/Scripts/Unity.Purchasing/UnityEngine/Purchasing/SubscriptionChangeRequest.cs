using System;

namespace UnityEngine.Purchasing
{
	internal class SubscriptionChangeRequest
	{
		private readonly Action<DeferredPaymentUntilRenewalDateOrder> m_OnPurchaseDeferredUntilRenewalDate;

		internal Order CurrentOrder { get; }

		internal Product NewSubscription { get; }

		internal GooglePlayReplacementMode ReplacementMode { get; }

		internal SubscriptionChangeRequest(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode)
		{
		}
	}
}
