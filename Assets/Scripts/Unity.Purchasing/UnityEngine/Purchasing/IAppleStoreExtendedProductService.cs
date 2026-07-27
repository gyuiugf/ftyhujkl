using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public interface IAppleStoreExtendedProductService : IProductServiceExtension
	{
		void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback);

		void SetStorePromotionOrder(List<Product> products);

		void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback);

		void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible);

		Dictionary<string, string> GetIntroductoryPriceDictionary();

		Dictionary<string, string> GetProductDetails();
	}
}
