using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class ProductService : IProductService
	{
		private static readonly IRetryPolicy k_DefaultRetryPolicy;

		private readonly IFetchProductsUseCase m_FetchProductsUseCase;

		private readonly IStoreWrapper m_StoreWrapper;

		private readonly IProductCache m_ProductCache;

		public IAppleStoreExtendedProductService? Apple => null;

		public event Action<List<Product>>? OnProductsFetched
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<ProductFetchFailed>? OnProductsFetchFailed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal ProductService(IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper)
		{
		}

		public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
		}

		public void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy? retryPolicy)
		{
		}

		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		public Product GetProductById(string productId)
		{
			return null;
		}

		private void HandleProductsFetched(List<Product>? fetchedProducts)
		{
		}

		private void HandleProductsFetchFailed(List<ProductDefinition>? fetchedProducts, string reason)
		{
		}

		private void CheckStoreConnectionState()
		{
		}
	}
}
