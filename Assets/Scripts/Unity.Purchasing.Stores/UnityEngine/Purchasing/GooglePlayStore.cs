using System.Collections.Generic;
using Purchasing.Extension;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStore : InternalStore, IGooglePlayStore, IStore
	{
		private readonly IGooglePlayStoreConnectionService m_ConnectionService;

		private readonly IGooglePlayStoreFetchProductsService m_FetchProductsService;

		private readonly IGooglePlayStorePurchaseService m_StorePurchaseService;

		private readonly IGooglePlayStoreFetchPurchasesService m_PlayStoreFetchPurchasesService;

		private readonly IGooglePlayStoreCheckEntitlementService m_CheckEntitlementsService;

		private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService;

		private readonly IGooglePlayStoreChangeSubscriptionService m_ChangeSubscriptionService;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private readonly ICartValidator m_CartValidator;

		internal IGoogleBillingClient m_BillingClient;

		[Preserve]
		internal GooglePlayStore(IGooglePlayStoreFetchProductsService fetchProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGooglePlayStoreFetchPurchasesService playStoreFetchPurchasesService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePlayStoreChangeSubscriptionService changeSubscriptionService, IGooglePlayStoreCheckEntitlementService checkEntitlementsService, IGooglePurchaseCallback googlePurchaseCallback, ICartValidator cartValidator, IGooglePlayStoreConnectionService connectionService, IGoogleBillingClient billingClient)
		{
		}

		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		public override void FetchPurchases()
		{
		}

		private void FetchPurchasesInternal()
		{
		}

		public override void Purchase(ICart cart)
		{
		}

		public void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		public override void FinishTransaction(PendingOrder pendingOrder)
		{
		}

		public override void Connect()
		{
		}

		public override void CheckEntitlement(ProductDefinition product)
		{
		}

		public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback)
		{
		}

		public override void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
		}

		public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback)
		{
		}

		public override void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
		}

		public override void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
		}

		public override void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
		}

		public override void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
		}

		public void OnPause(bool isPaused)
		{
		}

		public IGooglePurchase GetGooglePurchase(string purchaseToken)
		{
			return null;
		}
	}
}
