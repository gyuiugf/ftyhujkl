using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayCheckEntitlementUseCase : IGooglePlayCheckEntitlementUseCase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckEntitlement_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ProductDefinition product;

			public GooglePlayCheckEntitlementUseCase _003C_003E4__this;

			public Action<ProductDefinition, EntitlementStatus> onEntitlementChecked;

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

		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		[Preserve]
		internal GooglePlayCheckEntitlementUseCase(IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
		}

		[AsyncStateMachine(typeof(_003CCheckEntitlement_003Ed__2))]
		public void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked)
		{
		}

		private static Func<IGooglePurchase, bool> PurchaseToCheckForEntitlement(ProductDefinition product)
		{
			return null;
		}

		private static EntitlementStatus DetermineEntitlementStatus(IGooglePurchase purchase, ProductType type)
		{
			return default(EntitlementStatus);
		}
	}
}
