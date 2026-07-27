namespace UnityEngine.Purchasing
{
	internal static class ProductServiceDependencyFactoryInjector
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
		}
	}
}
