using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GoogleQueryPurchasesUseCase : IGoogleQueryPurchasesUseCase
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public string purchaseToken;

			internal bool _003CGetPurchaseByToken_003Eb__0(IGooglePurchase purchase)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPurchaseByToken_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IGooglePurchase> _003C_003Et__builder;

			public string purchaseToken;

			public GoogleQueryPurchasesUseCase _003C_003E4__this;

			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CQueryPurchases_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<IGooglePurchase>> _003C_003Et__builder;

			public GoogleQueryPurchasesUseCase _003C_003E4__this;

			private TaskAwaiter<IEnumerable<IGooglePurchase>[]> _003C_003Eu__1;

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

		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;

		[Preserve]
		internal GoogleQueryPurchasesUseCase(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder)
		{
		}

		[AsyncStateMachine(typeof(_003CQueryPurchases_003Ed__3))]
		public Task<List<IGooglePurchase>> QueryPurchases()
		{
			return null;
		}

		private Task<IEnumerable<IGooglePurchase>> QueryPurchasesWithSkuType(string skuType)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPurchaseByToken_003Ed__5))]
		public Task<IGooglePurchase?>? GetPurchaseByToken(string? purchaseToken)
		{
			return null;
		}

		private static bool IsResultOk(IGoogleBillingResult result)
		{
			return false;
		}
	}
}
