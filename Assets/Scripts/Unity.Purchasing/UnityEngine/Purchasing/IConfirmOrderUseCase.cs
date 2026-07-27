using System;

namespace UnityEngine.Purchasing
{
	internal interface IConfirmOrderUseCase
	{
		void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> action);
	}
}
