using System;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	internal class StoreService : IStoreService
	{
		private readonly IStoreConnectUseCase m_StoreConnectUseCase;

		public IAppleStoreExtendedService? Apple => null;

		public IGooglePlayStoreExtendedService? Google => null;

		public event Action<StoreConnectionFailureDescription>? OnStoreDisconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		internal StoreService(IStoreConnectUseCase connectUseCase)
		{
		}

		public Task Connect()
		{
			return null;
		}

		public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy? retryPolicy)
		{
		}
	}
}
