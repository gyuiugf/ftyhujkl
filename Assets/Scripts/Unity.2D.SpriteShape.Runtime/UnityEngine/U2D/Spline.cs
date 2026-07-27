using System;
using System.Collections.Generic;

namespace UnityEngine.U2D
{
	[Serializable]
	public class Spline
	{
		private static readonly string KErrorMessage;

		private static readonly float KEpsilon;

		[SerializeField]
		private bool m_IsOpenEnded;

		[SerializeField]
		private List<SplineControlPoint> m_ControlPoints;

		private int m_DirtyIndex;

		public bool isOpenEnded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool IsPositionValid(int index, int next, Vector3 point)
		{
			return false;
		}

		public void Clear()
		{
		}

		public int GetPointCount()
		{
			return 0;
		}

		public void InsertPointAt(int index, Vector3 point)
		{
		}

		public void RemovePointAt(int index)
		{
		}

		public Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		public void SetPosition(int index, Vector3 point)
		{
		}

		public Vector3 GetLeftTangent(int index)
		{
			return default(Vector3);
		}

		public void SetLeftTangent(int index, Vector3 tangent)
		{
		}

		public Vector3 GetRightTangent(int index)
		{
			return default(Vector3);
		}

		public void SetRightTangent(int index, Vector3 tangent)
		{
		}

		public ShapeTangentMode GetTangentMode(int index)
		{
			return default(ShapeTangentMode);
		}

		public void SetTangentMode(int index, ShapeTangentMode mode)
		{
		}

		public float GetHeight(int index)
		{
			return 0f;
		}

		public void SetHeight(int index, float value)
		{
		}

		public int GetSpriteIndex(int index)
		{
			return 0;
		}

		public void SetSpriteIndex(int index, int value)
		{
		}

		public bool GetCorner(int index)
		{
			return false;
		}

		public void SetCorner(int index, bool value)
		{
		}

		internal void SetCornerMode(int index, Corner value)
		{
		}

		internal Corner GetCornerMode(int index)
		{
			return default(Corner);
		}

		internal int GetChangeIndex()
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
