using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal interface IAppleStoreCallbacks
	{
		bool simulateAskToBuy { get; set; }

		event Action<Product>? OnPromotionalPurchaseIntercepted;

		void SetFetchStorePromotionOrderCallbacks(Action<List<Product>> successCallback, Action<string> errorCallback);

		void SetFetchStorePromotionVisibilityCallbacks(Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback);

		void SetRestoreTransactionsCallback(Action<bool, string?>? successCallback);

		void ClearTransactionLog();

		void SetAppAccountToken(Guid token);

		void SetRefreshAppReceiptCallbacks(Action<string> successCallback, Action<string> errorCallback);

		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
}
