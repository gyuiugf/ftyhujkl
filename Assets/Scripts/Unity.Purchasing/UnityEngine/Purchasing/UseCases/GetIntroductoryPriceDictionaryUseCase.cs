using System.Collections.Generic;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class GetIntroductoryPriceDictionaryUseCase : IGetIntroductoryPriceDictionaryUseCase
	{
		private readonly IAppleFetchProductsService m_FetchProductsService;

		[Preserve]
		internal GetIntroductoryPriceDictionaryUseCase(IAppleFetchProductsService fetchProductsService)
		{
		}

		public Dictionary<string, string> GetIntroductoryPriceDictionary()
		{
			return null;
		}
	}
}
