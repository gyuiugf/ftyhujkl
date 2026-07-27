using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct BoneDeformBatchedJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float4x4> boneTransform;

		[ReadOnly]
		public NativeArray<float4x4> rootTransform;

		[ReadOnly]
		public NativeArray<int2> boneLookupData;

		[ReadOnly]
		public NativeArray<SpriteSkinData> spriteSkinData;

		[ReadOnly]
		public NativeHashMap<int, TransformAccessJob.TransformData> rootTransformIndex;

		[ReadOnly]
		public NativeHashMap<int, TransformAccessJob.TransformData> boneTransformIndex;

		[WriteOnly]
		public NativeArray<float4x4> finalBoneTransforms;

		public void Execute(int i)
		{
		}
	}
}
