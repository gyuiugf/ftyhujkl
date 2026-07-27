using System;

namespace UnityEngine.Purchasing
{
	internal interface IPurchaseUseCase
	{
		event Action<PendingOrder> OnPurchaseSuccess;

		event Action<FailedOrder> OnPurchaseFail;

		event Action<DeferredOrder> OnPurchaseDefer;

		void Purchase(ICart cart);
	}
}
