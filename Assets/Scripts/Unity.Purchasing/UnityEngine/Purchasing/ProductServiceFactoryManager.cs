namespace UnityEngine.Purchasing
{
	internal class ProductServiceFactoryManager : IProductServiceFactoryManager, IProductServiceFactoryManagerInjectionPoint
	{
		private static ProductServiceFactoryManager s_Instance;

		private IProductServiceFactory m_Factory;

		internal static ProductServiceFactoryManager Instance()
		{
			return null;
		}

		public void SetServiceFactory(IProductServiceFactory serviceFactory)
		{
		}

		public IProductServiceFactory GetServiceFactory()
		{
			return null;
		}
	}
}
