using System;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IRestoreTransactionsUseCase
	{
		void RestoreTransactions(Action<bool, string?>? callback);
	}
}
