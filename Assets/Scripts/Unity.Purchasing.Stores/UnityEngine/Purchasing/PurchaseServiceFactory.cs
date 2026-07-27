using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Services;

namespace UnityEngine.Purchasing
{
	internal class PurchaseServiceFactory : IPurchaseServiceFactory
	{
		private static PurchaseServiceFactory? s_Instance;

		private readonly Dictionary<string?, Func<IStoreWrapper, IPurchaseService>> m_PurchaseServiceInstantiationByName;

		internal static PurchaseServiceFactory Instance()
		{
			return null;
		}

		private PurchaseServiceFactory()
		{
		}

		public void RegisterNewService(string name, Func<IPurchaseService> createFunction)
		{
		}

		public void RegisterNewExtendedService(string name, Func<IPurchaseService, ExtensiblePurchaseService> createFunction)
		{
		}

		public IPurchaseService Create(IStoreWrapper store)
		{
			return null;
		}

		private static PurchaseService CreateDefaultPurchaseService(IStoreWrapper store)
		{
			return null;
		}

		private static void AddPurchaseServiceDependencies(IStoreWrapper store, IDependencyInjectionService di)
		{
		}

		private static void AddAnalyticsDependencies(IDependencyInjectionService di)
		{
		}

		private static GooglePlayStoreExtendedPurchaseService CreateGooglePurchaseService(IStoreWrapper store)
		{
			return null;
		}

		private static AppleStoreExtendedPurchaseService CreateApplePurchaseService(IStoreWrapper store)
		{
			return null;
		}
	}
}
