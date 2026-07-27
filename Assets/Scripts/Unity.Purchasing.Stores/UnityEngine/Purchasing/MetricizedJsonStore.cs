using System.Collections.Generic;
using UnityEngine.Purchasing.Telemetry;

namespace UnityEngine.Purchasing
{
	internal class MetricizedJsonStore : JsonStore
	{
		private readonly ITelemetryMetricsService m_TelemetryMetricsService;

		internal MetricizedJsonStore(ICartValidator cartValidator, ILogger logger, string storeName, ITelemetryMetricsService telemetryMetricsService)
			: base(null, null, null)
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
