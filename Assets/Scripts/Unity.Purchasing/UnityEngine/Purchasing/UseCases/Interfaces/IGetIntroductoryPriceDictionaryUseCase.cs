using System.Collections.Generic;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface IGetIntroductoryPriceDictionaryUseCase
	{
		Dictionary<string, string> GetIntroductoryPriceDictionary();
	}
}
