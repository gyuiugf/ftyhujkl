using System;

namespace UnityEngine.Purchasing
{
	public class Product
	{
		private string m_Receipt;

		public ProductDefinition definition { get; private set; }

		public ProductMetadata metadata { get; internal set; }

		public bool availableToPurchase { get; internal set; }

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string transactionID { get; internal set; }

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string appleOriginalTransactionID { get; internal set; }

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public bool appleProductIsRestored { get; internal set; }

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public bool hasReceipt => false;

		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		public string receipt
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[Obsolete("This constructor is obsolete and should not be used. Use the Product(ProductDefinition, ProductMetadata) constructor and assign the receipt separately if needed.")]
		internal Product(ProductDefinition definition, ProductMetadata metadata, string receipt)
		{
		}

		internal Product(ProductDefinition definition, ProductMetadata metadata)
		{
		}

		internal static Product CreateUnknownProduct(string productId)
		{
			return null;
		}

		private string GetReceipt()
		{
			return null;
		}

		private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName)
		{
			return null;
		}

		private void SetReceipt(string curReceipt)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
