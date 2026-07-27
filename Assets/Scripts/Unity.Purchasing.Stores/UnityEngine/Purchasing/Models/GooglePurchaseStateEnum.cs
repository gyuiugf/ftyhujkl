namespace UnityEngine.Purchasing.Models
{
	internal static class GooglePurchaseStateEnum
	{
		private const string k_AndroidPurchaseStateClassName = "com.android.billingclient.api.Purchase$PurchaseState";

		private static int? s_Purchased;

		private static int? s_Pending;

		private static AndroidJavaObject GetPurchaseStateJavaObject()
		{
			return null;
		}

		internal static int Purchased()
		{
			return 0;
		}

		internal static int Pending()
		{
			return 0;
		}
	}
}
