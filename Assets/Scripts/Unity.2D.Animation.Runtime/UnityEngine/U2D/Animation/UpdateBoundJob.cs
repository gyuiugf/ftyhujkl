using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct UpdateBoundJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<int> rootTransformId;

		[ReadOnly]
		public NativeArray<int> rootBoneTransformId;

		[ReadOnly]
		public NativeArray<float4x4> rootTransform;

		[ReadOnly]
		public NativeArray<float4x4> boneTransform;

		[ReadOnly]
		public NativeHashMap<int, TransformAccessJob.TransformData> rootTransformIndex;

		[ReadOnly]
		public NativeHashMap<int, TransformAccessJob.TransformData> boneTransformIndex;

		[ReadOnly]
		public NativeArray<Bounds> spriteSkinBound;

		public NativeArray<Bounds> bounds;

		public void Execute(int i)
		{
		}
	}
}
