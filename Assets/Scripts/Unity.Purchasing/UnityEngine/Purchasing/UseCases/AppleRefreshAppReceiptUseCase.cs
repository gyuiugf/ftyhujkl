using System;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class AppleRefreshAppReceiptUseCase : IRefreshAppReceiptUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal AppleRefreshAppReceiptUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}

		public void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback)
		{
		}

		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
		}
	}
}
