namespace UnityEngine.Purchasing
{
	public interface INativeStore
	{
		void Connect();

		void FetchProducts(string json);

		void FetchExistingPurchases();

		void Purchase(string productJson, string optionsJson);

		void FinishTransaction(string productJSON, string transactionID);

		bool CheckEntitlement(string productJSON);
	}
}
