using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class StoreServiceContainer
	{
		private static StoreServiceContainer? s_Instance;

		private readonly Dictionary<string?, IStoreService> m_InstantiatedServices;

		internal static StoreServiceContainer Instance()
		{
			return null;
		}

		internal IStoreService FindService(string storeName)
		{
			return null;
		}

		internal void SetService(string storeName, IStoreService service)
		{
		}
	}
}
