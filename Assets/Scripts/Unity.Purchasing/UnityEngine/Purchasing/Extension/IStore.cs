using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	internal interface IStore
	{
		void Connect();

		void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		void FetchPurchases();

		void Purchase(ICart cart);

		void FinishTransaction(PendingOrder pendingOrder);

		void CheckEntitlement(ProductDefinition product);

		void SetProductsCallback(IStoreProductsCallback productsCallback);

		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback);

		void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

		void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

		void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback);

		void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback);

		void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback);
	}
}
