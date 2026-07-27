namespace UnityEngine.Purchasing
{
	internal class StoreServiceFactoryManager : IStoreServiceFactoryManager, IStoreServiceFactoryManagerInjectionPoint
	{
		private static StoreServiceFactoryManager s_Instance;

		private IStoreServiceFactory m_Factory;

		internal static StoreServiceFactoryManager Instance()
		{
			return null;
		}

		public void SetServiceFactory(IStoreServiceFactory serviceFactory)
		{
		}

		public IStoreServiceFactory GetServiceFactory()
		{
			return null;
		}
	}
}
