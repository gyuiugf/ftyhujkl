namespace UnityEngine.Purchasing
{
	internal class PurchaseServiceFactoryManager : IPurchaseServiceFactoryManager, IPurchaseServiceFactoryManagerInjectionPoint
	{
		private static PurchaseServiceFactoryManager s_Instance;

		private IPurchaseServiceFactory m_Factory;

		internal static PurchaseServiceFactoryManager Instance()
		{
			return null;
		}

		public void SetServiceFactory(IPurchaseServiceFactory serviceFactory)
		{
		}

		public IPurchaseServiceFactory GetServiceFactory()
		{
			return null;
		}
	}
}
