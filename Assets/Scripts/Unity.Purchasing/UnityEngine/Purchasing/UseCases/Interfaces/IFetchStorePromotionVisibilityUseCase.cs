using System;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface IFetchStorePromotionVisibilityUseCase
	{
		void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback);
	}
}
