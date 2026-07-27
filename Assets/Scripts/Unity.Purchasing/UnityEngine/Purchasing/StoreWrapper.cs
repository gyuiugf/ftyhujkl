using Purchasing.Extension;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class StoreWrapper : IStoreWrapper
	{
		private InternalStore m_InternalStore;

		public string name { get; }

		public Store instance => null;

		public ConnectionState GetStoreConnectionState()
		{
			return default(ConnectionState);
		}

		public StoreWrapper(string name, InternalStore instance)
		{
		}
	}
}
