using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayRestoreTransactionUseCase : IRestoreTransactionsUseCase
	{
		private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase;

		[Preserve]
		public GooglePlayRestoreTransactionUseCase(IFetchPurchasesUseCase fetchPurchasesUseCase)
		{
		}

		public void RestoreTransactions(Action<bool, string?>? callback)
		{
		}
	}
}
