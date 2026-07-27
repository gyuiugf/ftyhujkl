using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal static class BurstedSpriteSkinUtilities
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate bool ValidateBoneWeights_000001AE_0024PostfixBurstDelegate(in NativeCustomSlice<BoneWeight> boneWeights, int bindPoseCount);

		internal static class ValidateBoneWeights_000001AE_0024BurstDirectCall
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

			public static bool Invoke(in NativeCustomSlice<BoneWeight> boneWeights, int bindPoseCount)
			{
				return false;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void SetVertexPositionFromByteBuffer_000001AF_0024PostfixBurstDelegate(in NativeArray<byte> buffer, in NativeArray<int> indices, ref NativeArray<Vector3> vertices, int stride);

		internal static class SetVertexPositionFromByteBuffer_000001AF_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<byte> buffer, in NativeArray<int> indices, ref NativeArray<Vector3> vertices, int stride)
			{
			}
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(ValidateBoneWeights_000001AE_0024PostfixBurstDelegate))]
		internal static bool ValidateBoneWeights(in NativeCustomSlice<BoneWeight> boneWeights, int bindPoseCount)
		{
			return false;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(SetVertexPositionFromByteBuffer_000001AF_0024PostfixBurstDelegate))]
		internal static void SetVertexPositionFromByteBuffer(in NativeArray<byte> buffer, in NativeArray<int> indices, ref NativeArray<Vector3> vertices, int stride)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static bool ValidateBoneWeights_0024BurstManaged(in NativeCustomSlice<BoneWeight> boneWeights, int bindPoseCount)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void SetVertexPositionFromByteBuffer_0024BurstManaged(in NativeArray<byte> buffer, in NativeArray<int> indices, ref NativeArray<Vector3> vertices, int stride)
		{
		}
	}
}
