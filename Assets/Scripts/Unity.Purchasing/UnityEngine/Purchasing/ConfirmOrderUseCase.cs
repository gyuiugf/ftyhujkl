using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class ConfirmOrderUseCase : IConfirmOrderUseCase, IStorePurchaseConfirmCallback
	{
		private readonly IStore m_Store;

		private readonly List<ConfirmOrderRequest> m_ConfirmationRequests;

		[Preserve]
		internal ConfirmOrderUseCase(IStore storeResponsible)
		{
		}

		public void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> confirmationAction)
		{
		}

		private bool FindExistingConfirmationRequest(PendingOrder orderToCheckFor)
		{
			return false;
		}

		private void AddAndSendFinishTransactionRequest(PendingOrder order, Action<PendingOrder, Order> confirmationAction)
		{
		}

		public void OnConfirmOrderSucceeded(string transactionId)
		{
		}

		public void OnConfirmOrderFailed(FailedOrder failedOrder)
		{
		}

		private ConfirmOrderRequest GetMatchingRequest(string transactionIdentifier)
		{
			return null;
		}
	}
}
