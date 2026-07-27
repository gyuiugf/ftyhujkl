using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro.Examples
{
	// Token: 0x0200005F RID: 95
	public class Benchmark03 : MonoBehaviour
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00004092 File Offset: 0x00002292
		private void Awake()
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00035884 File Offset: 0x00033A84
		private void Start()
		{
			object obj2;
			object obj = obj2 - 128L;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Shader shader;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [523BF90]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v48 @ X0_v18+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				obj = obj;
				int samplingPointSize;
				int atlasPadding;
				GlyphRenderMode renderMode;
				int atlasWidth;
				int atlasHeight;
				AtlasPopulationMode atlasPopulationMode;
				bool enableMultiAtlasSupport;
				TMP_FontAsset tmp_FontAsset = TMP_FontAsset.CreateFontAsset(this.SourceFont, samplingPointSize, atlasPadding, renderMode, atlasWidth, atlasHeight, atlasPopulationMode, enableMultiAtlasSupport);
				if (tmp_FontAsset != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523BF98]");
					object name = (IntPtr)0;
					shader = Shader.Find(name);
					Console.WriteLine("Unmanaged memory load: [v72 @ X0_v20 (TMPro.TMP_FontAsset)+88]");
					if ((IntPtr)0 != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [v72 @ X0_v20 (TMPro.TMP_FontAsset)+88]");
			((IntPtr)0).shader = shader;
		}

		// Token: 0x0400032D RID: 813
		public int NumberOfSamples = (int)100L;

		// Token: 0x0400032E RID: 814
		public Benchmark03.BenchmarkType Benchmark;

		// Token: 0x0400032F RID: 815
		public Font SourceFont;

		// Token: 0x0200009D RID: 157
		public enum BenchmarkType
		{
			// Token: 0x0400045A RID: 1114
			TMP_SDF_MOBILE,
			// Token: 0x0400045B RID: 1115
			TMP_SDF__MOBILE_SSD,
			// Token: 0x0400045C RID: 1116
			TMP_SDF,
			// Token: 0x0400045D RID: 1117
			TMP_BITMAP_MOBILE,
			// Token: 0x0400045E RID: 1118
			TEXTMESH_BITMAP
		}
	}
}
