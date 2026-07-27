using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchasesResponseListener : AndroidJavaProxy
	{
		private const string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";

		private readonly Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> m_OnQueryPurchasesResponse;

		private readonly IUtil m_Util;

		internal GooglePurchasesResponseListener(Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse, IUtil util)
			: base((string)null)
		{
		}

		[Preserve]
		public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases)
		{
		}
	}
}
