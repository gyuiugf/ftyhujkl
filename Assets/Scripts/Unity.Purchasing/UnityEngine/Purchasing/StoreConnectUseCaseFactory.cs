namespace UnityEngine.Purchasing
{
	internal class StoreConnectUseCaseFactory
	{
		public IStoreConnectUseCase CreateUseCase(IStoreWrapper storeWrapper, IRetryService retryService)
		{
			return null;
		}

		private static IRetryPolicy CreateRetryPolicy(string storeName)
		{
			return null;
		}
	}
}
