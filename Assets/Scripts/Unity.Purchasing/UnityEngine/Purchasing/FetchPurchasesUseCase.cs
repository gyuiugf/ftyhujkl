using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class FetchPurchasesUseCase : IFetchPurchasesUseCase, IStorePurchaseFetchCallback
	{
		private readonly IStore m_Store;

		private event Action<Orders> FetchSuccessAction
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

		private event Action<PurchasesFetchFailureDescription> FetchFailureAction
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

		[Preserve]
		internal FetchPurchasesUseCase(IStore storeResponsible)
		{
		}

		public void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction)
		{
		}

		public void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders)
		{
		}

		public void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason)
		{
		}
	}
}
