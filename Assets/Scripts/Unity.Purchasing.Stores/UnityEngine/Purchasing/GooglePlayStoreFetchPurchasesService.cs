using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreFetchPurchasesService : IGooglePlayStoreFetchPurchasesService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private readonly IGooglePurchaseConverter m_PurchaseConverter;

		private IProductCache? m_ProductCache;

		private IStorePurchaseFetchCallback? m_FetchCallback;

		private IUtil m_Util;

		[Preserve]
		internal GooglePlayStoreFetchPurchasesService(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseConverter purchaseConverter, IUtil util)
		{
		}

		public void SetProductCache(IProductCache productCache)
		{
		}

		public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback)
		{
		}

		public void FetchPurchases()
		{
		}

		public void FetchPurchases(Action<List<Product>> onQueryPurchaseSucceed)
		{
		}

		public IGooglePurchase GetGooglePurchase(string purchaseToken)
		{
			return null;
		}

		private List<Product> FillProductsWithPurchases(IEnumerable<IGooglePurchase> purchases)
		{
			return null;
		}

		private IEnumerable<Product> BuildProductsFromPurchase(IGooglePurchase purchase)
		{
			return null;
		}

		private static Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase)
		{
			return null;
		}

		private void OnPurchasesFetched(List<IGooglePurchase>? purchases)
		{
		}

		private void PurchaseRetrievalFailedForUnknownReasons(string? message = null)
		{
		}

		private static Func<IGooglePurchase, bool> PurchaseIsPurchased()
		{
			return null;
		}

		private static Func<IGooglePurchase, bool> PurchaseIsPending()
		{
			return null;
		}

		private void UpdateDeferredProductsByPurchases(List<IGooglePurchase> deferredPurchases)
		{
		}

		private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase)
		{
		}

		private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku)
		{
		}
	}
}
