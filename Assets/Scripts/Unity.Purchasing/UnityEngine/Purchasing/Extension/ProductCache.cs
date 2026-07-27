using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing.Extension
{
	internal class ProductCache : IProductCache
	{
		private ObservableCollection<Product> m_Products;

		private readonly ReadOnlyObservableCollection<Product> m_ProductsReadOnly;

		public Dictionary<string, Product> productsById { get; }

		private Dictionary<string, Product> productsByStoreSpecificId { get; }

		private Dictionary<string, string> storeSpecificProductIds { get; }

		internal ProductCache()
		{
		}

		public void Add(List<Product> products)
		{
		}

		public void Add(Product product)
		{
		}

		public ReadOnlyObservableCollection<Product> GetProducts()
		{
			return null;
		}

		public void Remove(Product product)
		{
		}

		public Product FindOrDefault(string? productId)
		{
			return null;
		}

		public Product? Find(string? productId)
		{
			return null;
		}

		private bool HasId(string? productId)
		{
			return false;
		}

		private bool HasStoreSpecificId(string? productId)
		{
			return false;
		}
	}
}
