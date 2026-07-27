namespace UnityEngine.Purchasing
{
	internal static class PurchaseServiceDependencyFactoryInjector
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
}
