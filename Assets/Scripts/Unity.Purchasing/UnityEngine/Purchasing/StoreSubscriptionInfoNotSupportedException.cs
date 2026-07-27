using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException
	{
		public StoreSubscriptionInfoNotSupportedException(string message)
		{
		}
	}
}
