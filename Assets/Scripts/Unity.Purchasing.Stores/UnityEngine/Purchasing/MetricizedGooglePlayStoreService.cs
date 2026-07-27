using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Exceptions;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class MetricizedGooglePlayStoreService : GooglePlayStoreService
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		[Preserve]
		internal MetricizedGooglePlayStoreService(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService)
			: base(null, null, null, null, null, null, null, null, null)
		{
		}

		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed)
		{
		}

		public override void Purchase(ProductDefinition product, Order? currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
		}
	}
}
