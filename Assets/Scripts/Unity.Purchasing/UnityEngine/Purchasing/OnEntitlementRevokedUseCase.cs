using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class OnEntitlementRevokedUseCase : IOnEntitlementRevokedUseCase, IOnEntitlementRevokedCallback
	{
		public event Action<string> OnEntitlementRevoked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Preserve]
		internal OnEntitlementRevokedUseCase(IStore storeResponsible)
		{
		}

		public void onEntitlementRevoked(string productId)
		{
		}
	}
}
