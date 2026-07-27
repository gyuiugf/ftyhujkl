using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class AppleStoreImpl : JsonStore, IAppleStoreCallbacks, IAppleAppReceiptViewer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchProducts_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public AppleStoreImpl _003C_003E4__this;

			public IReadOnlyCollection<ProductDefinition> products;

			private TaskAwaiter<List<ProductDescription>> _003C_003Eu__1;

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
		private struct _003COnPurchaseSucceeded_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public AppleStoreImpl _003C_003E4__this;

			public string purchaseDetailsJson;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		private Action<bool>? m_ObsoleteRestoreCallback;

		private Action<bool, string?>? m_RestoreCallback;

		private Action<string>? m_FetchStorePromotionOrderError;

		private Action<List<Product>>? m_FetchStorePromotionOrderSuccess;

		private Action<string>? m_FetchStorePromotionVisibilityError;

		private Action<string, AppleStorePromotionVisibility>? m_FetchStorePromotionVisibilitySuccess;

		private Action<string>? m_RefreshAppReceiptSuccessCallback;

		private Action<string>? m_RefreshAppReceiptErrorCallback;

		private TaskCompletionSource<bool>? m_RefreshAppReceiptTask;

		private bool m_RefreshAppReceipt;

		private INativeAppleStore? m_Native;

		private readonly IAppleFetchProductsService m_FetchProductsService;

		private readonly ITransactionLog m_TransactionLog;

		private static IUtil? s_Util;

		private static AppleStoreImpl? s_Instance;

		private string? appReceipt;

		private bool m_IsTransactionObserverEnabled;

		private Guid m_AppAccountToken;

		public bool simulateAskToBuy { get; set; }

		public event Action<Product>? OnPromotionalPurchaseIntercepted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected AppleStoreImpl(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics)
			: base(null, null, null)
		{
		}

		public void SetNativeStore(INativeAppleStore apple)
		{
		}

		public INativeAppleStore? GetNativeStore()
		{
			return null;
		}

		public string? AppReceipt()
		{
			return null;
		}

		public override void Connect()
		{
		}

		protected override void FinishTransaction(ProductDefinition? productDefinition, string transactionId)
		{
		}

		public override void Purchase(ICart cart)
		{
		}

		private string PurchaseOptions()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFetchProducts_003Ed__29))]
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		public override void FetchPurchases()
		{
		}

		public void SetFetchStorePromotionOrderCallbacks(Action<List<Product>> successCallback, Action<string> errorCallback)
		{
		}

		public void SetFetchStorePromotionVisibilityCallbacks(Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback)
		{
		}

		public void SetRestoreTransactionsCallback(Action<bool, string?>? successCallback)
		{
		}

		public void ClearTransactionLog()
		{
		}

		public void SetAppAccountToken(Guid value)
		{
		}

		public override void OnPurchaseDeferred(string productDetails)
		{
		}

		private void OnPromotionalPurchaseAttempted(string payload)
		{
		}

		public override void OnPurchasesFetched(string json)
		{
		}

		private List<Order> CreateOrdersFromFetchedPurchases(Dictionary<string, Dictionary<string, object>> fetchedPurchases)
		{
			return null;
		}

		private List<Order> GenerateOrdersFromProducts(Dictionary<string, object> transactions, bool isPending)
		{
			return null;
		}

		private static OwnershipType OwnershipTypeFromString(string ownershipTypeString)
		{
			return default(OwnershipType);
		}

		private void OnTransactionsRestoredSuccess()
		{
		}

		private void OnTransactionsRestoredFail(string error)
		{
		}

		private void OnEntitlementRevoked(string purchaseDetailsJson)
		{
		}

		private void RevokeEntitlement(string productId)
		{
		}

		private void OnFetchStorePromotionOrderSucceeded(string productIds)
		{
		}

		private void OnFetchStorePromotionOrderFailed(string error)
		{
		}

		private void OnFetchStorePromotionVisibilitySucceeded(string result)
		{
		}

		private void OnFetchStorePromotionVisibilityFailed(string error)
		{
		}

		[MonoPInvokeCallback(typeof(UnityPurchasingCallback))]
		private static void MessageCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus)
		{
		}

		private void ProcessCallbackMessage(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus)
		{
		}

		private string ConvertPtrToString(IntPtr subjectPtr)
		{
			return null;
		}

		public void SetRefreshAppReceiptCallbacks(Action<string> successCallback, Action<string> errorCallback)
		{
		}

		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
		}

		private void OnAppReceiptRetrieved(string receipt)
		{
		}

		private void OnAppReceiptRefreshedFailed(string error)
		{
		}

		public override void CheckEntitlement(ProductDefinition productDefinition)
		{
		}

		private void OnCheckEntitlement(string productId, int entitlementStatus)
		{
		}

		[AsyncStateMachine(typeof(_003COnPurchaseSucceeded_003Ed__63))]
		private void OnPurchaseSucceeded(string purchaseDetailsJson)
		{
		}

		private Task<bool> RefreshAppReceiptAsync()
		{
			return null;
		}

		private void ProcessValidPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string signatureJws)
		{
		}

		private void ProcessNewPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string signatureJws)
		{
		}

		private void ProcessLoggedPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
		}

		private DeferredOrder GenerateAppleDeferredOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
			return null;
		}

		private PendingOrder GenerateApplePendingOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
			return null;
		}

		private ConfirmedOrder GenerateAppleConfirmedOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Guid? appAccountToken, string? signatureJws)
		{
			return null;
		}

		private void EnsureConfirmedOrderIsFinished(ConfirmedOrder confirmedOrder)
		{
		}

		private void InvokeErrorIfRepurchasedConsumables(ConfirmedOrder confirmedOrder)
		{
		}
	}
}
