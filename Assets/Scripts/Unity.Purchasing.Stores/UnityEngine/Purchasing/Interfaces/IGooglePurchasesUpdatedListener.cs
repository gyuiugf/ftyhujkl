using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface IGooglePurchasesUpdatedListener
	{
		event Action<IGoogleBillingResult, List<IGooglePurchase>> OnPurchaseUpdated;
	}
}
