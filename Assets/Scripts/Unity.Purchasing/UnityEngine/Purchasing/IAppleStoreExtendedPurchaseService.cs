using System;

namespace UnityEngine.Purchasing
{
	public interface IAppleStoreExtendedPurchaseService : IPurchaseServiceExtension
	{
		bool simulateAskToBuy { get; set; }

		[Obsolete]
		string? appReceipt { get; }

		event Action<string>? OnEntitlementRevoked;

		event Action<Product>? OnPromotionalPurchaseIntercepted;

		void PresentCodeRedemptionSheet();

		void ContinuePromotionalPurchases();

		[Obsolete]
		void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback);

		[Obsolete]
		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
}
