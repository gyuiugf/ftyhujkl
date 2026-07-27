namespace UnityEngine.Purchasing
{
	internal interface IStoreConnectionStateService
	{
		ConnectionState GetConnectionState();

		void SetConnectionState(ConnectionState connectionState);
	}
}
