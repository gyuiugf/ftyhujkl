namespace UnityEngine.Purchasing
{
	public interface IStorePurchaseConfirmCallback
	{
		void OnConfirmOrderSucceeded(string transactionId);

		void OnConfirmOrderFailed(FailedOrder failedOrder);
	}
}
