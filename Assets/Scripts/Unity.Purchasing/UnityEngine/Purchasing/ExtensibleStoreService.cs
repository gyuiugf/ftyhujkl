using System;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public abstract class ExtensibleStoreService : IStoreService
	{
		private IStoreService m_BaseInternalStoreService;

		public virtual IAppleStoreExtendedService? Apple => null;

		public virtual IGooglePlayStoreExtendedService? Google => null;

		public event Action<StoreConnectionFailureDescription>? OnStoreDisconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		protected ExtensibleStoreService(IStoreService baseStoreService)
		{
		}

		public virtual Task Connect()
		{
			return null;
		}

		public virtual void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy? retryPolicy)
		{
		}
	}
}
