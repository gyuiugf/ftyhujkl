using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Purchasing
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class UnityPurchasing
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectToStoreAndFetchProducts_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		internal static ConfigurationBuilder m_ConfigurationBuilder;

		internal static IStoreListener m_StoreListener;

		internal static bool shouldFetchProductsAtInit;

		private static bool isInitialized;

		internal static PurchasingManager m_PurchasingManager;

		public static void Initialize(IStoreListener storeListener, ConfigurationBuilder configurationBuilder)
		{
		}

		private static void FetchProducts(IStoreListener storeListener, ConfigurationBuilder configurationBuilder)
		{
		}

		private static void AddProductServiceListeners(IStoreListener storeListener, IProductService productService)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectToStoreAndFetchProducts_003Ed__8))]
		private static void ConnectToStoreAndFetchProducts()
		{
		}
	}
}
