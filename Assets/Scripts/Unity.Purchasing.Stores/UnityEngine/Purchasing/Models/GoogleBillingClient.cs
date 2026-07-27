using System;
using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Models
{
	internal class GoogleBillingClient : IGoogleBillingClient
	{
		private const string k_AndroidProductClassName = "com.android.billingclient.api.QueryProductDetailsParams$Product";

		private static AndroidJavaClass s_AndroidProductClassName;

		private const string k_AndroidQueryProductDetailsParamsClassName = "com.android.billingclient.api.QueryProductDetailsParams";

		private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName;

		private const string k_AndroidBillingFlowParamClassName = "com.android.billingclient.api.BillingFlowParams";

		private static AndroidJavaClass s_BillingFlowParamsClass;

		private const string k_AndroidProductDetailsParamsClassName = "com.android.billingclient.api.BillingFlowParams$ProductDetailsParams";

		private static AndroidJavaClass s_ProductDetailsParamsClass;

		private const string k_AndroidSubscriptionUpdateParamClassName = "com.android.billingclient.api.BillingFlowParams$SubscriptionUpdateParams";

		private static AndroidJavaClass s_SubscriptionUpdateParamsClass;

		private const string k_AndroidConsumeParamsClassName = "com.android.billingclient.api.ConsumeParams";

		private static AndroidJavaClass s_ConsumeParamsClass;

		private const string k_AndroidAcknowledgePurchaseParamsClassName = "com.android.billingclient.api.AcknowledgePurchaseParams";

		private static AndroidJavaClass s_AcknowledgePurchaseParamsClass;

		private const string k_AndroidBillingClientClassName = "com.android.billingclient.api.BillingClient";

		private static AndroidJavaClass s_BillingClientClass;

		private const string k_AndroidPendingPurchasesParamsClassName = "com.android.billingclient.api.PendingPurchasesParams";

		private static AndroidJavaClass s_PendingPurchasesParamsClass;

		private const string k_AndroidQueryPurchasesParamsClassName = "com.android.billingclient.api.QueryPurchasesParams";

		private static AndroidJavaClass s_QueryPurchasesParamsClass;

		private readonly AndroidJavaObject m_BillingClient;

		private string m_ObfuscatedAccountId;

		private string m_ObfuscatedProfileId;

		private readonly IUtil m_Util;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		private static AndroidJavaClass GetProductParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetBillingFlowParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetProductDetailsParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetSubscriptionUpdateParamClass()
		{
			return null;
		}

		private static AndroidJavaClass GetConsumeParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetAcknowledgePurchaseParamsClass()
		{
			return null;
		}

		private static AndroidJavaClass GetBillingClientClass()
		{
			return null;
		}

		private static AndroidJavaClass GetPendingPurchasesParamsClass()
		{
			return null;
		}

		private static AndroidJavaObject PendingPurchasesParams()
		{
			return null;
		}

		private static AndroidJavaClass GetQueryPurchasesParamsClass()
		{
			return null;
		}

		private static AndroidJavaObject QueryPurchasesParams(string productType)
		{
			return null;
		}

		[Preserve]
		internal GoogleBillingClient(IGooglePurchasesUpdatedListener googlePurchasesUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void SetObfuscationAccountId(string obfuscationAccountId)
		{
		}

		public void SetObfuscationProfileId(string obfuscationProfileId)
		{
		}

		public void StartConnection(IBillingClientStateListener billingClientStateListener)
		{
		}

		public void EndConnection()
		{
		}

		public bool IsReady()
		{
			return false;
		}

		public GoogleBillingConnectionState GetConnectionState()
		{
			return default(GoogleBillingConnectionState);
		}

		public void QueryPurchasesAsync(string productType, Action<IGoogleBillingResult, IEnumerable<AndroidJavaObject>> onQueryPurchasesResponse)
		{
		}

		public void QueryProductDetailsAsync(List<string> products, string type, Action<IGoogleBillingResult, List<AndroidJavaObject>> onProductDetailsResponseAction)
		{
		}

		private static AndroidJavaObject QueryProductDetailsParams(List<string> products, string type)
		{
			return null;
		}

		private static AndroidJavaObject QueryProductDetailsParamsProductList(List<string> products, string type)
		{
			return null;
		}

		private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product)
		{
			return null;
		}

		public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			return null;
		}

		private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, GooglePlayReplacementMode? replacementMode)
		{
			return null;
		}

		private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayReplacementMode replacementMode)
		{
			return null;
		}

		private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams)
		{
			return null;
		}

		public void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume)
		{
		}

		public void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge)
		{
		}
	}
}
