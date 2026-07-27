using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Purchasing.Extension
{
	internal abstract class InternalStore : Store, IInternalStore, IStore
	{
		internal IStoreConnectionStateService StoreConnectionStateService;

		public ConnectionState GetStoreConnectionState()
		{
			return default(ConnectionState);
		}

		public void SetStoreConnectionState(ConnectionState connectionState)
		{
		}
	}
}
