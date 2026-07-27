using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace UnityEngine.U2D.Animation
{
	internal class TransformAccessJob
	{
		public struct TransformData
		{
			public int transformIndex;

			public int refCount;

			public TransformData(int index)
			{
				transformIndex = 0;
				refCount = 0;
			}
		}

		private Transform[] m_Transform;

		private TransformAccessArray m_TransformAccessArray;

		private NativeHashMap<int, TransformData> m_TransformData;

		private NativeArray<float4x4> m_TransformMatrix;

		private NativeArray<bool> m_TransformChanged;

		private bool m_Dirty;

		private JobHandle m_JobHandle;

		public NativeHashMap<int, TransformData> transformData => default(NativeHashMap<int, TransformData>);

		public NativeArray<float4x4> transformMatrix => default(NativeArray<float4x4>);

		public NativeArray<bool> transformChanged => default(NativeArray<bool>);

		public void Destroy()
		{
		}

		private void InitializeDataStructures()
		{
		}

		private void ClearDataStructures()
		{
		}

		public void ResetCache()
		{
		}

		public void AddTransform(Transform t)
		{
		}

		private static void ArrayAdd<T>(ref T[] array, T item)
		{
		}

		private static void ArrayRemoveAt<T>(ref T[] array, int index)
		{
		}

		private static void CompactArray<T>(ref T[] array)
		{
		}

		private void UpdateTransformIndex()
		{
		}

		public JobHandle StartLocalToWorldAndChangeDetectionJob()
		{
			return default(JobHandle);
		}

		public JobHandle StartWorldToLocalJob()
		{
			return default(JobHandle);
		}

		internal string GetDebugLog()
		{
			return null;
		}

		internal int RemoveTransformsIfNull()
		{
			return 0;
		}

		internal void RemoveTransformsByIds(List<int> idsToRemove)
		{
		}

		internal void RemoveTransformById(int transformId)
		{
		}
	}
}
