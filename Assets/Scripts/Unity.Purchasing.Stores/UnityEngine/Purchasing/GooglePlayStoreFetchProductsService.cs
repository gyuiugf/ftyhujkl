using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreFetchProductsService : IGooglePlayStoreFetchProductsService
	{
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private IStoreProductsCallback? m_ProductsCallback;

		[Preserve]
		internal GooglePlayStoreFetchProductsService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		private void OnProductsFetched(List<ProductDescription> retrievedProducts)
		{
		}

		private void OnFetchProductsFailed(GoogleFetchProductException exception)
		{
		}

		[Obsolete]
		private static List<ProductDescription> MakePurchasesIntoProducts(List<ProductDescription> retrievedProducts, IEnumerable<Product> purchaseProducts)
		{
			return null;
		}

		public void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
		}
	}
}
