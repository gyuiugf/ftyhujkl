using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class PurchaseServiceContainer
	{
		private static PurchaseServiceContainer? s_Instance;

		private readonly Dictionary<string?, IPurchaseService> m_InstantiatedServices;

		internal static PurchaseServiceContainer Instance()
		{
			return null;
		}

		internal IPurchaseService FindService(string storeName)
		{
			return null;
		}

		internal void SetService(string storeName, IPurchaseService service)
		{
		}
	}
}
