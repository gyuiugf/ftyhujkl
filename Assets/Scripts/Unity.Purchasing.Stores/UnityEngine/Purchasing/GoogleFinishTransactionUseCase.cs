using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GoogleFinishTransactionUseCase : IGoogleFinishTransactionUseCase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFinishTransaction_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public GoogleFinishTransactionUseCase _003C_003E4__this;

			public string purchaseToken;

			public ProductDefinition product;

			public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished;

			private TaskAwaiter<IGooglePurchase?> _003C_003Eu__1;

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

		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		[Preserve]
		internal GoogleFinishTransactionUseCase(IGoogleBillingClient billingClient, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
		}

		[AsyncStateMachine(typeof(_003CFinishTransaction_003Ed__3))]
		public Task FinishTransaction(ProductDefinition? product, string? purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
			return null;
		}

		private void FinishTransactionForPurchase(IGooglePurchase purchase, ProductDefinition? product, string? purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
		}
	}
}
