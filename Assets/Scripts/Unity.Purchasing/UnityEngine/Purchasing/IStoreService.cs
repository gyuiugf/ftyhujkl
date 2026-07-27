using System;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public interface IStoreService
	{
		IAppleStoreExtendedService? Apple { get; }

		IGooglePlayStoreExtendedService? Google { get; }

		event Action<StoreConnectionFailureDescription>? OnStoreDisconnected;

		Task Connect();

		void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy? retryPolicy);
	}
}
