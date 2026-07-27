namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreChangeSubscriptionService
	{
		void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode);
	}
}
