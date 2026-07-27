namespace UnityEngine.Purchasing
{
	internal class StoreServiceDependencyInjector
	{
		private readonly IRetryPolicy? m_RetryPolicy;

		private readonly IStoreWrapper m_Store;

		private IStoreServiceFactoryManager m_ServiceFactoryManager;

		internal StoreServiceDependencyInjector(IStoreWrapper storeWrapper, IRetryPolicy? retryPolicy)
		{
		}

		internal IStoreService CreateStoreService()
		{
			return null;
		}
	}
}
