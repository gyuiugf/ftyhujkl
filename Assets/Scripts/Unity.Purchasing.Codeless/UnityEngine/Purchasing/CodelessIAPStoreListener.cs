using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	public class CodelessIAPStoreListener
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectToStore_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CodelessIAPStoreListener _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateCodelessIAPStoreListenerInstance_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeCodelessPurchasingOnLoad_003Ed__14 : IAsyncStateMachine
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializePurchasing_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CodelessIAPStoreListener _003C_003E4__this;

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

		private static CodelessIAPStoreListener? s_Instance;

		private readonly List<CodelessIAPButton> m_ActiveCodelessButtons;

		private readonly List<IAPListener> m_ActiveListeners;

		private bool m_UnityPurchasingInitialized;

		private IStoreService? m_StoreService;

		private IProductService? m_ProductService;

		private IPurchaseService? m_PurchasingService;

		private readonly ProductCatalog m_Catalog;

		private CatalogProvider? m_CatalogProvider;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		protected IStoreController controller;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		protected IExtensionProvider extensions;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		private ConfigurationBuilder m_Builder;

		private bool m_InitializationComplete;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public static bool initializationComplete;

		public static CodelessIAPStoreListener Instance => null;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public IStoreController StoreController => null;

		[AsyncStateMachine(typeof(_003CInitializeCodelessPurchasingOnLoad_003Ed__14))]
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeCodelessPurchasingOnLoad()
		{
		}

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public T GetStoreConfiguration<T>() where T : notnull
		{
			return default(T);
		}

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public T GetStoreExtensions<T>() where T : notnull
		{
			return default(T);
		}

		[AsyncStateMachine(typeof(_003CCreateCodelessIAPStoreListenerInstance_003Ed__19))]
		private static Task CreateCodelessIAPStoreListenerInstance()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitializePurchasing_003Ed__20))]
		private Task InitializePurchasing()
		{
			return null;
		}

		private void InitCatalog()
		{
		}

		private void CreateServices()
		{
		}

		private void ConfigureServiceCallbacks()
		{
		}

		private void ConfigureProductServiceCallbacks()
		{
		}

		private void ChangeProductServiceCallbacks()
		{
		}

		private void ConfigurePurchasingServiceCallbacks()
		{
		}

		private void OnInitialProductsFetched(List<Product> products)
		{
		}

		private void HandleOnInitForAllButtons()
		{
		}

		private void FetchExistingPurchases()
		{
		}

		private void InvokeOnProductsFetched(List<Product> products)
		{
		}

		private void InvokeListenersOnProductsFetched(List<Product> products)
		{
		}

		private void InvokeButtonsOnProductsFetched(List<Product> products)
		{
		}

		private void OnInitialProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		private void InvokeListenersOnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		private void InvokeButtonsOnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		private void OnAdditionalProductsFetched(List<Product> products)
		{
		}

		private void OnAdditionalProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
		}

		private void OnPurchasesFetched(Orders existingOrders)
		{
		}

		private void InvokeListenersOnPurchasesFetched(Orders existingOrders)
		{
		}

		private void InvokeButtonsOnPurchasesFetched(Orders existingOrders)
		{
		}

		private void OnPurchasesFetchFailure(PurchasesFetchFailureDescription failure)
		{
		}

		private void OnOrderPending(PendingOrder order)
		{
		}

		private void InvokeOnOrderPending(PendingOrder pendingOrder)
		{
		}

		private void InvokeListenersOnOrderPending(PendingOrder pendingOrder)
		{
		}

		private void InvokeButtonsOnOrderPending(PendingOrder pendingOrder)
		{
		}

		private void ConfirmOrderIfAutomatic(PendingOrder order)
		{
		}

		private bool ShouldConfirmOrderAutomatically(PendingOrder order)
		{
			return false;
		}

		private CodelessIAPButton FindMatchingButtonByProduct(string productId)
		{
			return null;
		}

		private void ConfirmOrder(PendingOrder pendingOrder)
		{
		}

		private void OnPurchaseConfirmed(Order order)
		{
		}

		private void OnOrderConfirmed(ConfirmedOrder order)
		{
		}

		private void InvokeListenersOnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
		}

		private void InvokeButtonsOnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
		}

		private void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		private void InvokeListenersOnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		private void InvokeButtonsOnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		private void OnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		private void InvokeListenersOnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		private void InvokeButtonsOnOrderDeferred(DeferredOrder deferredOrder)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectToStore_003Ed__60))]
		private Task ConnectToStore()
		{
			return null;
		}

		private void FetchInitialProducts()
		{
		}

		private Task AutoInitializeUnityGamingServicesIfEnabled()
		{
			return null;
		}

		private static bool ShouldAutoInitUgs()
		{
			return false;
		}

		public bool HasProductInCatalog(string productID)
		{
			return false;
		}

		public Product? GetProduct(string? productID)
		{
			return null;
		}

		public void AddButton(CodelessIAPButton button)
		{
		}

		public void RemoveButton(CodelessIAPButton button)
		{
		}

		public void AddListener(IAPListener listener)
		{
		}

		public void RemoveListener(IAPListener listener)
		{
		}

		public void InitiatePurchase(string? productID)
		{
		}

		private void SendPurchaseFailedEventsToAllButtons(Product? product)
		{
		}

		public ProductCatalog GetProductCatalog()
		{
			return null;
		}

		public bool IsInitialized()
		{
			return false;
		}
	}
}
