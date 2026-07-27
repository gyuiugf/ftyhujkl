using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Models
{
	[Preserve]
	internal class GooglePurchaseStateEnumProvider : IGooglePurchaseStateEnumProvider
	{
		public int Purchased()
		{
			return 0;
		}

		public int Pending()
		{
			return 0;
		}
	}
}
