using Unity.Collections;

namespace UnityEngine.U2D
{
	[ExecuteInEditMode]
	[ExecuteAlways]
	public class SpriteShapeObjectPlacement : MonoBehaviour
	{
		[SerializeField]
		private SpriteShapeController m_SpriteShapeController;

		[SerializeField]
		private bool m_SetNormal;

		[SerializeField]
		private SpriteShapeObjectPlacementMode m_Mode;

		[SerializeField]
		[Min(0f)]
		private int m_StartPoint;

		[SerializeField]
		[Min(0f)]
		private int m_EndPoint;

		[SerializeField]
		private float m_Ratio;

		private int m_ActiveHashCode;

		private static readonly float kMaxDistance;

		private static readonly int kMaxIteration;

		public bool setNormal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SpriteShapeObjectPlacementMode mode
		{
			get
			{
				return default(SpriteShapeObjectPlacementMode);
			}
			set
			{
			}
		}

		public float ratio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SpriteShapeController spriteShapeController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int startPoint
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int endPoint
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private bool PlaceObjectOnHashChange()
		{
			return false;
		}

		private static float Angle(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		private float GetDistance(float dist, int spoint, int epoint, ref int start, ref int end, ref float r, NativeArray<ShapeControlPoint> shapePoints)
		{
			return 0f;
		}

		private Vector3 PlaceObjectInternal(int sp, int ep, float t, NativeArray<ShapeControlPoint> shapePoints)
		{
			return default(Vector3);
		}

		private Vector3 PlaceObject(Spline spline, int sp, int ep, ref bool run)
		{
			return default(Vector3);
		}

		private int GetSplinePointCount()
		{
			return 0;
		}

		private bool Place()
		{
			return false;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
