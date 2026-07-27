using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct FillPerSkinJobSingleThread : IJob
	{
		public PerSkinJobData combinedSkinBatch;

		[ReadOnly]
		public NativeArray<bool> isSpriteSkinValidForDeformArray;

		public NativeArray<SpriteSkinData> spriteSkinDataArray;

		public NativeArray<PerSkinJobData> perSkinJobDataArray;

		public NativeArray<PerSkinJobData> combinedSkinBatchArray;

		public void Execute()
		{
		}
	}
}
