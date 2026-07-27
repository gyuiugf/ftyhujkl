using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayCartValidator : StoreCartValidator
	{
		[Preserve]
		internal GooglePlayCartValidator()
			: base(null, null)
		{
		}
	}
}
