using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct BoneTransformsChangeDetectionJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<bool> transformChanged;

		[ReadOnly]
		public NativeArray<SpriteSkinData> spriteSkinData;

		[ReadOnly]
		public NativeHashMap<int, TransformAccessJob.TransformData> boneTransformIndex;

		[WriteOnly]
		public NativeArray<bool> hasBoneTransformsChanged;

		public void Execute(int skinIndex)
		{
		}
	}
}
