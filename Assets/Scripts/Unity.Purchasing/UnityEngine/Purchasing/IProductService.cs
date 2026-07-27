using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	public interface IProductService
	{
		IAppleStoreExtendedProductService? Apple { get; }

		event Action<List<Product>>? OnProductsFetched;

		event Action<ProductFetchFailed>? OnProductsFetchFailed;

		void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions);

		void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy? retryPolicy = null);

		ReadOnlyObservableCollection<Product> GetProducts();

		Product GetProductById(string productId);
	}
}
