using System;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Services
{
	internal class AppleStoreExtendedService : StoreService, IAppleStoreExtendedService, IStoreServiceExtension
	{
		private readonly ICanMakePaymentsUseCase m_CanMakePaymentsUseCase;

		private readonly IClearAppleTransactionLogsUseCase m_ClearAppleTransactionLogsUseCase;

		private readonly ISetAppAccountTokenUseCase m_SetAppAccountTokenUseCase;

		public bool canMakePayments => false;

		[Preserve]
		internal AppleStoreExtendedService(ICanMakePaymentsUseCase canMakePaymentsUseCase, IClearAppleTransactionLogsUseCase clearAppleTransactionLogsUseCase, ISetAppAccountTokenUseCase setAppAccountTokenUseCase, IStoreConnectUseCase connectUseCase)
			: base(null)
		{
		}

		public void SetAppAccountToken(Guid appAccountToken)
		{
		}

		public void ClearTransactionLog()
		{
		}
	}
}
