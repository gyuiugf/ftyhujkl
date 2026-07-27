using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;

namespace UnityEngine.U2D.Animation
{
	internal abstract class BaseDeformationSystem
	{
		protected static class Profiling
		{
			public static readonly ProfilerMarker transformAccessJob;

			public static readonly ProfilerMarker boneTransformsChangeDetection;

			public static readonly ProfilerMarker getSpriteSkinBatchData;

			public static readonly ProfilerMarker scheduleJobs;

			public static readonly ProfilerMarker setBatchDeformableBufferAndLocalAABB;

			public static readonly ProfilerMarker setBoneTransformsArray;
		}

		protected int m_ObjectId;

		protected readonly HashSet<SpriteSkin> m_SpriteSkins;

		protected SpriteRenderer[] m_SpriteRenderers;

		private readonly HashSet<SpriteSkin> m_SpriteSkinsToAdd;

		private readonly HashSet<SpriteSkin> m_SpriteSkinsToRemove;

		private readonly List<int> m_TransformIdsToRemove;

		protected NativeByteArray m_DeformedVerticesBuffer;

		protected NativeByteArray m_PreviousDeformedVerticesBuffer;

		protected NativeArray<float4x4> m_FinalBoneTransforms;

		protected NativeArray<bool> m_IsSpriteSkinActiveForDeform;

		protected NativeArray<SpriteSkinData> m_SpriteSkinData;

		protected NativeArray<PerSkinJobData> m_PerSkinJobData;

		protected NativeArray<Bounds> m_BoundsData;

		protected NativeArray<IntPtr> m_Buffers;

		protected NativeArray<int> m_BufferSizes;

		protected NativeArray<IntPtr> m_BoneTransformBuffers;

		protected NativeArray<int2> m_BoneLookupData;

		protected NativeArray<PerSkinJobData> m_SkinBatchArray;

		protected NativeArray<bool> m_HasBoneTransformsChanged;

		protected NativeArray<int> m_LastDeformedFrame;

		protected TransformAccessJob m_LocalToWorldTransformAccessJob;

		protected TransformAccessJob m_WorldToLocalTransformAccessJob;

		protected JobHandle m_DeformJobHandle;

		public abstract DeformationMethods deformationMethod { get; }

		internal void RemoveBoneTransforms(SpriteSkin spriteSkin)
		{
		}

		internal void AddBoneTransforms(SpriteSkin spriteSkin)
		{
		}

		internal virtual void UpdateMaterial(SpriteSkin spriteSkin)
		{
		}

		internal virtual bool AddSpriteSkin(SpriteSkin spriteSkin)
		{
			return false;
		}

		internal void CopyToSpriteSkinData(SpriteSkin spriteSkin)
		{
		}

		internal void RemoveSpriteSkin(SpriteSkin spriteSkin)
		{
		}

		internal HashSet<SpriteSkin> GetSpriteSkins()
		{
			return null;
		}

		internal void Initialize(int objectId)
		{
		}

		protected virtual void InitializeArrays()
		{
		}

		protected void BatchRemoveSpriteSkins()
		{
		}

		protected void BatchAddSpriteSkins()
		{
		}

		protected virtual void ResizeAndCopyArrays(int updatedCount)
		{
		}

		protected virtual void ResizeBuffers(int vertexBufferSize, in PerSkinJobData skinBatch)
		{
		}

		internal virtual void Cleanup()
		{
		}

		internal abstract void Update();

		protected void PrepareDataForDeformation(out JobHandle localToWorldJobHandle, out JobHandle worldToLocalJobHandle)
		{
			localToWorldJobHandle = default(JobHandle);
			worldToLocalJobHandle = default(JobHandle);
		}

		private void ValidateSpriteSkinData()
		{
		}

		protected bool GotVerticesToDeform(out int vertexBufferSize)
		{
			vertexBufferSize = default(int);
			return false;
		}

		protected JobHandle SchedulePrepareJob(int batchCount)
		{
			return default(JobHandle);
		}

		protected JobHandle ScheduleBoneJobBatched(JobHandle jobHandle, PerSkinJobData skinBatch)
		{
			return default(JobHandle);
		}

		protected JobHandle ScheduleSkinDeformBatchedJob(JobHandle jobHandle, PerSkinJobData skinBatch, int spriteCount, int frameCount)
		{
			return default(JobHandle);
		}

		protected JobHandle ScheduleCopySpriteRendererBuffersJob(JobHandle jobHandle, int batchCount)
		{
			return default(JobHandle);
		}

		protected void DeactivateDeformableBuffers()
		{
		}

		internal bool IsSpriteSkinActiveForDeformation(SpriteSkin spriteSkin)
		{
			return false;
		}

		internal int GetLastDeformedFrame(SpriteSkin spriteSkin)
		{
			return 0;
		}

		internal NativeArray<byte> GetDeformableBufferForSpriteSkin(SpriteSkin spriteSkin)
		{
			return default(NativeArray<byte>);
		}
	}
}
