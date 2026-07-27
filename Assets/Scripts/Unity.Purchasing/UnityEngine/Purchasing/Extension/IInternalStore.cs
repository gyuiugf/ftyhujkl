namespace UnityEngine.Purchasing.Extension
{
	internal interface IInternalStore : IStore
	{
		ConnectionState GetStoreConnectionState();

		void SetStoreConnectionState(ConnectionState connectionState);
	}
}
