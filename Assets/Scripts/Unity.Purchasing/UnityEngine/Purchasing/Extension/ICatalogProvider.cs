using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	public interface ICatalogProvider : IBaseCatalogProvider
	{
		List<ProductDefinition> GetProducts(string? storeName = null);

		void AddProduct(string id, ProductType type);

		void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs);

		void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs, PayoutDefinition payout);

		void AddProduct(string id, ProductType type, StoreSpecificIds? storeIDs, IEnumerable<PayoutDefinition> payouts);

		void AddProducts(IEnumerable<ProductDefinition> products, Dictionary<string, StoreSpecificIds>? storeIDsByProductId = null);

		void FetchProducts(Action<List<ProductDefinition>> callback, string storeName);
	}
}
