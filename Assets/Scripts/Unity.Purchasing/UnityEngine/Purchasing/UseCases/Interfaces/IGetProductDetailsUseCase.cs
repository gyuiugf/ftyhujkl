using System.Collections.Generic;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface IGetProductDetailsUseCase
	{
		Dictionary<string, string> GetProductDetails();
	}
}
