namespace UnityEngine.Purchasing
{
	internal static class StoreServiceDependencyFactoryInjector
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
}
