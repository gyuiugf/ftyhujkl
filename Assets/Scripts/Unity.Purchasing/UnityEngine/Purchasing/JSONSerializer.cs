using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class JSONSerializer
	{
		public static string SerializeProductDef(ProductDefinition product)
		{
			return null;
		}

		public static string SerializeProductDefs(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		public static string SerializeProductStoreSpecificIds(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		public static string SerializeProductDescs(ProductDescription product)
		{
			return null;
		}

		public static string SerializeProductDescs(IEnumerable<ProductDescription> products)
		{
			return null;
		}

		public static Dictionary<string, Dictionary<string, object>> DeserializeFetchedPurchases(string json)
		{
			return null;
		}

		public static List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			return null;
		}

		public static List<ProductDescription> DeserializeProductDescriptionsFromFetchProductsSk2(string json)
		{
			return null;
		}

		public static Dictionary<string, object> DeserializePurchaseDetails(string purchaseDetailJson)
		{
			return null;
		}

		public static Dictionary<string, string> DeserializeSubscriptionDescriptions(string json)
		{
			return null;
		}

		public static Dictionary<string, string> DeserializeProductDetails(string json)
		{
			return null;
		}

		public static PurchaseFailureDescription DeserializeFailureReason(string json, IProductCache productCache)
		{
			return null;
		}

		private static ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
		{
			return null;
		}

		private static string BuildPurchaseFailureDescriptionMessage(Dictionary<string, object> dic)
		{
			return null;
		}

		private static Dictionary<string, object> EncodeProductDef(ProductDefinition product)
		{
			return null;
		}

		private static Dictionary<string, object> EncodeProductDesc(ProductDescription product)
		{
			return null;
		}

		private static Dictionary<string, object> EncodeProductMeta(ProductMetadata product)
		{
			return null;
		}

		public static StoreConnectionFailureDescription DeserializeConnectionFailureDescription(string json)
		{
			return null;
		}

		public static ProductFetchFailureDescription DeserializeProductFetchFailureDescription(string json)
		{
			return null;
		}

		public static PurchasesFetchFailureDescription DeserializePurchasesFetchFailureDescription(string json)
		{
			return null;
		}
	}
}
