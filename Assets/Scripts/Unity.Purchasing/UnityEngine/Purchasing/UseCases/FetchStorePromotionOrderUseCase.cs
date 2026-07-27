using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class FetchStorePromotionOrderUseCase : IFetchStorePromotionOrderUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal FetchStorePromotionOrderUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}

		public void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback)
		{
		}
	}
}
