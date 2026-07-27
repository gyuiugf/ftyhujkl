using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreService : IGooglePlayStoreService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchProducts_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePlayStoreService _003C_003E4__this;

			public IReadOnlyCollection<ProductDefinition> products;

			public Action<List<ProductDescription>> onProductsReceived;

			public Action<GoogleFetchProductException> onFetchProductsFailed;

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
		private struct _003CFetchPurchases_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePlayStoreService _003C_003E4__this;

			public Action<List<IGooglePurchase>> onQueryPurchaseSucceed;

			public Action<string?> onQueryPurchaseFailed;

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
		private struct _003CFinishTransaction_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public GooglePlayStoreService _003C_003E4__this;

			public ProductDefinition product;

			public string purchaseToken;

			public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished;

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
		private struct _003CTryFetchPurchases_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public GooglePlayStoreService _003C_003E4__this;

			public Action<List<IGooglePurchase>> onQueryPurchaseSucceed;

			private TaskAwaiter<List<IGooglePurchase>> _003C_003Eu__1;

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

		private readonly IQueryProductDetailsService m_QueryProductDetailsService;

		private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService;

		private readonly IGooglePurchaseService m_GooglePurchaseService;

		private readonly IGoogleFinishTransactionUseCase m_GoogleFinishTransactionUseCase;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		private readonly IGooglePlayCheckEntitlementUseCase m_GoogleCheckEntitlementUseCase;

		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGooglePlayStoreConnectionService m_GooglePlayStoreConnectionService;

		internal GooglePlayStoreService(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		[AsyncStateMachine(typeof(_003CFetchProducts_003Ed__10))]
		public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed)
		{
		}

		public void Purchase(ProductDefinition product)
		{
		}

		public virtual void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		[AsyncStateMachine(typeof(_003CFinishTransaction_003Ed__13))]
		public Task FinishTransaction(ProductDefinition? product, string? purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFetchPurchases_003Ed__14))]
		public void FetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed, Action<string?> onQueryPurchaseFailed)
		{
		}

		[AsyncStateMachine(typeof(_003CTryFetchPurchases_003Ed__15))]
		private Task TryFetchPurchases(Action<List<IGooglePurchase>> onQueryPurchaseSucceed)
		{
			return null;
		}

		public void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked)
		{
		}

		public void SetObfuscatedAccountId(string obfuscatedAccountId)
		{
		}

		public void SetObfuscatedProfileId(string obfuscatedProfileId)
		{
		}

		public virtual bool IsConnectionReady()
		{
			return false;
		}
	}
}
