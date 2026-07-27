namespace UnityEngine.Purchasing
{
	internal class JavaBridge : AndroidJavaProxy, IUnityCallback
	{
		private readonly IUnityCallback forwardTo;

		public JavaBridge(IUnityCallback forwardTo)
			: base((string)null)
		{
		}

		public JavaBridge(IUnityCallback forwardTo, string javaInterface)
			: base((string)null)
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
