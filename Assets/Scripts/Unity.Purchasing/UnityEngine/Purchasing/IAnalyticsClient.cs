namespace UnityEngine.Purchasing
{
	internal interface IAnalyticsClient
	{
		void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder);

		void OnPurchaseFailed(FailedOrder failedOrder);
	}
}
