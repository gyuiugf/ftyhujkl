using System;

namespace UnityEngine.Purchasing.Security
{
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class AppleValidator
	{
		private X509Cert cert;

		private AppleReceiptParser parser;

		public AppleValidator(byte[] appleRootCertificate)
		{
		}

		public AppleReceipt Validate(byte[] receiptData)
		{
			return null;
		}
	}
}
