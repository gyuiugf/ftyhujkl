using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Services
{
	internal class AppleStoreExtendedProductService : ProductService, IAppleStoreExtendedProductService, IProductServiceExtension
	{
		private readonly IFetchStorePromotionOrderUseCase m_FetchStorePromotionOrderUseCase;

		private readonly IFetchStorePromotionVisibilityUseCase m_FetchStorePromotionVisibilityUseCase;

		private readonly IGetIntroductoryPriceDictionaryUseCase m_GetIntroductoryPriceDictionaryUseCase;

		private readonly IGetProductDetailsUseCase m_GetProductDetailsUseCase;

		private readonly ISetStorePromotionOrderUseCase m_SetStorePromotionOrderUseCase;

		private readonly ISetStorePromotionVisibilityUseCase m_SetStorePromotionVisibilityUseCase;

		[Preserve]
		internal AppleStoreExtendedProductService(IFetchStorePromotionOrderUseCase fetchStorePromotionOrderUseCase, IFetchStorePromotionVisibilityUseCase fetchStorePromotionVisibilityUseCase, IGetIntroductoryPriceDictionaryUseCase getIntroductoryPriceDictionaryUseCase, IGetProductDetailsUseCase getProductDetailsUseCase, ISetStorePromotionOrderUseCase setStorePromotionOrderUseCase, ISetStorePromotionVisibilityUseCase setStorePromotionVisibilityUseCase, IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper)
			: base(null, null)
		{
		}

		public void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback)
		{
		}

		public void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback)
		{
		}

		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return null;
		}

		public Dictionary<string, string> GetProductDetails()
		{
			return null;
		}

		public void SetStorePromotionOrder(List<Product> products)
		{
		}

		public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible)
		{
		}
	}
}
