using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct CopySpriteRendererBoneTransformBuffersJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<bool> isSpriteSkinValidForDeformArray;

		[ReadOnly]
		public NativeArray<SpriteSkinData> spriteSkinData;

		[ReadOnly]
		public NativeArray<PerSkinJobData> perSkinJobData;

		[ReadOnly]
		[NativeDisableUnsafePtrRestriction]
		public IntPtr ptrBoneTransforms;

		[WriteOnly]
		public NativeArray<IntPtr> buffers;

		[WriteOnly]
		public NativeArray<int> bufferSizes;

		public void Execute(int i)
		{
		}
	}
}
