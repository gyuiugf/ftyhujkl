using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class AppleRestoreTransactionsUseCase : IRestoreTransactionsUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		private readonly INativeAppleStore m_NativeAppleStore;

		[Preserve]
		internal AppleRestoreTransactionsUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
		}

		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}
	}
}
