namespace UnityEngine.Purchasing
{
	internal class StoreConnectionStateService : IStoreConnectionStateService
	{
		private ConnectionState? m_StoreConnectionState;

		public ConnectionState GetConnectionState()
		{
			return default(ConnectionState);
		}

		public void SetConnectionState(ConnectionState connectionState)
		{
		}
	}
}
