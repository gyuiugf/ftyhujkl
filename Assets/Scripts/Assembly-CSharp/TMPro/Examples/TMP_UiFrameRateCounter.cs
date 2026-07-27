using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000071 RID: 113
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0003C72C File Offset: 0x0003A92C
		private void Awake()
		{
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
				Console.WriteLine("Method not found @24D6540");
			}
			bool flag2;
			for (;;)
			{
				bool flag = !flag2;
				bool enabled = base.enabled;
				if (!flag)
				{
					return;
				}
				Console.WriteLine("Unmanaged memory load: [523B130]");
				object obj = (IntPtr)0;
				int targetFrameRate = obj;
				Console.WriteLine("Unmanaged memory load: [523BF70]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C108]");
				object name = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v39 @ X0_v23 (System.Int32)+E4]");
				bool flag3 = (IntPtr)0 == 0;
				if (flag3)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Application.targetFrameRate = targetFrameRate;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(name);
				if (obj2 != 0)
				{
					Console.WriteLine("Method not found @292FD6C");
					this.m_frameCounter_transform = obj2;
					Console.WriteLine("Method not found @24D64EC");
					Transform transform = base.transform;
					if (this != 0)
					{
						base.SetParent(transform, flag2);
						Console.WriteLine("Method not found @292FD6C");
						this.m_TextMeshPro = obj2;
						Console.WriteLine("Method not found @24D64EC");
						Console.WriteLine("Unmanaged memory load: [523C110]");
						object font = (IntPtr)0;
						Console.WriteLine("Method not found @2A6AE00");
						if (this != 0)
						{
							base.font = font;
							Console.WriteLine("Unmanaged memory load: [523C100]");
							object textWrappingMode = (IntPtr)0;
							Console.WriteLine("Method not found @2A6AE00");
							if (this != 0)
							{
								Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
								if (this != 0)
								{
									base.textWrappingMode = textWrappingMode;
									if (this != 0)
									{
										float fontSize;
										base.fontSize = fontSize;
										if (this != 0)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			base.isOverlay = flag2;
			this.Set_FrameCounter_Position(flag2 ? TMP_UiFrameRateCounter.FpsCounterAnchorPositions.BottomLeft : TMP_UiFrameRateCounter.FpsCounterAnchorPositions.TopLeft);
			this.last_AnchorPosition = this.AnchorPosition;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0003CA6C File Offset: 0x0003AC6C
		private void Start()
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			int frames;
			this.m_Frames = frames;
			float lastInterval;
			this.m_LastInterval = lastInterval;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
		private void Update()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			this.last_AnchorPosition = this.AnchorPosition;
			int frames = (int)((long)this.m_Frames + 1L);
			this.m_Frames = frames;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0003CB80 File Offset: 0x0003AD80
		private void Set_FrameCounter_Position(TMP_UiFrameRateCounter.FpsCounterAnchorPositions anchor_position)
		{
			Vector2 vector;
			if (this.m_TextMeshPro != 0)
			{
				this.m_TextMeshPro.alignment = (TextAlignmentOptions)anchor_position;
				if (this.m_frameCounter_transform != 0)
				{
					this.m_frameCounter_transform.pivot = vector;
					if (this.m_frameCounter_transform != 0)
					{
						this.m_frameCounter_transform.anchorMin = vector;
						if (this.m_frameCounter_transform != 0)
						{
							this.m_frameCounter_transform.anchorMax = vector;
							if (this.m_frameCounter_transform != 0)
							{
								goto IL_FF;
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
			IL_FF:
			this.m_frameCounter_transform.anchoredPosition = vector;
		}

		// Token: 0x040003A5 RID: 933
		public float UpdateInterval = 5f;

		// Token: 0x040003A6 RID: 934
		private float m_LastInterval;

		// Token: 0x040003A7 RID: 935
		private int m_Frames;

		// Token: 0x040003A8 RID: 936
		public TMP_UiFrameRateCounter.FpsCounterAnchorPositions AnchorPosition = (TMP_UiFrameRateCounter.FpsCounterAnchorPositions)2L;

		// Token: 0x040003A9 RID: 937
		private string htmlColorTag;

		// Token: 0x040003AA RID: 938
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		// Token: 0x040003AB RID: 939
		private TextMeshProUGUI m_TextMeshPro;

		// Token: 0x040003AC RID: 940
		private RectTransform m_frameCounter_transform;

		// Token: 0x040003AD RID: 941
		private TMP_UiFrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;

		// Token: 0x020000AA RID: 170
		public enum FpsCounterAnchorPositions
		{
			// Token: 0x040004A5 RID: 1189
			TopLeft,
			// Token: 0x040004A6 RID: 1190
			BottomLeft,
			// Token: 0x040004A7 RID: 1191
			TopRight,
			// Token: 0x040004A8 RID: 1192
			BottomRight
		}
	}
}
