using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	public abstract class Store : IStore
	{
		protected IStoreProductsCallback? ProductsCallback;

		protected IStorePurchaseFetchCallback? PurchaseFetchCallback;

		protected IStorePurchaseCallback? PurchaseCallback;

		protected IStorePurchaseConfirmCallback? ConfirmCallback;

		protected IStoreCheckEntitlementCallback? EntitlementCallback;

		protected IStoreConnectCallback? ConnectCallback;

		protected IOnEntitlementRevokedCallback? EntitlementRevokedCallback;

		internal IProductCache ProductCache;

		public abstract void Connect();

		public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		public abstract void FetchPurchases();

		public abstract void Purchase(ICart cart);

		public abstract void FinishTransaction(PendingOrder pendingOrder);

		public abstract void CheckEntitlement(ProductDefinition product);

		public virtual void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback)
		{
		}

		public virtual void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
		}

		public virtual void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
		}

		public virtual void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
		}

		public virtual void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
		}

		public virtual void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
		}

		public virtual void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback)
		{
		}
	}
}
