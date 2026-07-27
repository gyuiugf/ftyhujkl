using System;

namespace UnityEngine.Purchasing
{
	internal interface IOnEntitlementRevokedUseCase
	{
		event Action<string> OnEntitlementRevoked;
	}
}
