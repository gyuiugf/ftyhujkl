using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class ExtensionProvider : IExtensionProvider
	{
		private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap;

		private void RegisterExtensions()
		{
		}

		public T GetExtension<T>()
		{
			return default(T);
		}
	}
}
