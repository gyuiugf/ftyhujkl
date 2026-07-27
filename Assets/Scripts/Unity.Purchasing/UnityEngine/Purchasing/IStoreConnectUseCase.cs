using System;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	internal interface IStoreConnectUseCase
	{
		event Action<StoreConnectionFailureDescription>? OnStoreDisconnection;

		Task Connect();

		void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy);
	}
}
