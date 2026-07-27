namespace UnityEngine.Purchasing
{
	internal static class StoreServiceProvider
	{
		public static IStoreService GetDefaultStoreService()
		{
			return null;
		}

		public static IStoreService GetStoreService(string storeName)
		{
			return null;
		}

		private static IStoreService GetStoreServiceInternal(IStoreWrapper storeWrapper)
		{
			return null;
		}

		private static IStoreService LocateExistingService(IStoreWrapper wrapper)
		{
			return null;
		}

		private static IStoreService CreateNewService(IStoreWrapper wrapper)
		{
			return null;
		}
	}
}
