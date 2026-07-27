using System.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class MetricizedAppleStoreImpl : AppleStoreImpl
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		[Preserve]
		internal MetricizedAppleStoreImpl(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService)
			: base(null, null, null, null, null, null)
		{
		}

		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
		}

		public override void Purchase(ICart cart)
		{
		}
	}
}
