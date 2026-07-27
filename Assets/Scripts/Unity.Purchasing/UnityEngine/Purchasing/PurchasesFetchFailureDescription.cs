using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class PurchasesFetchFailureDescription
	{
		public PurchasesFetchFailureReason failureReason;

		public string message;

		public PurchasesFetchFailureReason FailureReason => default(PurchasesFetchFailureReason);

		public string Message => null;

		public PurchasesFetchFailureDescription(PurchasesFetchFailureReason reason, string message)
		{
		}
	}
}
