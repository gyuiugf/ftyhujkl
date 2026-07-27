using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct PrepareDeformJob : IJob
	{
		[ReadOnly]
		public NativeArray<PerSkinJobData> perSkinJobData;

		[ReadOnly]
		public int batchDataSize;

		[WriteOnly]
		public NativeArray<int2> boneLookupData;

		public void Execute()
		{
		}
	}
}
