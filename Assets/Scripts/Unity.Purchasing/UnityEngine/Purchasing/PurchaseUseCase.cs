using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class PurchaseUseCase : IPurchaseUseCase, IStorePurchaseCallback
	{
		protected IStore m_Store { get; }

		public event Action<PendingOrder> OnPurchaseSuccess
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

		public event Action<FailedOrder> OnPurchaseFail
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

		public event Action<DeferredOrder> OnPurchaseDefer
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

		internal PurchaseUseCase(IStore storeResponsible)
		{
		}

		public void Purchase(ICart cart)
		{
		}

		public void OnPurchaseSucceeded(PendingOrder order)
		{
		}

		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		public void OnPurchaseDeferred(DeferredOrder deferredOrder)
		{
		}
	}
}
