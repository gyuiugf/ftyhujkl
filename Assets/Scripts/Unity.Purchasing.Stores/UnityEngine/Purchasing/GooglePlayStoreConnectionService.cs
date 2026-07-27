using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreConnectionService : IGooglePlayStoreConnectionService
	{
		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IBillingClientStateListener m_BillingClientStateListener;

		private IStoreConnectCallback m_ConnectCallback;

		[Preserve]
		public GooglePlayStoreConnectionService(IGoogleBillingClient billingClient, IBillingClientStateListener billingClientStateListener)
		{
		}

		public void Connect()
		{
		}

		public bool IsReady()
		{
			return false;
		}

		public GoogleBillingConnectionState CheckConnectionState()
		{
			return default(GoogleBillingConnectionState);
		}

		public void SetConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
		}

		private void OnConnected()
		{
		}

		private void OnDisconnected(GoogleBillingResponseCode responseCode)
		{
		}
	}
}
