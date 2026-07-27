namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreConnectionService
	{
		void Connect();

		bool IsReady();

		GoogleBillingConnectionState CheckConnectionState();

		void SetConnectionCallback(IStoreConnectCallback storeConnectCallback);
	}
}
