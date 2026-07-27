using System;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayChangeSubscriptionUseCase
	{
		event Action<DeferredPaymentUntilRenewalDateOrder>? OnDeferredPaymentUntilRenewalDate;

		void ChangeSubscription(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode);
	}
}
