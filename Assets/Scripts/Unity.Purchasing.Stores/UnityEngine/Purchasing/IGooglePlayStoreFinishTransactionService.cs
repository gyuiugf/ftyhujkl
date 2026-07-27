using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStoreFinishTransactionService
	{
		void SetProductCache(IProductCache productCache);

		void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

		void FinishTransaction(ProductDefinition product, string purchaseToken);
	}
}
