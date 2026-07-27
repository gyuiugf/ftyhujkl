namespace UnityEngine.Purchasing
{
	internal static class ProductServiceProvider
	{
		public static IProductService GetDefaultProductService()
		{
			return null;
		}

		public static IProductService GetProductService(string storeName)
		{
			return null;
		}

		private static IProductService GetProductServiceInternal(IStoreWrapper storeWrapper)
		{
			return null;
		}

		private static IProductService LocateExistingService(IStoreWrapper wrapper)
		{
			return null;
		}

		private static IProductService CreateNewService(IStoreWrapper wrapper)
		{
			return null;
		}
	}
}
