using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class SetStorePromotionVisibilityUseCase : ISetStorePromotionVisibilityUseCase
	{
		private readonly INativeAppleStore m_NativeAppleStore;

		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;

		[Preserve]
		internal SetStorePromotionVisibilityUseCase(INativeAppleStore nativeStore, ITelemetryDiagnostics telemetryDiagnostics)
		{
		}

		public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visibility)
		{
		}
	}
}
