using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayPurchaseCallback : IGooglePurchaseCallback
	{
		private IProductCache? m_ProductCache;

		private IStorePurchaseCallback? m_PurchaseCallback;

		private IStorePurchaseFetchCallback? m_PurchaseFetchCallback;

		private IGooglePlayChangeSubscriptionCallback? m_ChangeSubscriptionCallback;

		private readonly IGooglePurchaseConverter m_GooglePurchaseConverter;

		private readonly IUtil m_Util;

		[Preserve]
		internal GooglePlayPurchaseCallback(IGooglePurchaseConverter googlePurchaseConverter, IUtil util)
		{
		}

		public void SetProductCache(IProductCache productCache)
		{
		}

		public void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
		}

		public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback)
		{
		}

		public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback)
		{
		}

		public void OnPurchaseSuccessful(IGooglePurchase purchase)
		{
		}

		private void OnOrderPurchaseSuccessful(Order order)
		{
		}

		public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription)
		{
		}

		public void NotifyDeferredPurchase(IGooglePurchase purchase)
		{
		}

		public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
		{
		}

		public void NotifyUpgradeDowngradeSubscription(string sku)
		{
		}
	}
}
