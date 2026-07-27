using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class StringStringMap : IDisposable, IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		public sealed class StringStringMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<string, string>>, IDisposable
		{
			private StringStringMap collectionRef;

			private IList<string> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<string, string> Current => default(KeyValuePair<string, string>);

			object IEnumerator.Current => null;

			public StringStringMapEnumerator(StringStringMap collection)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public ICollection<string> Keys => null;

		public ICollection<string> Values => null;

		internal StringStringMap(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(StringStringMap obj)
		{
			return default(HandleRef);
		}

		~StringStringMap()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public bool TryGetValue(string key, out string value)
		{
			value = null;
			return false;
		}

		public void Add(KeyValuePair<string, string> item)
		{
		}

		public bool Remove(KeyValuePair<string, string> item)
		{
			return false;
		}

		public bool Contains(KeyValuePair<string, string> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, string>[] array)
		{
		}

		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
		}

		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public StringStringMapEnumerator GetEnumerator()
		{
			return null;
		}

		public StringStringMap()
		{
		}

		public StringStringMap(StringStringMap other)
		{
		}

		private uint size()
		{
			return 0u;
		}

		public bool empty()
		{
			return false;
		}

		public void Clear()
		{
		}

		private string getitem(string key)
		{
			return null;
		}

		private void setitem(string key, string x)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public void Add(string key, string value)
		{
		}

		public bool Remove(string key)
		{
			return false;
		}

		private IntPtr create_iterator_begin()
		{
			return (IntPtr)0;
		}

		private string get_next_key(IntPtr swigiterator)
		{
			return null;
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
		}
	}
}
