using Uniject;

namespace UnityEngine.Purchasing
{
	internal class ScriptingUnityCallback : IUnityCallback
	{
		private readonly IUnityCallback forwardTo;

		private readonly IUtil util;

		public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util)
		{
		}

		public void OnProductsFetched(string json)
		{
		}

		public void OnProductsFetchFailed(string jsonFailureDescription)
		{
		}

		public void OnPurchasesRetrievalFailed(string jsonFailureDescription)
		{
		}

		public void OnPurchasesFetched(string json)
		{
		}

		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		public void OnPurchaseFailed(string json)
		{
		}

		public void OnPurchaseDeferred(string json)
		{
		}

		public void OnStoreConnectionSucceeded()
		{
		}

		public void OnStoreConnectionFailed(string jsonFailureDescription)
		{
		}
	}
}
