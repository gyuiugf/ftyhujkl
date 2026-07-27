using System;
using System.Collections.Concurrent;

namespace UnityEngine.Purchasing.Telemetry
{
	internal class TelemetryQueue<TTelemetryEventParams>
	{
		private readonly Action<TTelemetryEventParams> m_SendTelemetryEvent;

		private ConcurrentQueue<TTelemetryEventParams> m_Queue;

		internal const int k_maxQueueSize = 10;

		public TelemetryQueue(Action<TTelemetryEventParams> sendTelemetryEvent)
		{
		}

		internal void QueueEvent(TTelemetryEventParams telemetryEvent)
		{
		}

		internal void SendQueuedEvents()
		{
		}
	}
}
