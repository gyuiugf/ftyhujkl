using System;

namespace UnityEngine.Purchasing
{
	public static class UnityIAPServices
	{
		public static IStoreService DefaultStore()
		{
			return null;
		}

		public static IStoreService Store(string storeName)
		{
			return null;
		}

		public static IPurchaseService DefaultPurchase()
		{
			return null;
		}

		public static IPurchaseService Purchase(string storeName)
		{
			return null;
		}

		public static IProductService DefaultProduct()
		{
			return null;
		}

		public static IProductService Product(string storeName)
		{
			return null;
		}

		public static StoreController StoreController(string? storeName = null)
		{
			return null;
		}

		public static void SetStoreAsDefault(string storeName)
		{
		}

		public static void AddNewCustomStore(IStoreWrapper customStoreWrapper)
		{
		}

		public static void AddNewStoreService(string storeName, Func<IStoreService> createStoreService)
		{
		}

		public static void AddNewExtendedStoreService(string storeName, Func<IStoreService, ExtensibleStoreService> createStoreService)
		{
		}

		public static void AddNewProductService(string storeName, Func<IProductService> createProductService)
		{
		}

		public static void AddNewExtendedProductService(string storeName, Func<IProductService, ExtensibleProductService> createProductService)
		{
		}

		public static void AddNewPurchaseService(string storeName, Func<IPurchaseService> createPurchaseService)
		{
		}

		public static void AddNewExtendedPurchaseService(string storeName, Func<IPurchaseService, ExtensiblePurchaseService> createPurchaseService)
		{
		}
	}
}
