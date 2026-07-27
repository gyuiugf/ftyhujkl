using System;

namespace UnityEngine.U2D
{
	[Serializable]
	public class SplineControlPoint
	{
		public Vector3 position;

		public Vector3 leftTangent;

		public Vector3 rightTangent;

		public ShapeTangentMode mode;

		public float height;

		public int spriteIndex;

		public bool corner;

		[SerializeField]
		private Corner m_CornerMode;

		public Corner cornerMode
		{
			get
			{
				return default(Corner);
			}
			set
			{
			}
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
