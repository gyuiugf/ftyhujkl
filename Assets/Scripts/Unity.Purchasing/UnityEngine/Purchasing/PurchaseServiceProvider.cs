namespace UnityEngine.Purchasing
{
	internal static class PurchaseServiceProvider
	{
		public static IPurchaseService GetDefaultPurchaseService()
		{
			return null;
		}

		public static IPurchaseService GetPurchaseService(string storeName)
		{
			return null;
		}

		private static IPurchaseService GetPurchaseServiceInternal(IStoreWrapper storeWrapper)
		{
			return null;
		}

		private static IPurchaseService LocateExistingService(IStoreWrapper wrapper)
		{
			return null;
		}

		private static IPurchaseService CreateNewService(IStoreWrapper wrapper)
		{
			return null;
		}
	}
}
