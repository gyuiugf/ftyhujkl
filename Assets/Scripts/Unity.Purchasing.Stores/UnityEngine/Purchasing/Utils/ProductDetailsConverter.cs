using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Utils
{
	[Preserve]
	internal class ProductDetailsConverter : IProductDetailsConverter
	{
		public List<ProductDescription> ConvertOnQueryProductDetailsResponse(IEnumerable<AndroidJavaObject> productDetails, IReadOnlyCollection<ProductDefinition> productDefinitions)
		{
			return null;
		}

		public string GetProductId(AndroidJavaObject productDetails)
		{
			return null;
		}

		public ProductDescription ConvertToProductDescription(AndroidJavaObject productDetails, ProductType productType)
		{
			return null;
		}

		internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails, ProductType productType = ProductType.Unknown)
		{
			return null;
		}
	}
}
