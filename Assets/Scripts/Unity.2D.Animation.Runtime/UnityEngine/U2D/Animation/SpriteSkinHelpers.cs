using System.Collections.Generic;

namespace UnityEngine.U2D.Animation
{
	internal static class SpriteSkinHelpers
	{
		public static void CacheChildren(Transform current, Dictionary<int, List<SpriteSkin.TransformData>> cache)
		{
		}

		public static string GenerateTransformPath(Transform rootBone, Transform child)
		{
			return null;
		}

		public static bool GetSpriteBonesTransforms(SpriteSkin spriteSkin, out Transform[] outTransform, bool forceCreateCache = false)
		{
			outTransform = null;
			return false;
		}

		private static bool GetSpriteBonesTransformFromPath(SpriteBone[] spriteBones, Dictionary<int, List<SpriteSkin.TransformData>> hierarchyCache, Transform[] outNewBoneTransform)
		{
			return false;
		}

		private static void CalculateBoneTransformsPath(int index, SpriteBone[] spriteBones, string[] paths)
		{
		}
	}
}
