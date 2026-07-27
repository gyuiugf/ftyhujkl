using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchasesUpdatedListener : AndroidJavaProxy, IGooglePurchasesUpdatedListener
	{
		private const string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener";

		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;

		private readonly IUtil m_Util;

		public event Action<IGoogleBillingResult, List<IGooglePurchase>> OnPurchaseUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal GooglePurchasesUpdatedListener(IGooglePurchaseBuilder purchaseBuilder, IUtil util)
			: base((string)null)
		{
		}

		[Preserve]
		public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}

		private void HandlePurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}
	}
}
