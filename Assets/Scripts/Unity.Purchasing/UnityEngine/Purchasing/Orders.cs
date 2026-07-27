using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class Orders
	{
		public IReadOnlyList<ConfirmedOrder> ConfirmedOrders { get; }

		public IReadOnlyList<PendingOrder> PendingOrders { get; }

		public IReadOnlyList<DeferredOrder> DeferredOrders { get; }

		public Orders(IReadOnlyList<ConfirmedOrder> confirmedOrders, IReadOnlyList<PendingOrder> pendingOrders, IReadOnlyList<DeferredOrder> deferredOrders)
		{
		}
	}
}
