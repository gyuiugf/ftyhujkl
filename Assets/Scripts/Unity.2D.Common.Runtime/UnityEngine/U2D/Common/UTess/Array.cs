using System;
using System.Diagnostics;
using Unity.Collections;

namespace UnityEngine.U2D.Common.UTess
{
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(ArrayDebugView<>))]
	internal struct Array<T> : IDisposable where T : struct
	{
		internal NativeArray<T> m_Array;

		internal int m_MaxSize;

		internal Allocator m_AllocLabel;

		internal NativeArrayOptions m_Options;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public bool IsCreated => false;

		public int Length => 0;

		public int MaxSize => 0;

		public unsafe void* UnsafePtr => null;

		public unsafe void* UnsafeReadOnlyPtr => null;

		public Array(int length, int maxSize, Allocator allocMode, NativeArrayOptions options)
		{
			m_Array = default(NativeArray<T>);
			m_MaxSize = 0;
			m_AllocLabel = default(Allocator);
			m_Options = default(NativeArrayOptions);
		}

		private void ResizeIfRequired(int index)
		{
		}

		public void Dispose()
		{
		}

		public void CopyTo(T[] array)
		{
		}
	}
}
