using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class StoreFactory : IStoreFactory
	{
		private static StoreFactory? s_Instance;

		private readonly IUtil m_Util;

		private readonly ILogger m_Logger;

		private readonly INativeStoreProvider m_NativeStoreProvider;

		public readonly ITelemetryMetricsInstanceWrapper TelemetryMetricsInstanceWrapper;

		public readonly ITelemetryDiagnosticsInstanceWrapper TelemetryDiagnosticsInstanceWrapper;

		private readonly Dictionary<string?, Func<IStoreWrapper>> m_StoreInstantiationByName;

		internal StoreFactory(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
		}

		internal static StoreFactory Instance()
		{
			return null;
		}

		private void RegisterBaseStores()
		{
		}

		public void RegisterStore(string storeName, Func<IStoreWrapper> function)
		{
		}

		public IStoreWrapper CreateStore(string storeName)
		{
			return null;
		}

		private IDependencyInjectionService CreateBaseDiService()
		{
			return null;
		}

		private void AddUtilsDependencies(IDependencyInjectionService di)
		{
		}

		private void AddTelemetryDependencies(IDependencyInjectionService di)
		{
		}

		private IStoreWrapper InstantiateAppleStore()
		{
			return null;
		}

		private IStoreWrapper InstantiateMacAppStore()
		{
			return null;
		}

		private IStoreWrapper InstantiateAppleAppStore(string storeName, string storeDisplayName)
		{
			return null;
		}

		private void AddMetricizedAppleStoreDependencies(IDependencyInjectionService di)
		{
		}

		private static ITransactionLog BuildTransactionLog()
		{
			return null;
		}

		private void CreateAndAssignNativeAppleStore(AppleStoreImpl store)
		{
		}

		private IStoreWrapper InstantiateFakeStore()
		{
			return null;
		}

		private FakeStore CreateFakeStoreByUIMode(FakeStoreUIMode useFakeStoreUIMode)
		{
			return null;
		}

		private IStoreWrapper InstantiateGooglePlayStore()
		{
			return null;
		}

		private static IStoreWrapper CreateStoreWrapper(string storeName, IDependencyInjectionService di)
		{
			return null;
		}

		private void LinkGooglePlayStoreDependencies(IDependencyInjectionService di)
		{
		}

		private static void LinkProductCache(IDependencyInjectionService di)
		{
		}

		private static void AddGooglePlayStoreServices(IDependencyInjectionService di)
		{
		}

		private void AddGooglePlayStoreServiceAars(IDependencyInjectionService di)
		{
		}
	}
}
