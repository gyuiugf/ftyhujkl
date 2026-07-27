using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	public class CatalogProvider : ICatalogProvider, IBaseCatalogProvider
	{
		private Dictionary<string?, Dictionary<string, string>> m_StoreSpecificIds;

		private List<ProductDefinition> m_Products;

		public List<ProductDefinition> GetProducts(string? storeName = null)
		{
			return null;
		}

		public void AddProduct(string id, ProductType type)
		{
		}

		public void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs)
		{
		}

		public void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs, PayoutDefinition payout)
		{
		}

		public void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs, IEnumerable<PayoutDefinition>? payouts)
		{
		}

		private string AddStoreSpecificIds(string id, StoreSpecificIds? storeIDs)
		{
			return null;
		}

		public void AddProducts(IEnumerable<ProductDefinition> productsDefinitions, Dictionary<string, StoreSpecificIds>? storeIDsByProductId)
		{
		}

		public void FetchProducts(Action<List<ProductDefinition>> callback)
		{
		}

		public void FetchProducts(Action<List<ProductDefinition>> callback, string storeName)
		{
		}

		private void UpdateStoreSpecificIDs(string storeName)
		{
		}
	}
}
