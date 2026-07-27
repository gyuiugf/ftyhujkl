using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.U2D;

[AddComponentMenu(null)]
internal class SpriteShapeGeometryCache : MonoBehaviour
{
	[SerializeField]
	[HideInInspector]
	private int m_MaxArrayCount;

	[SerializeField]
	[HideInInspector]
	private Vector3[] m_PosArray;

	[SerializeField]
	[HideInInspector]
	private Vector2[] m_Uv0Array;

	[SerializeField]
	[HideInInspector]
	private Vector4[] m_TanArray;

	[SerializeField]
	[HideInInspector]
	private ushort[] m_IndexArray;

	[SerializeField]
	[HideInInspector]
	private SpriteShapeGeometryInfo[] m_GeomArray;

	private bool m_RequiresUpdate;

	private bool m_RequiresUpload;

	private NativeSlice<Vector3> m_PosArrayCache;

	private NativeSlice<Vector2> m_Uv0ArrayCache;

	private NativeSlice<Vector4> m_TanArrayCache;

	private NativeArray<ushort> m_IndexArrayCache;

	private NativeArray<SpriteShapeSegment> m_GeomArrayCache;

	internal ushort[] indexArray => null;

	internal Vector3[] posArray => null;

	public Vector4[] tanArray => null;

	internal int maxArrayCount => 0;

	internal bool requiresUpdate => false;

	internal bool requiresUpload => false;

	private void OnEnable()
	{
	}

	internal void SetGeometryCache(int _maxArrayCount, NativeSlice<Vector3> _posArray, NativeSlice<Vector2> _uv0Array, NativeSlice<Vector4> _tanArray, NativeArray<ushort> _indexArray, NativeArray<SpriteShapeSegment> _geomArray)
	{
	}

	internal void UpdateGeometryCache()
	{
	}

	internal JobHandle Upload(SpriteShapeRenderer sr, SpriteShapeController sc)
	{
		return default(JobHandle);
	}
}
