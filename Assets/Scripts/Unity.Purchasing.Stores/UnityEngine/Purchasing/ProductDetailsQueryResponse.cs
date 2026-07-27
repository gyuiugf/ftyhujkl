using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	internal class ProductDetailsQueryResponse : IProductDetailsQueryResponse
	{
		private readonly ConcurrentBag<(IGoogleBillingResult, IEnumerable<AndroidJavaObject>)> m_Responses;

		~ProductDetailsQueryResponse()
		{
		}

		public void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails)
		{
		}

		public List<AndroidJavaObject> ProductDetails()
		{
			return null;
		}

		public bool IsRecoverable()
		{
			return false;
		}

		public GoogleBillingResponseCode GetRecoverableBillingResponseCode()
		{
			return default(GoogleBillingResponseCode);
		}

		private static bool IsRecoverable(IGoogleBillingResult billingResult)
		{
			return false;
		}

		private static bool IsServiceUnavailable(IGoogleBillingResult billingResult)
		{
			return false;
		}

		private static bool IsDeveloperError(IGoogleBillingResult billingResult)
		{
			return false;
		}
	}
}
