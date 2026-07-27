using System;

namespace UnityEngine.Purchasing
{
	public interface IAppleStoreExtendedService : IStoreServiceExtension
	{
		bool canMakePayments { get; }

		void SetAppAccountToken(Guid appAccountToken);

		void ClearTransactionLog();
	}
}
