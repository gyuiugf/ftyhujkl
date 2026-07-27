using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePurchaseService : IGooglePurchaseService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPurchase_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GooglePurchaseService _003C_003E4__this;

			public ProductDefinition product;

			public Order currentOrder;

			public GooglePlayReplacementMode? desiredReplacementMode;

			private TaskAwaiter<List<AndroidJavaObject>> _003C_003Eu__1;

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

		private readonly IGoogleBillingClient m_BillingClient;

		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		private readonly IQueryProductDetailsService m_QueryProductDetailsService;

		private readonly ILogger m_Logger;

		private IProductCache? m_ProductCache;

		[Preserve]
		internal GooglePurchaseService(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService, ILogger logger)
		{
		}

		[AsyncStateMachine(typeof(_003CPurchase_003Ed__6))]
		public void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		private void OnQueryProductDetailsResponse(List<AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		private bool ValidateQueryProductDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Order? currentOrder)
		{
			return false;
		}

		private bool ValidateSkus(List<AndroidJavaObject>? skus)
		{
			return false;
		}

		private void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject>? skus)
		{
		}

		private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy)
		{
		}

		private static bool ValidateCurrentOrder(Order? currentOrder)
		{
			return false;
		}

		private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Order? currentOrder)
		{
		}

		private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}

		private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku)
		{
		}

		public void SetProductCache(IProductCache? productCache)
		{
		}
	}
}
