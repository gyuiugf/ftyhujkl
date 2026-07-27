using System;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class SetAppAccountTokenUseCase : ISetAppAccountTokenUseCase
	{
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		[Preserve]
		internal SetAppAccountTokenUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
		}

		public void SetAppAccountToken(Guid token)
		{
		}
	}
}
