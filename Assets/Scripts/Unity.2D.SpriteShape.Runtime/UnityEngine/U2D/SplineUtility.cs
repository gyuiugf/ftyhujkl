namespace UnityEngine.U2D
{
	public class SplineUtility
	{
		public static float SlopeAngle(Vector2 start, Vector2 end)
		{
			return 0f;
		}

		public static void CalculateTangents(Vector3 point, Vector3 prevPoint, Vector3 nextPoint, Vector3 forward, float scale, out Vector3 rightTangent, out Vector3 leftTangent)
		{
			rightTangent = default(Vector3);
			leftTangent = default(Vector3);
		}

		internal static int NextIndex(int index, int pointCount)
		{
			return 0;
		}

		internal static int PreviousIndex(int index, int pointCount)
		{
			return 0;
		}

		private static int Mod(int x, int m)
		{
			return 0;
		}
	}
}
