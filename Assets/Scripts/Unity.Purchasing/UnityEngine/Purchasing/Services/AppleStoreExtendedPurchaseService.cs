using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Services
{
	internal class AppleStoreExtendedPurchaseService : PurchaseService, IAppleStoreExtendedPurchaseService, IPurchaseServiceExtension
	{
		private readonly IAppReceiptUseCase m_AppReceiptUseCase;

		private readonly IContinuePromotionalPurchasesUseCase m_ContinuePromotionalPurchasesUseCase;

		private readonly IPresentCodeRedemptionSheetUseCase m_PresentCodeRedemptionSheetUseCase;

		private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase;

		private readonly ISetPromotionalPurchaseInterceptorCallbackUseCase m_SetPromotionalPurchaseInterceptorCallbackUseCase;

		private readonly ISimulateAskToBuyUseCase m_SimulateAskToBuyUseCase;

		private readonly IOnEntitlementRevokedUseCase m_OnEntitlementRevokedUseCase;

		private readonly IRefreshAppReceiptUseCase m_RefreshAppReceiptUseCase;

		public string? appReceipt => null;

		public bool simulateAskToBuy
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<string>? OnEntitlementRevoked
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Product>? OnPromotionalPurchaseIntercepted
		{
			add
			{
			}
			remove
			{
			}
		}

		[Preserve]
		internal AppleStoreExtendedPurchaseService(IAppReceiptUseCase appReceiptUseCase, IContinuePromotionalPurchasesUseCase continuePromotionalPurchasesUseCase, IPresentCodeRedemptionSheetUseCase presentCodeRedemptionSheetUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, ISetPromotionalPurchaseInterceptorCallbackUseCase setPromotionalPurchaseInterceptorCallbackUseCase, ISimulateAskToBuyUseCase simulateAskToBuyUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IOnEntitlementRevokedUseCase onEntitlementRevokedUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient, IRefreshAppReceiptUseCase refreshAppReceiptUseCase)
			: base(null, null, null, null, null, null)
		{
		}

		private void OnEntitlementOnEntitlementRevokedUseCaseOnOnEntitlementRevoked(string productId)
		{
		}

		private static bool DoesOrderContainAnyRevokedProductIds(string productId, Order order)
		{
			return false;
		}

		public void PresentCodeRedemptionSheet()
		{
		}

		protected override void RestoreTransactionsInternal(Action<bool, string?>? callback)
		{
		}

		public void ContinuePromotionalPurchases()
		{
		}

		public void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback)
		{
		}

		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
		}
	}
}
