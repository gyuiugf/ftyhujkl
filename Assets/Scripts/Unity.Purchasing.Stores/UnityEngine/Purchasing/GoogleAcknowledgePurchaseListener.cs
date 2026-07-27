using System;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
	{
		private const string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		private readonly Action<IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

		private readonly IUtil m_Util;

		internal GoogleAcknowledgePurchaseListener(Action<IGoogleBillingResult> onAcknowledgePurchaseResponseAction, IUtil util)
			: base((string)null)
		{
		}

		[Preserve]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
}
