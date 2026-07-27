using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class ConfigurationProvider
	{
		private readonly Dictionary<Type, IStoreConfiguration> m_ConfigMap;

		public T GetConfiguration<T>()
		{
			return default(T);
		}

		private void RegisterConfigurations()
		{
		}
	}
}
