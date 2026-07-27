using System;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class SetPromotionalPurchaseInterceptorCallbackUseCase : ISetPromotionalPurchaseInterceptorCallbackUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		public event Action<Product>? OnPromotionalPurchaseIntercepted
		{
			add
			{
			}
			remove
			{
			}
		}

		[Preserve]
		internal SetPromotionalPurchaseInterceptorCallbackUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}
	}
}
