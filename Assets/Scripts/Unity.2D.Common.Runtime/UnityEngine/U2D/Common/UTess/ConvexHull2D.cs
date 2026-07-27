using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Common.UTess
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ConvexHull2D
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		private struct F3Compare : IComparer<float3>
		{
			public int Compare(float3 x, float3 y)
			{
				return 0;
			}
		}

		private static readonly float kEpsilon;

		private static float DistancePointToLine(float2 pq, float2 p0, float2 p1)
		{
			return 0f;
		}

		private static float Sign(float2 p1, float2 p2, float2 p3)
		{
			return 0f;
		}

		private static bool PointInTriangle(float2 pt, float2 v1, float2 v2, float2 v3)
		{
			return false;
		}

		private static void FetchPointsOutsideTriangle(ref NativeArray<float2> input, int inputCount, ref NativeArray<float2> output, ref int outputCount, float2 lp, float2 p, float2 rp)
		{
		}

		private static void FetchPointsOnRight(ref NativeArray<float2> input, int inputCount, ref NativeArray<float2> output, ref int outputCount, float2 l, float2 r)
		{
		}

		private unsafe static void FetchPoints(float2* input, int inputCount, ref NativeArray<float2> lp, ref int lpCount, ref NativeArray<float2> rp, ref int rpCount, float2 l, float2 r)
		{
		}

		private static void Generate(ref NativeArray<float2> output, ref int outputCount, ref NativeArray<float2> input, int inputCount, float2 l, float2 r)
		{
		}

		private unsafe static int CheckSide(float2* convex, int start, int end, float2 p, float2 d)
		{
			return 0;
		}

		public static bool CheckCollisionSeparatingAxis(ref NativeArray<float2> convex1_, int start1, int end1, ref NativeArray<float2> convex2_, int start2, int end2)
		{
			return false;
		}

		internal static bool LineLineIntersection(float2 p1, float2 p2, float2 p3, float2 p4, ref float2 result)
		{
			return false;
		}

		public unsafe static float3 Generate(ref NativeArray<float2> result, ref float4 aabb, ref int pointCount, int seed, Vector2* vertexInput, int vertexCount, float extrude)
		{
			return default(float3);
		}
	}
}
