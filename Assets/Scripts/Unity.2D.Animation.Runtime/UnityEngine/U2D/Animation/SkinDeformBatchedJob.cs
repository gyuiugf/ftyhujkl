using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct SkinDeformBatchedJob : IJobParallelFor
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CopyBuffer_00000028_0024PostfixBurstDelegate(byte* currentPosStart, byte* previousPosStart, int streamSize, int vertexCount);

		internal static class CopyBuffer_00000028_0024BurstDirectCall
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

			public unsafe static void Invoke(byte* currentPosStart, byte* previousPosStart, int streamSize, int vertexCount)
			{
			}
		}

		public NativeSlice<byte> vertices;

		public NativeSlice<byte> previousVertices;

		[ReadOnly]
		public NativeArray<SpriteSkinData> spriteSkinData;

		[ReadOnly]
		public NativeArray<PerSkinJobData> perSkinJobData;

		[ReadOnly]
		public NativeArray<float4x4> finalBoneTransforms;

		[ReadOnly]
		public NativeArray<bool> isSpriteSkinValidForDeformArray;

		[ReadOnly]
		public NativeArray<bool> hasBoneTransformsChanged;

		[WriteOnly]
		public NativeArray<Bounds> bounds;

		[WriteOnly]
		public NativeArray<int> lastDeformedFrame;

		public int frameCount;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(CopyBuffer_00000028_0024PostfixBurstDelegate))]
		private unsafe static void CopyBuffer(byte* currentPosStart, byte* previousPosStart, int streamSize, int vertexCount)
		{
		}

		public void Execute(int spriteIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal unsafe static void CopyBuffer_0024BurstManaged(byte* currentPosStart, byte* previousPosStart, int streamSize, int vertexCount)
		{
		}
	}
}
