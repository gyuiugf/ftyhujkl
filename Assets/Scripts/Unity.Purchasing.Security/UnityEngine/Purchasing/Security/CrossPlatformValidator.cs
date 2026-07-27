using System;

namespace UnityEngine.Purchasing.Security
{
	public class CrossPlatformValidator
	{
		private GooglePlayValidator google;

		private string googleBundleId;

		public CrossPlatformValidator(byte[] googlePublicKey, string googleBundleId)
		{
		}

		[Obsolete("Use the CrossPlatformValidator for Google Play Store only.")]
		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string appBundleId)
		{
		}

		[Obsolete("Use the CrossPlatformValidator for Google Play Store only.")]
		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, byte[] unityChannelPublicKey_not_used, string appBundleId)
		{
		}

		[Obsolete("Use the CrossPlatformValidator for Google Play Store only.")]
		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string googleBundleId, string appleBundleId)
		{
		}

		[Obsolete("Use the CrossPlatformValidator for Google Play Store only.")]
		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, byte[] unityChannelPublicKey_not_used, string googleBundleId, string appleBundleId, string xiaomiBundleId_not_used)
		{
		}

		public IPurchaseReceipt[] Validate(string unityIAPReceipt)
		{
			return null;
		}
	}
}
