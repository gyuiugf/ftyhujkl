using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	[Preserve]
	internal class EmptyAnalyticsAdapter : IAnalyticsAdapter
	{
		public void SendTransactionEvent(CartItem item, string receipt)
		{
		}

		public void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription)
		{
		}
	}
}
