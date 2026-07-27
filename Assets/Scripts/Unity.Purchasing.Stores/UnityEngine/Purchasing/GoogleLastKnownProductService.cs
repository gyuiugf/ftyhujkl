using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	[Preserve]
	internal class GoogleLastKnownProductService : IGoogleLastKnownProductService
	{
		public string? LastKnownOldProductId { get; set; }

		public string? LastKnownProductId { get; set; }

		public GooglePlayReplacementMode? LastKnownReplacementMode { get; set; }
	}
}
