using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace UnityEngine.U2D.Animation
{
	[BurstCompile]
	internal struct LocalToWorldAndChangeDetectionTransformAccessJob : IJobParallelForTransform
	{
		public NativeArray<float4x4> outMatrix;

		[WriteOnly]
		public NativeArray<bool> hasChanged;

		public void Execute(int index, TransformAccess transform)
		{
		}
	}
}
