using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.U2D
{
	internal class SpriteShapeDefaultCreator : SpriteShapeGeometryCreator
	{
		private static SpriteShapeDefaultCreator creator;

		internal static SpriteShapeDefaultCreator defaultInstance => null;

		public override int GetVertexArrayCount(SpriteShapeController sc)
		{
			return 0;
		}

		public override JobHandle MakeCreatorJob(SpriteShapeController sc, NativeArray<ushort> indices, NativeSlice<Vector3> positions, NativeSlice<Vector2> texCoords, NativeSlice<Vector4> tangents, NativeArray<SpriteShapeSegment> segments, NativeArray<float2> colliderData)
		{
			return default(JobHandle);
		}

		public override int GetVersion()
		{
			return 0;
		}
	}
}
