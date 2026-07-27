namespace UnityEngine.Purchasing
{
	internal class TransactionLog : ITransactionLog
	{
		private readonly string? m_PersistentDataPath;

		public TransactionLog(string persistentDataPath)
		{
		}

		public void Clear()
		{
		}

		public bool HasRecordOf(string transactionID)
		{
			return false;
		}

		public void Record(string transactionID)
		{
		}

		private static string GetRecordPath(string dataPath, string transactionID)
		{
			return null;
		}

		private static string ComputeHash(string transactionID)
		{
			return null;
		}
	}
}
