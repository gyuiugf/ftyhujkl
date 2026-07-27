using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class CheckEntitlementUseCase : ICheckEntitlementUseCase, IStoreCheckEntitlementCallback
	{
		private readonly IStore m_Store;

		private readonly List<CheckEntitlementRequest> m_OngoingRequests;

		[Preserve]
		internal CheckEntitlementUseCase(IStore storeResponsible)
		{
		}

		public void IsProductEntitled(Product product, Action<Entitlement> onResult)
		{
		}

		private bool FindExistingEntitlementRequest(Product productToCheckFor)
		{
			return false;
		}

		private void AddAndSendCheckEntitlementRequest(Product product, Action<Entitlement> onCheckComplete)
		{
		}

		public void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message = null)
		{
		}

		private CheckEntitlementRequest GetMatchingRequest(ProductDefinition productDefinition)
		{
			return null;
		}
	}
}
