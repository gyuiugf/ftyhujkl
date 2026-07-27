using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	public class ProductFetchFailed
	{
		public List<ProductDefinition> FailedFetchProducts { get; }

		public string FailureReason { get; }

		internal ProductFetchFailed(List<ProductDefinition> products, string reason)
		{
		}
	}
}
