using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class StoreSpecificIds : IEnumerable, ISerializationCallbackReceiver
	{
		private Dictionary<string, string> m_productIdDictionary;

		[FormerlySerializedAs("m_keys")]
		[SerializeField]
		private List<string> m_storeNames;

		[FormerlySerializedAs("m_values")]
		[SerializeField]
		private List<string> m_productIds;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}

		public void Add(string id, params string[] stores)
		{
		}

		public void Add(string id, params object[] stores)
		{
		}

		internal string SpecificIDForStore(string store, string defaultValue)
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
