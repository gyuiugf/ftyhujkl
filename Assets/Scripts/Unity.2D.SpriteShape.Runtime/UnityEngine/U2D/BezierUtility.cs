using Unity.Collections;

namespace UnityEngine.U2D
{
	public static class BezierUtility
	{
		private static Vector3[] s_TempPoints;

		public static Vector3 BezierPoint(Vector3 startRightTangent, Vector3 startPosition, Vector3 endPosition, Vector3 endLeftTangent, float t)
		{
			return default(Vector3);
		}

		internal static float GetSpritePixelWidth(Sprite sprite)
		{
			return 0f;
		}

		internal static float BezierLength(NativeArray<ShapeControlPoint> shapePoints, int splineDetail, ref float smallestSegment)
		{
			return 0f;
		}

		internal static Vector3 ClosestPointOnCurve(Vector3 point, Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float sqrError, out float t)
		{
			t = default(float);
			return default(Vector3);
		}

		internal static Vector3 ClosestPointOnCurveFast(Vector3 point, Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float sqrError, out float t)
		{
			t = default(float);
			return default(Vector3);
		}

		private static Vector3 ClosestPointOnCurveIterative(Vector3 point, Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float sqrError, ref float startT, ref float endT)
		{
			return default(Vector3);
		}

		internal static void SplitBezier(float t, Vector3 startPosition, Vector3 endPosition, Vector3 startRightTangent, Vector3 endLeftTangent, out Vector3 leftStartPosition, out Vector3 leftEndPosition, out Vector3 leftStartTangent, out Vector3 leftEndTangent, out Vector3 rightStartPosition, out Vector3 rightEndPosition, out Vector3 rightStartTangent, out Vector3 rightEndTangent)
		{
			leftStartPosition = default(Vector3);
			leftEndPosition = default(Vector3);
			leftStartTangent = default(Vector3);
			leftEndTangent = default(Vector3);
			rightStartPosition = default(Vector3);
			rightEndPosition = default(Vector3);
			rightStartTangent = default(Vector3);
			rightEndTangent = default(Vector3);
		}

		internal static Vector3 ClosestPointToSegment(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd, out float t)
		{
			t = default(float);
			return default(Vector3);
		}

		private static float SqrDistanceToPolyLine(Vector3 point, Vector3[] points)
		{
			return 0f;
		}

		private static float SqrDistanceToSegment(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd)
		{
			return 0f;
		}

		private static bool Colinear(Vector3 v1, Vector3 v2, float error = 0.0001f)
		{
			return false;
		}
	}
}
