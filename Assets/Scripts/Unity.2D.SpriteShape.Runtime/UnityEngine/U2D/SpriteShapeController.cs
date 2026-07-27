using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;

namespace UnityEngine.U2D
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(SpriteShapeRenderer))]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@latest/index.html?subfolder=/manual/SSController.html")]
	public class SpriteShapeController : MonoBehaviour
	{
		private const float s_DistanceTolerance = 0.001f;

		private SpriteShape m_ActiveSpriteShape;

		private EdgeCollider2D m_EdgeCollider2D;

		private PolygonCollider2D m_PolygonCollider2D;

		private SpriteShapeRenderer m_SpriteShapeRenderer;

		private SpriteShapeGeometryCache m_SpriteShapeGeometryCache;

		private Sprite[] m_SpriteArray;

		private Sprite[] m_EdgeSpriteArray;

		private Sprite[] m_CornerSpriteArray;

		private AngleRangeInfo[] m_AngleRangeInfoArray;

		private NativeArray<float2> m_ColliderData;

		private NativeArray<float2> m_ShadowData;

		private NativeArray<Vector4> m_TangentData;

		private NativeArray<SpriteShapeGeneratorStats> m_Statistics;

		private bool m_DynamicOcclusionLocal;

		private bool m_DynamicOcclusionOverriden;

		private bool m_TessellationNeedsFallback;

		private bool m_WaitForBake;

		private int m_ActiveSplineHash;

		private int m_ActiveSpriteShapeHash;

		private int m_MaxArrayCount;

		private JobHandle m_JobHandle;

		private SpriteShapeParameters m_ActiveShapeParameters;

		[SerializeField]
		private Spline m_Spline;

		[SerializeField]
		private SpriteShape m_SpriteShape;

		[SerializeField]
		private float m_FillPixelPerUnit;

		[SerializeField]
		private float m_StretchTiling;

		[SerializeField]
		private int m_SplineDetail;

		[SerializeField]
		private bool m_AdaptiveUV;

		[SerializeField]
		private bool m_StretchUV;

		[SerializeField]
		private bool m_WorldSpaceUV;

		[SerializeField]
		private float m_CornerAngleThreshold;

		[SerializeField]
		private int m_ColliderDetail;

		[SerializeField]
		[Range(-0.5f, 0.5f)]
		private float m_ColliderOffset;

		[SerializeField]
		private bool m_UpdateCollider;

		[SerializeField]
		private bool m_EnableTangents;

		[SerializeField]
		[HideInInspector]
		private bool m_GeometryCached;

		[SerializeField]
		private bool m_UTess2D;

		[SerializeField]
		private bool m_UpdateShadow;

		[SerializeField]
		private int m_ShadowDetail;

		[SerializeField]
		[Range(-0.5f, 0.5f)]
		private float m_ShadowOffset;

		[SerializeField]
		private float m_BoundsScale;

		[SerializeField]
		private bool m_UpdateGeometry;

		[SerializeField]
		private SpriteShapeGeometryCreator m_Creator;

		[SerializeField]
		private List<SpriteShapeGeometryModifier> m_Modifiers;

		[SerializeField]
		private List<Vector2> m_ColliderSegment;

		[SerializeField]
		private List<Vector2> m_ShadowSegment;

		internal static readonly ProfilerMarker generateGeometry;

		internal static readonly ProfilerMarker generateCollider;

		internal int maxArrayCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool geometryCached
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal int splineHashCode => 0;

		internal Sprite[] spriteArray => null;

		internal SpriteShapeParameters spriteShapeParameters => default(SpriteShapeParameters);

		internal SpriteShapeGeometryCache spriteShapeGeometryCache => null;

		internal Sprite[] cornerSpriteArray => null;

		internal Sprite[] edgeSpriteArray => null;

		internal NativeArray<float2> shadowData => default(NativeArray<float2>);

		public AngleRangeInfo[] angleRangeInfoArray => null;

		public SpriteShapeGeometryCreator spriteShapeCreator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SpriteShapeGeometryModifier> modifiers => null;

		public int spriteShapeHashCode => 0;

		public bool worldSpaceUVs
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fillPixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableTangents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float stretchTiling
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int splineDetail
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int colliderDetail
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float colliderOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float cornerAngleThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool autoUpdateCollider
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool optimizeCollider => false;

		public bool optimizeGeometry => false;

		public bool hasCollider => false;

		public Spline spline => null;

		public float boundsScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SpriteShape spriteShape
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EdgeCollider2D edgeCollider => null;

		public PolygonCollider2D polygonCollider => null;

		public SpriteShapeRenderer spriteShapeRenderer => null;

		internal bool updateShadow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal int shadowDetail
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal float shadowOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal List<Vector2> shadowSegment => null;

		internal NativeArray<SpriteShapeGeneratorStats> stats => default(NativeArray<SpriteShapeGeneratorStats>);

		public bool WaitForBake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool autoUpdateGeometry
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void DisposeInternal()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		private static void SmartDestroy(Object o)
		{
		}

		internal Bounds InitBounds()
		{
			return default(Bounds);
		}

		public void RefreshSpriteShape()
		{
		}

		private bool ValidateSpline()
		{
			return false;
		}

		private bool ValidateSpriteShapeTexture()
		{
			return false;
		}

		internal bool ValidateUTess2D()
		{
			return false;
		}

		private bool HasSpriteShapeChanged()
		{
			return false;
		}

		private bool HasSpriteShapeDataChanged()
		{
			return false;
		}

		private int GetCustomScriptHashCode()
		{
			return 0;
		}

		private bool HasSplineDataChanged()
		{
			return false;
		}

		private void OnBecameInvisible()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnWillRenderObject()
		{
		}

		public JobHandle BakeMesh()
		{
			return default(JobHandle);
		}

		internal void UpdateGeometryCache()
		{
		}

		public bool UpdateSpriteShapeParameters()
		{
			return false;
		}

		private void UpdateSpriteData()
		{
		}

		internal NativeArray<ShapeControlPoint> GetShapeControlPoints()
		{
			return default(NativeArray<ShapeControlPoint>);
		}

		internal NativeArray<SplinePointMetaData> GetSplinePointMetaData()
		{
			return default(NativeArray<SplinePointMetaData>);
		}

		internal int CalculateMaxArrayCount(NativeArray<ShapeControlPoint> shapePoints)
		{
			return 0;
		}

		private JobHandle ScheduleBake()
		{
			return default(JobHandle);
		}

		internal void BakeShadow()
		{
		}

		public void BakeCollider()
		{
		}

		internal void BakeMeshForced()
		{
		}

		internal void ForceShadowShapeUpdate(bool forceUpdate)
		{
		}

		internal NativeArray<float2> GetShadowShapeData()
		{
			return default(NativeArray<float2>);
		}
	}
}
