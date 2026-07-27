using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Common.UAi
{
	internal static class kMeans
	{
		private static float CalculateDistance(MatrixMxN<float> data, int dataIndex, MatrixMxN<float> centroid, int centroidIndex)
		{
			return 0f;
		}

		private static float CalculateClustering(MatrixMxN<float> data, NativeArray<int> clusters, ref MatrixMxN<float> means, ref NativeArray<int> centroids, int clusterCount, ref NativeArray<int> clusterItems)
		{
			return 0f;
		}

		private static bool AssignClustering(MatrixMxN<float> data, NativeArray<int> clusters, ref NativeArray<int> centroidIdx, int clusterCount)
		{
			return false;
		}

		private static void ClusterInternal(MatrixMxN<float> data, NativeArray<int> clusters, MatrixMxN<float> means, NativeArray<int> centroids, NativeArray<int> clusterItems, int clusterCount, int maxIterations)
		{
		}

		public static int[] Cluster3(NativeArray<float3> items, int clusterCount, Allocator alloc, int maxIterations = 64)
		{
			return null;
		}
	}
}
