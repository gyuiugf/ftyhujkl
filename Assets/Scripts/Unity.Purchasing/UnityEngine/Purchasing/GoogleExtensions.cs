using System;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	internal class GoogleExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		public void RestoreTransactions(Action<bool, string> callback)
		{
		}

		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		public void UpgradeDowngradeSubscription(string oldSku, string newSku)
		{
		}

		public void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode)
		{
		}

		public void UpgradeDowngradeSubscription(string oldSku, string newSku, GooglePlayProrationMode desiredProrationMode)
		{
		}

		public bool IsPurchasedProductDeferred(Product product)
		{
			return false;
		}

		public GooglePurchaseState GetPurchaseState(Product product)
		{
			return default(GooglePurchaseState);
		}

		public string GetObfuscatedAccountId(Product product)
		{
			return null;
		}

		public string GetObfuscatedProfileId(Product product)
		{
			return null;
		}
	}
}
