using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Analytics
{
	internal class IntIntMap : IDisposable, IDictionary<int, int>, ICollection<KeyValuePair<int, int>>, IEnumerable<KeyValuePair<int, int>>, IEnumerable
	{
		public sealed class IntIntMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<int, int>>, IDisposable
		{
			private IntIntMap collectionRef;

			private IList<int> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<int, int> Current => default(KeyValuePair<int, int>);

			object IEnumerator.Current => null;

			public IntIntMapEnumerator(IntIntMap collection)
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

		public int this[int key]
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public ICollection<int> Keys => null;

		public ICollection<int> Values => null;

		internal IntIntMap(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IntIntMap obj)
		{
			return default(HandleRef);
		}

		~IntIntMap()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public bool TryGetValue(int key, out int value)
		{
			value = default(int);
			return false;
		}

		public void Add(KeyValuePair<int, int> item)
		{
		}

		public bool Remove(KeyValuePair<int, int> item)
		{
			return false;
		}

		public bool Contains(KeyValuePair<int, int> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<int, int>[] array)
		{
		}

		public void CopyTo(KeyValuePair<int, int>[] array, int arrayIndex)
		{
		}

		IEnumerator<KeyValuePair<int, int>> IEnumerable<KeyValuePair<int, int>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IntIntMapEnumerator GetEnumerator()
		{
			return null;
		}

		public IntIntMap()
		{
		}

		public IntIntMap(IntIntMap other)
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

		private int getitem(int key)
		{
			return 0;
		}

		private void setitem(int key, int x)
		{
		}

		public bool ContainsKey(int key)
		{
			return false;
		}

		public void Add(int key, int value)
		{
		}

		public bool Remove(int key)
		{
			return false;
		}

		private IntPtr create_iterator_begin()
		{
			return (IntPtr)0;
		}

		private int get_next_key(IntPtr swigiterator)
		{
			return 0;
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
		}
	}
}
