using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchaseCallback
	{
		void SetProductCache(IProductCache productCache);

		void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

		void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

		void OnPurchaseSuccessful(IGooglePurchase purchase);

		void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription);

		void NotifyDeferredPurchase(IGooglePurchase purchase);

		void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

		void NotifyUpgradeDowngradeSubscription(string sku);
	}
}
