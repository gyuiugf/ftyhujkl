using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D.Animation
{
	internal static class NativeArrayHelpers
	{
		public static void ResizeIfNeeded<T>(ref NativeArray<T> nativeArray, int size, Allocator allocator = Allocator.Persistent, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
		}

		public static void ResizeAndCopyIfNeeded<T>(ref NativeArray<T> nativeArray, int size, Allocator allocator = Allocator.Persistent, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
		}

		public static void DisposeIfCreated<T>(this NativeArray<T> nativeArray) where T : struct
		{
		}

		[WriteAccessRequired]
		public static void CopyFromNativeSlice<T, S>(this NativeArray<T> nativeArray, int dstStartIndex, int dstEndIndex, NativeSlice<S> slice, int srcStartIndex, int srcEndIndex) where T : struct where S : struct
		{
		}
	}
}
