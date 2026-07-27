namespace UnityEngine.Purchasing
{
	public interface IStoreConnectCallback
	{
		void OnStoreConnectionSucceeded();

		void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription);
	}
}
