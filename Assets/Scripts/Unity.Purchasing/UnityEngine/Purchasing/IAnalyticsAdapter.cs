namespace UnityEngine.Purchasing
{
	internal interface IAnalyticsAdapter
	{
		void SendTransactionEvent(CartItem item, string receipt);

		void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription);
	}
}
