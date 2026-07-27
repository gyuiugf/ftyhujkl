namespace UnityEngine.Purchasing
{
	internal class ProductServiceDependencyInjector
	{
		private IStoreWrapper m_storeWrapper;

		private IProductServiceFactoryManager m_ServiceFactoryManager;

		internal ProductServiceDependencyInjector(IStoreWrapper storeWrapper)
		{
		}

		internal IProductService CreateProductService()
		{
			return null;
		}
	}
}
