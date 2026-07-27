namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayChangeSubscriptionCallback : IStorePurchaseCallback
	{
		void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId);

		void OnSubscriptionChange(string storeSpecificId);
	}
}
