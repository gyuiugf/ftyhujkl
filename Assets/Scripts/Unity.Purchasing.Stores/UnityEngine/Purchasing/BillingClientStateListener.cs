using System;
using Uniject;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class BillingClientStateListener : AndroidJavaProxy, IBillingClientStateListener
	{
		private const string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";

		private Action m_OnConnected;

		private Action<GoogleBillingResponseCode> m_Disconnect;

		private readonly IUtil m_Util;

		internal BillingClientStateListener(IUtil util)
			: base((string)null)
		{
		}

		public void RegisterOnConnected(Action onConnected)
		{
		}

		public void RegisterOnDisconnected(Action<GoogleBillingResponseCode> onDisconnected)
		{
		}

		[Preserve]
		public void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}

		private void HandleBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}

		[Preserve]
		public void onBillingServiceDisconnected()
		{
		}
	}
}
