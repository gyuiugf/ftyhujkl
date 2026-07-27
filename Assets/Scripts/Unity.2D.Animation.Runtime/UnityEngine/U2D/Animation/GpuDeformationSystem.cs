using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.U2D.Animation
{
	internal class GpuDeformationSystem : BaseDeformationSystem
	{
		private const string k_GpuSkinningShaderKeyword = "SKINNED_SPRITE";

		private const string k_GlobalSpriteBoneBufferId = "_SpriteBoneTransforms";

		private readonly Dictionary<int, Material> m_KeywordEnabledMaterials;

		private NativeArray<int> m_BoneTransformBufferSizes;

		private ComputeBuffer m_BoneTransformsComputeBuffer;

		private static ComputeBuffer s_FallbackBuffer;

		public override DeformationMethods deformationMethod => default(DeformationMethods);

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void CreateFallbackBuffer()
		{
		}

		private static void ClearFallbackBuffer()
		{
		}

		internal static bool DoesShaderSupportGpuDeformation(Material material)
		{
			return false;
		}

		private static bool IsComputeBufferValid(ComputeBuffer buffer)
		{
			return false;
		}

		protected override void InitializeArrays()
		{
		}

		internal override void Cleanup()
		{
		}

		protected override void ResizeAndCopyArrays(int updatedCount)
		{
		}

		private void CleanupComputeResources()
		{
		}

		internal override void UpdateMaterial(SpriteSkin spriteSkin)
		{
		}

		internal override bool AddSpriteSkin(SpriteSkin spriteSkin)
		{
			return false;
		}

		internal override void Update()
		{
		}

		protected override void ResizeBuffers(int vertexBufferSize, in PerSkinJobData skinBatch)
		{
		}

		private void CreateComputeBuffer(int bufferSize)
		{
		}

		private void SetComputeBuffer()
		{
		}

		private JobHandle ScheduleCopySpriteRendererBoneTransformBuffersJob(JobHandle jobHandle, int batchCount)
		{
			return default(JobHandle);
		}
	}
}
