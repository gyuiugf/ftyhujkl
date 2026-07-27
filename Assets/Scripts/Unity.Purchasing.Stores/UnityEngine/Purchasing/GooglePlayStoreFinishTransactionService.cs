using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreFinishTransactionService : IGooglePlayStoreFinishTransactionService
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public GooglePlayStoreFinishTransactionService _003C_003E4__this;

			public ProductDefinition product;

			internal void _003CFinishTransaction_003Eb__0(IGoogleBillingResult billingResult, IGooglePurchase googlePurchase)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFinishTransaction_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePlayStoreFinishTransactionService _003C_003E4__this;

			public ProductDefinition product;

			public string purchaseToken;

			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

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

		private readonly HashSet<string?> m_ProcessedPurchaseToken;

		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		private IProductCache? m_ProductCache;

		private IStorePurchaseConfirmCallback? m_ConfirmCallback;

		private int m_RetryCount;

		private const int k_MaxRetryAttempts = 5;

		[Preserve]
		internal GooglePlayStoreFinishTransactionService(IGooglePlayStoreService googlePlayStoreService)
		{
		}

		public void SetProductCache(IProductCache? productCache)
		{
		}

		public void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
		}

		[AsyncStateMachine(typeof(_003CFinishTransaction_003Ed__9))]
		public void FinishTransaction(ProductDefinition? product, string purchaseToken)
		{
		}

		private void HandleFinishTransaction(ProductDefinition? product, IGoogleBillingResult billingResult, IGooglePurchase purchase)
		{
		}

		private void SendTransactionFailedCallback(PurchaseFailureDescription purchaseFailureDescription, string? purchaseToken)
		{
		}

		private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase)
		{
		}

		private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult)
		{
			return false;
		}
	}
}
