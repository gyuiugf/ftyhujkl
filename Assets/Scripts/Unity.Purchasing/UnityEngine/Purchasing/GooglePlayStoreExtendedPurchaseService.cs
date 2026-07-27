using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Security;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreExtendedPurchaseService : PurchaseService, IGooglePlayStoreExtendedPurchaseService, IPurchaseServiceExtension
	{
		private readonly IGooglePlayChangeSubscriptionUseCase m_GooglePlayChangeSubscriptionUseCase;

		private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase;

		public event Action<DeferredPaymentUntilRenewalDateOrder>? OnDeferredPaymentUntilRenewalDate
		{
			add
			{
			}
			remove
			{
			}
		}

		[Preserve]
		internal GooglePlayStoreExtendedPurchaseService(IGooglePlayChangeSubscriptionUseCase googlePlayChangeSubscriptionUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient)
			: base(null, null, null, null, null, null)
		{
		}

		public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct)
		{
		}

		public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayProrationMode desiredProrationMode)
		{
		}

		public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayReplacementMode desiredReplacementMode)
		{
		}

		public void UpgradeDowngradeSubscription(Order order, Product newProduct, GooglePlayReplacementMode desiredReplacementMode)
		{
		}

		public bool IsOrderDeferred(Order order)
		{
			return false;
		}

		public string GetObfuscatedAccountId(Order order)
		{
			return null;
		}

		public string GetObfuscatedProfileId(Order order)
		{
			return null;
		}

		public GooglePurchaseState? GetPurchaseState(Order order)
		{
			return null;
		}

		protected override void RestoreTransactionsInternal(Action<bool, string?>? callback)
		{
		}
	}
}
