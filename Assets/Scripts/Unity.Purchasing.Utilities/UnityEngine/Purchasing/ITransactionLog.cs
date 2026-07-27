namespace UnityEngine.Purchasing
{
	internal interface ITransactionLog
	{
		void Clear();

		bool HasRecordOf(string transactionID);

		void Record(string transactionID);
	}
}
