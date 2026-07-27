using System.Collections.Generic;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class GetProductDetailsUseCase : IGetProductDetailsUseCase
	{
		private readonly IAppleFetchProductsService m_FetchProductsService;

		[Preserve]
		internal GetProductDetailsUseCase(IAppleFetchProductsService fetchProductsService)
		{
		}

		public Dictionary<string, string> GetProductDetails()
		{
			return null;
		}
	}
}
