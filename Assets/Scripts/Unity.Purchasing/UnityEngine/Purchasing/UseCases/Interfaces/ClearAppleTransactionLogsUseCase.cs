using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal class ClearAppleTransactionLogsUseCase : IClearAppleTransactionLogsUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Preserve]
		internal ClearAppleTransactionLogsUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}

		public void ClearTransactionLog()
		{
		}
	}
}
