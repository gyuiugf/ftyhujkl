using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class VariantVariantMap : IDisposable, IDictionary<Variant, Variant>, ICollection<KeyValuePair<Variant, Variant>>, IEnumerable<KeyValuePair<Variant, Variant>>, IEnumerable
	{
		public sealed class VariantVariantMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<Variant, Variant>>, IDisposable
		{
			private VariantVariantMap collectionRef;

			private IList<Variant> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<Variant, Variant> Current => default(KeyValuePair<Variant, Variant>);

			object IEnumerator.Current => null;

			public VariantVariantMapEnumerator(VariantVariantMap collection)
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

		public Variant this[Variant key]
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

		public ICollection<Variant> Keys => null;

		public ICollection<Variant> Values => null;

		internal VariantVariantMap(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(VariantVariantMap obj)
		{
			return default(HandleRef);
		}

		~VariantVariantMap()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public bool TryGetValue(Variant key, out Variant value)
		{
			value = null;
			return false;
		}

		public void Add(KeyValuePair<Variant, Variant> item)
		{
		}

		public bool Remove(KeyValuePair<Variant, Variant> item)
		{
			return false;
		}

		public bool Contains(KeyValuePair<Variant, Variant> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<Variant, Variant>[] array)
		{
		}

		public void CopyTo(KeyValuePair<Variant, Variant>[] array, int arrayIndex)
		{
		}

		IEnumerator<KeyValuePair<Variant, Variant>> IEnumerable<KeyValuePair<Variant, Variant>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public VariantVariantMapEnumerator GetEnumerator()
		{
			return null;
		}

		public VariantVariantMap()
		{
		}

		public VariantVariantMap(VariantVariantMap other)
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

		private Variant getitem(Variant key)
		{
			return null;
		}

		private void setitem(Variant key, Variant x)
		{
		}

		public bool ContainsKey(Variant key)
		{
			return false;
		}

		public void Add(Variant key, Variant value)
		{
		}

		public bool Remove(Variant key)
		{
			return false;
		}

		private IntPtr create_iterator_begin()
		{
			return (IntPtr)0;
		}

		private Variant get_next_key(IntPtr swigiterator)
		{
			return null;
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
		}
	}
}
