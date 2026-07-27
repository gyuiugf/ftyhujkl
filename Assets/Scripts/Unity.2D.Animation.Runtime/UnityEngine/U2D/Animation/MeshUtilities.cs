using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using Unity.Profiling;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal static class MeshUtilities
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int GenerateUTessOutline_00000087_0024PostfixBurstDelegate(in NativeArray<ushort> indices, ref NativeArray<int2> outline);

		internal static class GenerateUTessOutline_00000087_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static int Invoke(in NativeArray<ushort> indices, ref NativeArray<int2> outline)
			{
				return 0;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetOutlineEdgesFallback_00000088_0024PostfixBurstDelegate(in NativeArray<ushort> indices, out NativeArray<int2> output);

		internal static class GetOutlineEdgesFallback_00000088_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(in NativeArray<ushort> indices, out NativeArray<int2> output)
			{
				output = default(NativeArray<int2>);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void AddToEdgeMap_00000089_0024PostfixBurstDelegate(int x, int y, ref UnsafeHashMap<ulong, int2> edgeMap);

		internal static class AddToEdgeMap_00000089_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(int x, int y, ref UnsafeHashMap<ulong, int2> edgeMap)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void SortEdges_0000008A_0024PostfixBurstDelegate(in NativeArray<int2> unsortedEdges, out NativeArray<int2> sortedEdges);

		internal static class SortEdges_0000008A_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(in NativeArray<int2> unsortedEdges, out NativeArray<int2> sortedEdges)
			{
				sortedEdges = default(NativeArray<int2>);
			}
		}

		private static readonly ProfilerMarker k_OldOutline;

		private static readonly ProfilerMarker k_newOutline;

		public static NativeArray<int2> GetOutlineEdges(in NativeArray<ushort> indices)
		{
			return default(NativeArray<int2>);
		}

		public static NativeArray<int2> GetOutlineEdgesUTess(in NativeArray<ushort> indices)
		{
			return default(NativeArray<int2>);
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(GenerateUTessOutline_00000087_0024PostfixBurstDelegate))]
		private static int GenerateUTessOutline(in NativeArray<ushort> indices, ref NativeArray<int2> outline)
		{
			return 0;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(GetOutlineEdgesFallback_00000088_0024PostfixBurstDelegate))]
		public static void GetOutlineEdgesFallback(in NativeArray<ushort> indices, out NativeArray<int2> output)
		{
			output = default(NativeArray<int2>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(AddToEdgeMap_00000089_0024PostfixBurstDelegate))]
		private static void AddToEdgeMap(int x, int y, ref UnsafeHashMap<ulong, int2> edgeMap)
		{
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(SortEdges_0000008A_0024PostfixBurstDelegate))]
		private static void SortEdges(in NativeArray<int2> unsortedEdges, out NativeArray<int2> sortedEdges)
		{
			sortedEdges = default(NativeArray<int2>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static int GenerateUTessOutline_0024BurstManaged(in NativeArray<ushort> indices, ref NativeArray<int2> outline)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void GetOutlineEdgesFallback_0024BurstManaged(in NativeArray<ushort> indices, out NativeArray<int2> output)
		{
			output = default(NativeArray<int2>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void AddToEdgeMap_0024BurstManaged(int x, int y, ref UnsafeHashMap<ulong, int2> edgeMap)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void SortEdges_0024BurstManaged(in NativeArray<int2> unsortedEdges, out NativeArray<int2> sortedEdges)
		{
			sortedEdges = default(NativeArray<int2>);
		}
	}
}
