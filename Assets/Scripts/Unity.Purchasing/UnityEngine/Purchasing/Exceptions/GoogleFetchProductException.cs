using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Exceptions
{
	internal class GoogleFetchProductException : FetchProductsException
	{
		private GoogleFetchProductsFailureReason FailureReason { get; }

		private GoogleBillingResponseCode ResponseCode { get; }

		public GoogleFetchProductException(GoogleFetchProductsFailureReason failureReason, GoogleBillingResponseCode responseCode, ProductFetchFailureDescription failureDescription)
			: base(null)
		{
		}
	}
}
