using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class AppleConfiguration : IAppleConfiguration, IStoreConfiguration
	{
		public string appReceipt => null;

		public bool canMakePayments => false;

		public void SetApplePromotionalPurchaseInterceptorCallback(Action<Product> callback)
		{
		}

		public void SetEntitlementsRevokedListener(Action<List<Product>> callback)
		{
		}
	}
}
