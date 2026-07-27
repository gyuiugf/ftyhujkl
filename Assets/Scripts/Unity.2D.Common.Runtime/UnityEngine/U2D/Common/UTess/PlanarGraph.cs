using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Common.UTess
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct PlanarGraph
	{
		private static readonly double kEpsilon;

		private static readonly int kMaxIntersectionTolerance;

		internal static void RemoveDuplicateEdges(ref Array<int2> edges, ref int edgeCount, Array<int> duplicates, int duplicateCount)
		{
		}

		internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1)
		{
			return false;
		}

		internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1)
		{
			return false;
		}

		internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result)
		{
			return false;
		}

		internal static bool CalculateEdgeIntersections(Array<int2> edges, int edgeCount, Array<double2> points, int pointCount, ref Array<int2> results, ref Array<double2> intersects, ref int resultCount)
		{
			return false;
		}

		internal static bool CalculateTJunctions(Array<int2> edges, int edgeCount, Array<double2> points, int pointCount, Array<int2> results, ref int resultCount)
		{
			return false;
		}

		internal static bool CutEdges(ref Array<double2> points, ref int pointCount, ref Array<int2> edges, ref int edgeCount, ref Array<int2> tJunctions, ref int tJunctionCount, Array<int2> intersections, Array<double2> intersects, int intersectionCount)
		{
			return false;
		}

		internal static void RemoveDuplicatePoints(ref Array<double2> points, ref int pointCount, ref Array<int> duplicates, ref int duplicateCount, Allocator allocator)
		{
		}

		internal static bool Validate(Allocator allocator, in NativeArray<float2> inputPoints, int pointCount, in NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2> outputPoints, out int outputPointCount, ref NativeArray<int2> outputEdges, out int outputEdgeCount)
		{
			outputPointCount = default(int);
			outputEdgeCount = default(int);
			return false;
		}
	}
}
