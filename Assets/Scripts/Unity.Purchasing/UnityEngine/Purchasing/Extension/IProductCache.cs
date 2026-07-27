using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Purchasing.Extension
{
	internal interface IProductCache
	{
		Dictionary<string, Product> productsById { get; }

		void Add(Product product);

		void Add(List<Product> product);

		ReadOnlyObservableCollection<Product> GetProducts();

		Product? Find(string? productId);

		Product FindOrDefault(string? productId);

		void Remove(Product product);
	}
}
