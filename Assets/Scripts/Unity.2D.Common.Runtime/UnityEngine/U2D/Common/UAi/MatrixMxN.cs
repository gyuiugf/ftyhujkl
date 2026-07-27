using System;
using System.Diagnostics;
using Unity.Collections;

namespace UnityEngine.U2D.Common.UAi
{
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(MatrixMxNDebugView<>))]
	internal struct MatrixMxN<T> : IDisposable where T : struct
	{
		internal NativeArray<T> m_Array;

		internal int m_Width;

		internal int m_Height;

		internal Allocator m_AllocLabel;

		internal NativeArrayOptions m_Options;

		private T this[int index]
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

		public int DimensionX => 0;

		public int DimensionY => 0;

		public MatrixMxN(int width, int height, Allocator allocMode, NativeArrayOptions options)
		{
			m_Array = default(NativeArray<T>);
			m_Width = 0;
			m_Height = 0;
			m_AllocLabel = default(Allocator);
			m_Options = default(NativeArrayOptions);
		}

		public NativeArray<T> GetArray()
		{
			return default(NativeArray<T>);
		}

		public T Get(int x, int y)
		{
			return default(T);
		}

		public void Set(int x, int y, T v)
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
