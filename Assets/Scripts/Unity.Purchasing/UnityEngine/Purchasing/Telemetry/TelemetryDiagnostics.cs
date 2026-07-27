using System;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryDiagnostics : ITelemetryDiagnostics
	{
		private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

		[Preserve]
		internal TelemetryDiagnostics(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper)
		{
		}

		public void SendDiagnostic(string diagnosticName, Exception e)
		{
		}
	}
}
