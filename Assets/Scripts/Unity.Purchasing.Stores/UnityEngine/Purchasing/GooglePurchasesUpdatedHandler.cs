using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Stores.Android.GooglePlay.AAR.Interfaces;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchasesUpdatedHandler : IGooglePurchasesUpdatedHandler
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleUserCancelledPurchaseFailure_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePurchasesUpdatedHandler _003C_003E4__this;

			public IGoogleBillingResult billingResult;

			private TaskAwaiter<List<IGooglePurchase>> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private readonly IGoogleLastKnownProductService m_LastKnownProductService;

		private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;

		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private IProductCache? m_ProductCache;

		[Preserve]
		internal GooglePurchasesUpdatedHandler(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
		}

		public void SubscribeToPurchasesUpdatedEvent(IGooglePurchasesUpdatedListener purchasesUpdatedListener)
		{
		}

		public void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases)
		{
		}

		private void HandleResultOkCases(IGoogleBillingResult result, List<IGooglePurchase> purchases)
		{
		}

		private void HandleErrorCases(IGoogleBillingResult billingResult, List<IGooglePurchase> purchases)
		{
		}

		private void HandleExistingPurchasesErrorCase(List<IGooglePurchase> purchases, IGoogleBillingResult billingResult)
		{
		}

		private void HandleNoPurchasesErrorCase(IGoogleBillingResult billingResult)
		{
		}

		[AsyncStateMachine(typeof(_003CHandleUserCancelledPurchaseFailure_003Ed__12))]
		private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult)
		{
		}

		private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, List<IGooglePurchase> googlePurchases)
		{
		}

		private void ApplyOnPurchases(List<IGooglePurchase> purchases, Action<IGooglePurchase> action)
		{
		}

		private void OnPurchaseOk(IGooglePurchase googlePurchase)
		{
		}

		private void HandlePurchasedProduct(IGooglePurchase googlePurchase)
		{
		}

		private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase)
		{
			return false;
		}

		private bool IsLastReplacementModeDeferred()
		{
			return false;
		}

		private void OnPurchaseCancelled(IGoogleBillingResult billingResult)
		{
		}

		private void OnPurchaseCancelled(IGooglePurchase googlePurchase)
		{
		}

		private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase)
		{
		}

		private void OnPurchaseFailedForUnknownReason(IGooglePurchase googlePurchase, string debugMessage)
		{
		}

		public void SetProductCache(IProductCache? productCache)
		{
		}
	}
}
