using System;

namespace UnityEngine.Purchasing
{
	internal delegate void UnityPurchasingCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus);
}
