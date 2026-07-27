using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Animations;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.U2D.Common;

namespace UnityEngine.U2D.Animation
{
	[Preserve]
	[ExecuteInEditMode]
	[DefaultExecutionOrder(10)]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SpriteRenderer))]
	[AddComponentMenu("2D Animation/Sprite Skin")]
	[MovedFrom("UnityEngine.U2D.Experimental.Animation")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/SpriteSkin.html")]
	public sealed class SpriteSkin : MonoBehaviour, IPreviewable, UnityEngine.Animations.IAnimationPreviewable, ISerializationCallbackReceiver
	{
		internal static class Profiling
		{
			public static readonly ProfilerMarker cacheCurrentSprite;

			public static readonly ProfilerMarker cacheHierarchy;

			public static readonly ProfilerMarker getSpriteBonesTransformFromGuid;

			public static readonly ProfilerMarker getSpriteBonesTransformFromPath;
		}

		internal struct TransformData
		{
			public string fullName;

			public Transform transform;
		}

		[SerializeField]
		private Transform m_RootBone;

		[SerializeField]
		private Transform[] m_BoneTransforms;

		[SerializeField]
		private Bounds m_Bounds;

		[SerializeField]
		private bool m_AlwaysUpdate;

		[SerializeField]
		private bool m_AutoRebind;

		private SpriteRenderer m_SpriteRenderer;

		private int m_CurrentDeformSprite;

		private int m_SpriteId;

		private bool m_IsValid;

		private SpriteSkinState m_State;

		private bool m_ForceCpuDeformation;

		private int m_TextureId;

		private int m_TransformId;

		private NativeArray<int> m_BoneTransformId;

		private int m_RootBoneTransformId;

		private NativeCustomSlice<Vector3> m_SpriteVertices;

		private NativeCustomSlice<Vector4> m_SpriteTangents;

		private NativeCustomSlice<BoneWeight> m_SpriteBoneWeights;

		private NativeCustomSlice<Matrix4x4> m_SpriteBindPoses;

		private bool m_SpriteHasTangents;

		private int m_SpriteVertexStreamSize;

		private int m_SpriteVertexCount;

		private int m_SpriteTangentVertexOffset;

		private int m_DataIndex;

		private bool m_BoneCacheUpdateToDate;

		internal Dictionary<int, List<TransformData>> hierarchyCache;

		private NativeArray<int> m_OutlineIndexCache;

		private NativeArray<Vector3> m_StaticOutlineVertexCache;

		private NativeArray<Vector3> m_DeformedOutlineVertexCache;

		private Sprite m_Sprite;

		private BaseDeformationSystem m_DeformationSystem;

		private int _outlineDependencyCount;

		private static bool g_OutlineDataIsAlwaysRequired;

		internal NativeArray<int> boneTransformId => default(NativeArray<int>);

		internal int rootBoneTransformId => 0;

		internal DeformationMethods currentDeformationMethod { get; private set; }

		internal BaseDeformationSystem DeformationSystem => null;

		internal bool isOutlineDataRequired => false;

		internal NativeArray<int> outlineIndices => default(NativeArray<int>);

		internal NativeArray<Vector3> outlineVertices => default(NativeArray<Vector3>);

		internal int vertexDeformationHash => 0;

		internal Sprite sprite => null;

		internal SpriteRenderer spriteRenderer => null;

		internal NativeCustomSlice<BoneWeight> spriteBoneWeights => default(NativeCustomSlice<BoneWeight>);

		internal int dataIndex => 0;

		public bool autoRebind
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform[] boneTransforms => null;

		public Transform rootBone => null;

		internal Bounds bounds
		{
			get
			{
				return default(Bounds);
			}
			set
			{
			}
		}

		public bool alwaysUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool forceCpuDeformation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isValid => false;

		internal void RegisterOutlineDependency()
		{
		}

		internal void UnregisterOutlineDependency()
		{
		}

		internal void SetDataIndex(int index)
		{
		}

		public SpriteSkinState SetBoneTransforms(Transform[] boneTransformsArray)
		{
			return default(SpriteSkinState);
		}

		public SpriteSkinState SetRootBone(Transform rootBoneTransform)
		{
			return default(SpriteSkinState);
		}

		public bool ResetBindPose()
		{
			return false;
		}

		internal void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshBoneTransforms()
		{
		}

		private void OnSpriteChanged(SpriteRenderer updatedSpriteRenderer)
		{
		}

		private void CacheBoneTransformIds()
		{
		}

		private void OnBoneTransformChanged()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void OnBeforeSerializeBatch()
		{
		}

		private void OnAfterSerializeBatch()
		{
		}

		private SpriteSkinState CacheValidFlag()
		{
			return default(SpriteSkinState);
		}

		internal bool BatchValidate()
		{
			return false;
		}

		private void Reset()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ResetBoneTransformIdCache()
		{
		}

		public bool HasCurrentDeformedVertices()
		{
			return false;
		}

		internal NativeArray<byte> GetCurrentDeformedVertices()
		{
			return default(NativeArray<byte>);
		}

		internal NativeSlice<PositionVertex> GetCurrentDeformedVertexPositions()
		{
			return default(NativeSlice<PositionVertex>);
		}

		internal NativeSlice<PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents()
		{
			return default(NativeSlice<PositionTangentVertex>);
		}

		public IEnumerable<Vector3> GetDeformedVertexPositionData()
		{
			return null;
		}

		public IEnumerable<Vector4> GetDeformedVertexTangentData()
		{
			return null;
		}

		private void DisposeOutlineCaches()
		{
		}

		public void OnPreviewUpdate()
		{
		}

		internal void PostDeform()
		{
		}

		private void CacheCurrentSprite(bool rebind)
		{
		}

		private void UpdateSpriteDeformationData()
		{
		}

		private void UpdateDeformedOutlineCache()
		{
		}

		private void CacheSpriteOutline()
		{
		}

		private void CacheOutlineIndices(out int maxIndex)
		{
			maxIndex = default(int);
		}

		private void CacheOutlineVertices(int cacheSize)
		{
		}

		internal void CopyToSpriteSkinData(ref SpriteSkinData data)
		{
		}

		internal bool NeedToUpdateDeformationCache()
		{
			return false;
		}

		internal void CacheHierarchy(bool forceCreateCache = false)
		{
		}

		internal void DeactivateSkinning()
		{
		}

		internal void ResetSprite()
		{
		}

		internal void SetDeformationSystem(BaseDeformationSystem newDeformationSystem)
		{
		}

		private static int CountChildren(Transform transform)
		{
			return 0;
		}
	}
}
