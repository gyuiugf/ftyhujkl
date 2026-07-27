using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine.U2D.Common.UTess;

namespace UnityEngine.U2D
{
	[BurstCompile]
	internal struct SpriteShapeGenerator : IJob
	{
		private struct JobParameters
		{
			public int4 shapeData;

			public int4 splineData;

			public float4 curveData;

			public float4 fillData;
		}

		private struct JobSpriteInfo
		{
			public float4 texRect;

			public float4 texData;

			public float4 uvInfo;

			public float4 metaInfo;

			public float4 border;
		}

		private struct JobAngleRange
		{
			public float4 spriteAngles;

			public int4 spriteData;
		}

		private struct JobControlPoint
		{
			public int4 cpData;

			public int4 exData;

			public float2 cpInfo;

			public float2 position;

			public float2 tangentLt;

			public float2 tangentRt;
		}

		private struct JobContourPoint
		{
			public float2 position;

			public float2 ptData;
		}

		private struct JobIntersectPoint
		{
			public float2 top;

			public float2 bottom;
		}

		private struct JobSegmentInfo
		{
			public int4 sgInfo;

			public float4 spriteInfo;
		}

		private struct JobCornerInfo
		{
			public float2 bottom;

			public float2 top;

			public float2 left;

			public float2 right;

			public int2 cornerData;
		}

		private struct JobShapeVertex
		{
			public float2 pos;

			public float2 uv;

			public float4 tan;

			public float2 meta;

			public int4 sprite;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void UTessellator_0000017F_0024PostfixBurstDelegate(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Allocator label);

		internal static class UTessellator_0000017F_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public unsafe static void Invoke(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Allocator label)
			{
			}
		}

		public ProfilerMarker generateGeometry;

		public ProfilerMarker generateCollider;

		[ReadOnly]
		private JobParameters m_ShapeParams;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		private NativeArray<JobSpriteInfo> m_SpriteInfos;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		private NativeArray<JobSpriteInfo> m_CornerSpriteInfos;

		[ReadOnly]
		[DeallocateOnJobCompletion]
		private NativeArray<JobAngleRange> m_AngleRanges;

		[DeallocateOnJobCompletion]
		private NativeArray<JobSegmentInfo> m_Segments;

		private int m_SegmentCount;

		[DeallocateOnJobCompletion]
		private NativeArray<JobContourPoint> m_ContourPoints;

		private int m_ContourPointCount;

		[DeallocateOnJobCompletion]
		private NativeArray<JobCornerInfo> m_Corners;

		private int m_CornerCount;

		[DeallocateOnJobCompletion]
		private NativeArray<float2> m_TessPoints;

		private int m_TessPointCount;

		[DeallocateOnJobCompletion]
		private NativeArray<JobControlPoint> m_ControlPoints;

		private int m_ControlPointCount;

		[DeallocateOnJobCompletion]
		private NativeArray<float2> m_CornerCoordinates;

		[DeallocateOnJobCompletion]
		private NativeArray<JobControlPoint> m_GeneratedControlPoints;

		[DeallocateOnJobCompletion]
		private NativeArray<int2> m_SpriteIndices;

		[DeallocateOnJobCompletion]
		private NativeArray<JobIntersectPoint> m_Intersectors;

		private int m_IndexArrayCount;

		public NativeArray<ushort> m_IndexArray;

		private int m_VertexArrayCount;

		public NativeSlice<Vector3> m_PosArray;

		public NativeSlice<Vector2> m_Uv0Array;

		public NativeSlice<Vector4> m_TanArray;

		private int m_GeomArrayCount;

		public NativeArray<SpriteShapeSegment> m_GeomArray;

		private int m_ColliderPointCount;

		public NativeArray<float2> m_ColliderPoints;

		private int m_ShadowPointCount;

		public NativeArray<float2> m_ShadowPoints;

		public NativeArray<Bounds> m_Bounds;

		public NativeArray<SpriteShapeGeneratorStats> m_Stats;

		private int m_IndexDataCount;

		private int m_VertexDataCount;

		private int m_ColliderDataCount;

		private int m_ShadowDataCount;

		private int m_ActiveIndexCount;

		private int m_ActiveVertexCount;

		private float2 m_FirstLT;

		private float2 m_FirstLB;

		private float4x4 m_Transform;

		private int kModeLinear;

		private int kModeContinous;

		private int kModeBroken;

		private int kModeUTess;

		private int kCornerTypeOuterTopLeft;

		private int kCornerTypeOuterTopRight;

		private int kCornerTypeOuterBottomLeft;

		private int kCornerTypeOuterBottomRight;

		private int kCornerTypeInnerTopLeft;

		private int kCornerTypeInnerTopRight;

		private int kCornerTypeInnerBottomLeft;

		private int kCornerTypeInnerBottomRight;

		private int kControlPointCount;

		private int kMaxArrayCount;

		private float kEpsilon;

		private float kEpsilonOrder;

		private float kEpsilonRelaxed;

		private float kExtendSegment;

		private float kRenderQuality;

		private float kOptimizeRender;

		private float kColliderQuality;

		private float kOptimizeCollider;

		private float kShadowQuality;

		private float kLowestQualityTolerance;

		private float kHighestQualityTolerance;

		private int vertexDataCount => 0;

		private int vertexArrayCount => 0;

		private int indexDataCount => 0;

		private int spriteCount => 0;

		private int cornerSpriteCount => 0;

		private int angleRangeCount => 0;

		private int controlPointCount => 0;

		private int contourPointCount => 0;

		private int segmentCount => 0;

		private bool hasCollider => false;

		private bool hasShadow => false;

		private float colliderPivot => 0f;

		private float shadowPivot => 0f;

		private float borderPivot => 0f;

		private int splineDetail => 0;

		private bool isCarpet => false;

		private bool isAdaptive => false;

		private bool hasSpriteBorder => false;

		private JobSpriteInfo GetSpriteInfo(int index)
		{
			return default(JobSpriteInfo);
		}

		private JobSpriteInfo GetCornerSpriteInfo(int index)
		{
			return default(JobSpriteInfo);
		}

		private JobAngleRange GetAngleRange(int index)
		{
			return default(JobAngleRange);
		}

		private JobControlPoint GetControlPoint(int index)
		{
			return default(JobControlPoint);
		}

		private JobContourPoint GetContourPoint(int index)
		{
			return default(JobContourPoint);
		}

		private JobSegmentInfo GetSegmentInfo(int index)
		{
			return default(JobSegmentInfo);
		}

		private int GetContourIndex(int index)
		{
			return 0;
		}

		private int GetEndContourIndexOfSegment(JobSegmentInfo isi)
		{
			return 0;
		}

		private void SetResult(SpriteShapeGeneratorResult result)
		{
		}

		private static void CopyToNativeArray<T>(NativeArray<T> from, int length, ref NativeArray<T> to) where T : struct
		{
		}

		private static void SafeDispose<T>(NativeArray<T> na) where T : struct
		{
		}

		private static bool IsPointOnLine(float epsilon, float2 a, float2 b, float2 c)
		{
			return false;
		}

		private static bool IsPointOnLines(float epsilon, float2 p1, float2 p2, float2 p3, float2 p4, float2 r)
		{
			return false;
		}

		private static bool Colinear(float2 p, float2 q, float2 r)
		{
			return false;
		}

		private static int Det(float epsilon, float2 p, float2 q, float2 r)
		{
			return 0;
		}

		private static bool LineIntersectionTest(float epsilon, float2 p1, float2 q1, float2 p2, float2 q2)
		{
			return false;
		}

		private static bool LineIntersection(float epsilon, float2 p1, float2 p2, float2 p3, float2 p4, ref float2 result)
		{
			return false;
		}

		private static float AngleBetweenVector(float2 a, float2 b)
		{
			return 0f;
		}

		private static bool GenerateColumnsBi(float2 a, float2 b, float2 whsize, bool flip, ref float2 rt, ref float2 rb, float cph, float pivot)
		{
			return false;
		}

		private static bool GenerateColumnsTri(float2 a, float2 b, float2 c, float2 whsize, bool flip, ref float2 rt, ref float2 rb, float cph, float pivot)
		{
			return false;
		}

		private void AppendCornerCoordinates(ref NativeArray<float2> corners, ref int cornerCount, float2 a, float2 b, float2 c, float2 d)
		{
		}

		private void PrepareInput(SpriteShapeParameters shapeParams, int maxArrayCount, NativeArray<ShapeControlPoint> shapePoints, bool optimizeGeometry, bool updateCollider, bool optimizeCollider, float colliderOffset, float colliderDetail, bool updateShadow, float shadowOffset, float shadowDetail)
		{
		}

		private void TransferSprites(ref NativeArray<JobSpriteInfo> spriteInfos, Sprite[] sprites, int maxCount)
		{
		}

		private void PrepareSprites(Sprite[] edgeSprites, Sprite[] cornerSprites)
		{
		}

		private void PrepareAngleRanges(AngleRangeInfo[] angleRanges)
		{
		}

		private void PrepareControlPoints(NativeArray<ShapeControlPoint> shapePoints, NativeArray<SplinePointMetaData> metaData)
		{
		}

		private bool WithinRange(JobAngleRange angleRange, float inputAngle)
		{
			return false;
		}

		private bool AngleWithinRange(float t, float a, float b)
		{
			return false;
		}

		private static float2 BezierPoint(float2 st, float2 sp, float2 ep, float2 et, float t)
		{
			return default(float2);
		}

		private static float SlopeAngle(float2 dirNormalized)
		{
			return 0f;
		}

		private static float SlopeAngle(float2 start, float2 end)
		{
			return 0f;
		}

		private bool ResolveAngle(float angle, int activeIndex, ref float renderOrder, ref int spriteIndex, ref int firstSpriteIndex)
		{
			return false;
		}

		private int GetSpriteIndex(int index, int previousIndex, ref int resolved)
		{
			return 0;
		}

		private void GenerateSegments()
		{
		}

		private void UpdateSegments()
		{
		}

		private bool GetSegmentBoundaryColumn(JobSegmentInfo segment, JobSpriteInfo sprInfo, float2 whsize, float2 startPos, float2 endPos, bool end, ref float2 top, ref float2 bottom)
		{
			return false;
		}

		private void GenerateControlPoints()
		{
		}

		private float SegmentDistance(JobSegmentInfo isi)
		{
			return 0f;
		}

		private void GenerateContour()
		{
		}

		private bool PrepareContour()
		{
			return false;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(UTessellator_0000017F_0024PostfixBurstDelegate))]
		private unsafe static void UTessellator(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Allocator label)
		{
		}

		private bool TessellateContour(Allocator label)
		{
			return false;
		}

		private void TessellateContourMainThread()
		{
		}

		private void CalculateBoundingBox()
		{
		}

		private void CalculateTexCoords()
		{
		}

		private void CopyVertexData(ref NativeSlice<Vector3> outPos, ref NativeSlice<Vector2> outUV0, ref NativeSlice<Vector4> outTan, int outIndex, ref Array<JobShapeVertex> inVertices, int inIndex, float sOrder)
		{
		}

		private int CopySegmentRenderData(JobSpriteInfo ispr, ref NativeSlice<Vector3> outPos, ref NativeSlice<Vector2> outUV0, ref NativeSlice<Vector4> outTan, ref int outCount, ref NativeArray<ushort> indexData, ref int indexCount, ref Array<JobShapeVertex> inVertices, int inCount, float sOrder)
		{
			return 0;
		}

		private void GetLineSegments(JobSpriteInfo sprInfo, JobSegmentInfo segment, float2 whsize, ref float2 vlt, ref float2 vlb, ref float2 vrt, ref float2 vrb)
		{
		}

		private void TessellateSegment(int segmentIndex, JobSpriteInfo sprInfo, JobSegmentInfo segment, float2 whsize, float4 border, float pxlWidth, ref Array<JobShapeVertex> vertices, int vertexCount, bool useClosure, bool validHead, bool validTail, bool firstSegment, bool finalSegment, ref Array<JobShapeVertex> outputVertices, ref int outputCount)
		{
		}

		private bool SkipSegment(JobSegmentInfo isi)
		{
			return false;
		}

		private float InterpolateLinear(float a, float b, float t)
		{
			return 0f;
		}

		private float InterpolateSmooth(float a, float b, float t)
		{
			return 0f;
		}

		private bool AddVertex(ref Array<JobShapeVertex> array, ref int indexCount, JobShapeVertex vertex)
		{
			return false;
		}

		private void TessellateSegments()
		{
		}

		private bool FetchStretcher(int segmentIndex, JobSpriteInfo sprInfo, JobSegmentInfo segment, float2 whsize, bool validHead, bool validTail, ref float4 stretcher)
		{
			return false;
		}

		private void StretchCorners(JobSegmentInfo segment, ref Array<JobShapeVertex> vertices, int vertexCount, bool validHead, bool validTail, float4 stretcher)
		{
		}

		private void ExtendSegment(ref float2 l0, ref float2 r0)
		{
		}

		private bool GetIntersection(int cp, int ct, JobSpriteInfo ispr, ref float2 lt0, ref float2 lb0, ref float2 rt0, ref float2 rb0, ref float2 lt1, ref float2 lb1, ref float2 rt1, ref float2 rb1, ref float2 tp, ref float2 bt)
		{
			return false;
		}

		private bool AttachCorner(int cp, int ct, JobSpriteInfo ispr, ref NativeArray<JobControlPoint> newPoints, ref int activePoint)
		{
			return false;
		}

		private float2 CornerTextureCoordinate(int cornerType, int index)
		{
			return default(float2);
		}

		private int CalculateCorner(int index, float angle, float2 lt, float2 rt)
		{
			return 0;
		}

		private bool InsertCorner(int index, ref NativeArray<int2> cpSpriteIndices, ref NativeArray<JobControlPoint> newPoints, ref int activePoint, ref bool cornerConsidered)
		{
			return false;
		}

		private void TessellateCorners()
		{
		}

		private bool AreCollinear(float2 a, float2 b, float2 c, float t)
		{
			return false;
		}

		private void OptimizePoints(float tolerance, bool tess, ref NativeArray<float2> pointSet, ref int pointCount)
		{
		}

		private void AttachCornerToCollider(JobSegmentInfo isi, float pivot, ref NativeArray<float2> points, ref int pointCount)
		{
		}

		private float2 UpdateExtraGeometry(JobSegmentInfo isi, JobSpriteInfo ispr, ref Array<JobShapeVertex> vertices, int count, ref NativeArray<float2> points, ref int pointCount, float _pivot)
		{
			return default(float2);
		}

		private static void TrimOverlaps(int cpCount, bool _isCarpet, int _splineDetail, float _kEpsilon, float _kEpsilonRelaxed, ref NativeArray<float2> _colliderPoints, ref int colliderPointCount)
		{
		}

		private void OptimizeCollider()
		{
		}

		private void OptimizeShadow()
		{
		}

		[Obsolete]
		public void Prepare(SpriteShapeController controller, SpriteShapeParameters shapeParams, int maxArrayCount, NativeArray<ShapeControlPoint> shapePoints, NativeArray<SpriteShapeMetaData> metaData, AngleRangeInfo[] angleRanges, Sprite[] segmentSprites, Sprite[] cornerSprites)
		{
		}

		internal void Prepare(SpriteShapeController controller, SpriteShapeParameters shapeParams, int maxArrayCount, NativeArray<ShapeControlPoint> shapePoints, NativeArray<SplinePointMetaData> metaData, AngleRangeInfo[] angleRanges, Sprite[] segmentSprites, Sprite[] cornerSprites, bool UseUTess)
		{
		}

		public void Execute()
		{
		}

		public void Cleanup()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal unsafe static void UTessellator_0024BurstManaged(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, ushort* indices, ref int iCount, byte* vertices, int stride, ref int vCount, Allocator label)
		{
		}
	}
}
