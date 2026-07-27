using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	public abstract class ExtensibleProductService : IProductService
	{
		private IProductService m_BaseInternalProductService;

		public virtual IAppleStoreExtendedProductService? Apple => null;

		public event Action<List<Product>>? OnProductsFetched
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ProductFetchFailed>? OnProductsFetchFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		protected ExtensibleProductService(IProductService baseProductService)
		{
		}

		public virtual void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions)
		{
		}

		public virtual void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy? retryPolicy = null)
		{
		}

		public virtual ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		public virtual Product GetProductById(string productId)
		{
			return null;
		}
	}
}
