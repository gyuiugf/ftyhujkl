using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Services;

namespace UnityEngine.Purchasing
{
	internal class StoreServiceFactory : IStoreServiceFactory
	{
		private static StoreServiceFactory? s_Instance;

		private readonly Dictionary<string?, Func<IRetryPolicy, IStoreWrapper, IStoreService>> m_StoreServiceInstantiationByName;

		internal static StoreServiceFactory Instance()
		{
			return null;
		}

		private StoreServiceFactory()
		{
		}

		public void RegisterNewService(string name, Func<IStoreService> createFunction)
		{
		}

		public void RegisterNewExtendedService(string name, Func<IStoreService, ExtensibleStoreService> createFunction)
		{
		}

		public IStoreService Create(IStoreWrapper store, IRetryPolicy? retryPolicy)
		{
			return null;
		}

		private static StoreService CreateGenericStoreService(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper)
		{
			return null;
		}

		private static void AddStoreServiceDependencies(IDependencyInjectionService di, IRetryPolicy? retryPolicy, IStoreWrapper store)
		{
		}

		private static GooglePlayStoreExtendedService CreateGoogleStoreService(IRetryPolicy? retryPolicy, IStoreWrapper store)
		{
			return null;
		}

		private static AppleStoreExtendedService CreateAppleStoreService(IRetryPolicy? retryPolicy, IStoreWrapper store)
		{
			return null;
		}
	}
}
