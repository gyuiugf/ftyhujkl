using System;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface ISetPromotionalPurchaseInterceptorCallbackUseCase
	{
		event Action<Product> OnPromotionalPurchaseIntercepted;
	}
}
