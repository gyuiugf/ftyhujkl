using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class StoreManager : IStoreManager, IStoreManagerFactoryInjectionPoint
	{
		private static StoreManager? s_Instance;

		private IStoreFactory? m_StoreFactory;

		private readonly Dictionary<string?, IStoreWrapper> m_InstantiatedStores;

		public void SetStoreFactory(IStoreFactory? storeFactory)
		{
		}

		public static StoreManager Instance()
		{
			return null;
		}

		public IStoreWrapper GetStore(string name)
		{
			return null;
		}

		public IStoreWrapper GetDefaultStore()
		{
			return null;
		}

		public void AddNewCustomStore(IStoreWrapper customStore)
		{
		}
	}
}
