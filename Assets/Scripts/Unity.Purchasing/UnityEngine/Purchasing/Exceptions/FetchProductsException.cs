namespace UnityEngine.Purchasing.Exceptions
{
	internal class FetchProductsException : IapException
	{
		internal ProductFetchFailureDescription FailureDescription { get; }

		public FetchProductsException(ProductFetchFailureDescription failureDescription)
		{
		}
	}
}
