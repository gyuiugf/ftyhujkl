using System;
using Unity.Collections;

namespace UnityEngine.U2D.Common
{
	internal static class InternalEngineBridge
	{
		public static void SetLocalAABB(SpriteRenderer spriteRenderer, Bounds aabb)
		{
		}

		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<byte> src)
		{
		}

		public static void SetBoneTransforms(SpriteRenderer spriteRenderer, NativeArray<Matrix4x4> src)
		{
		}

		public static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return false;
		}

		public static void SetupMaterialProperties(SpriteRenderer spriteRenderer)
		{
		}

		public static Vector2 GUIUnclip(Vector2 v)
		{
			return default(Vector2);
		}

		public static Rect GetGUIClipTopMostRect()
		{
			return default(Rect);
		}

		public static Rect GetGUIClipTopRect()
		{
			return default(Rect);
		}

		public static Rect GetGUIClipVisibleRect()
		{
			return default(Rect);
		}

		public static bool IsGPUSkinningEnabled()
		{
			return false;
		}

		public static bool IsSRPBatchingEnabled(SpriteRenderer spriteRenderer)
		{
			return false;
		}

		public static void SetBatchDeformableBufferAndLocalAABBArray(SpriteRenderer[] spriteRenderers, NativeArray<IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
		{
		}

		public static void SetBatchBoneTransformsAABBArray(SpriteRenderer[] spriteRenderers, NativeArray<IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
		{
		}

		public static int ConvertFloatToInt(float f)
		{
			return 0;
		}

		public static float ConvertIntToFloat(int i)
		{
			return 0f;
		}

		public static void MarkDirty(this Object obj)
		{
		}
	}
}
