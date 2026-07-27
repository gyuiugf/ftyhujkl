namespace UnityEngine.Purchasing
{
	internal class PurchaseServiceDependencyInjector
	{
		private IStoreWrapper m_storeWrapper;

		private IPurchaseServiceFactoryManager m_ServiceFactoryManager;

		internal PurchaseServiceDependencyInjector(IStoreWrapper storeWrapper)
		{
		}

		internal IPurchaseService CreatePurchaseService()
		{
			return null;
		}
	}
}
