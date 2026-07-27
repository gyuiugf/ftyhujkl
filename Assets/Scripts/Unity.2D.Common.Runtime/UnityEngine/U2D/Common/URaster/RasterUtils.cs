using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Common.URaster
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct RasterUtils
	{
		internal unsafe static Color32* GetPixelOffsetBuffer(int offset, Color32* pixels)
		{
			return null;
		}

		internal unsafe static Color32 GetPixel(Color32* pixels, ref int2 textureCfg, int x, int y)
		{
			return default(Color32);
		}

		internal static byte Color32ToByte(Color32 rgba)
		{
			return 0;
		}

		internal static Color32 ByteToColor32(byte rgba)
		{
			return default(Color32);
		}

		internal static float Min3(float a, float b, float c)
		{
			return 0f;
		}

		internal static float Max3(float a, float b, float c)
		{
			return 0f;
		}

		internal static int Orient2d(float2 a, float2 b, float2 c)
		{
			return 0;
		}

		internal static bool IsValidColorByte(byte c)
		{
			return false;
		}

		internal unsafe static byte Pixelate(ref Pixels pixelMask, ref int2 textureCfg, Color32* pixels, byte fillColorByte, int sx, int sy, int x, int y)
		{
			return 0;
		}

		internal static void Pad(ref Pixels pixelMask, byte srcColorByte, byte tgtColorByte, int dx, int dy, int padx, int pady)
		{
		}

		internal unsafe static void RasterizeTriangle(ref Pixels pixelMask, Color32* pixels, ref int2 textureCfg, byte fillColorByte, ref float2 v0, ref float2 v1, ref float2 v2, int padx, int pady)
		{
		}

		internal unsafe static bool Rasterize(Color32* pixels, ref int2 textureCfg, Vector2* vertices, int vertexCount, int* indices, int indexCount, ref Pixels pixelMask, int padx, int pady)
		{
			return false;
		}

		internal static void SaveImage(NativeArray<byte> image, int w, int h, string path)
		{
		}
	}
}
