using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D.Animation
{
	internal struct NativeCustomSlice<T> where T : struct
	{
		[NativeDisableUnsafePtrRestriction]
		public IntPtr data;

		public int length;

		public int stride;

		public T this[int index] => default(T);

		public int Length => 0;

		public static NativeCustomSlice<T> Default()
		{
			return default(NativeCustomSlice<T>);
		}

		public NativeCustomSlice(NativeSlice<T> nativeSlice)
		{
			data = (IntPtr)0;
			length = 0;
			stride = 0;
		}

		public NativeCustomSlice(NativeSlice<byte> slice, int length, int stride)
		{
			data = (IntPtr)0;
			this.length = 0;
			this.stride = 0;
		}
	}
}
