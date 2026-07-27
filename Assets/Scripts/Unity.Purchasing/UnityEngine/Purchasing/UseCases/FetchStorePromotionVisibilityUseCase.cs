using System;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class FetchStorePromotionVisibilityUseCase : IFetchStorePromotionVisibilityUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal FetchStorePromotionVisibilityUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}

		public void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback)
		{
		}
	}
}
