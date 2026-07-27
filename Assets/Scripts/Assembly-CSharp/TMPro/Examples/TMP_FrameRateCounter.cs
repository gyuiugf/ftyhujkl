using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200006C RID: 108
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00039BDC File Offset: 0x00037DDC
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
			}
			Quaternion quaternion;
			for (;;)
			{
				bool flag = quaternion == 0;
				bool enabled = base.enabled;
				if (!flag)
				{
					return;
				}
				Console.WriteLine("Unmanaged memory load: [523B130]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523BF70]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C108]");
				object name = (IntPtr)0;
				Camera main = Camera.main;
				this.m_camera = main;
				Console.WriteLine("Method not found @24D64EC");
				int targetFrameRate = obj;
				Console.WriteLine("Unmanaged memory load: [v136 @ X0_v24 (System.Int32)+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Application.targetFrameRate = targetFrameRate;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(name);
				if (obj2 != 0)
				{
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
						object obj3 = (IntPtr)0;
						Console.WriteLine("Method not found @2A6AE00");
						if (this != 0)
						{
							Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
							Transform transform = obj2.transform;
							this.m_frameCounter_transform = transform;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.TMP_FrameRateCounter)+8]");
							if ((IntPtr)0 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.TMP_FrameRateCounter)+8]");
								Transform transform2 = ((IntPtr)0).transform;
								if (this != 0)
								{
									base.SetParent(transform2);
									Console.WriteLine("Unmanaged memory load: [5592203]");
									bool flag3 = (IntPtr)0 == 0;
									if (flag3)
									{
										Console.WriteLine("Method not found @24D6540");
									}
									if (this != 0)
									{
										base.localRotation = quaternion;
										if (this != 0)
										{
											base.textWrappingMode = quaternion;
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
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			float fontSize;
			base.fontSize = fontSize;
			this.Set_FrameCounter_Position(quaternion);
			this.last_AnchorPosition = this.AnchorPosition;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00039FC0 File Offset: 0x000381C0
		private void Start()
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			int frames;
			this.m_Frames = frames;
			float lastInterval;
			this.m_LastInterval = lastInterval;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00039FF4 File Offset: 0x000381F4
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

		// Token: 0x060002B8 RID: 696 RVA: 0x0003A0D4 File Offset: 0x000382D4
		private void Set_FrameCounter_Position(TMP_FrameRateCounter.FpsCounterAnchorPositions anchor_position)
		{
			TextMeshPro textMeshPro = this.m_TextMeshPro;
			Vector2 vector;
			if (this.m_TextMeshPro != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (this.m_TextMeshPro != 0)
				{
					TMP_Text textMeshPro2 = this.m_TextMeshPro;
					Console.WriteLine("Unmanaged memory load: [v10 @ X8_v2+5E0]");
					textMeshPro2.alignment = (TextAlignmentOptions)((IntPtr)0);
					if (this.m_TextMeshPro != 0)
					{
						RectTransform rectTransform = this.m_TextMeshPro.rectTransform;
						if (rectTransform != 0)
						{
							rectTransform.pivot = vector;
							if (this.m_camera != 0)
							{
								goto IL_11B;
							}
						}
					}
				}
			}
			IL_111:
			Console.WriteLine("Method not found @24D67E8");
			IL_11B:
			Vector3 vector2 = this.m_camera.ViewportToWorldPoint(vector);
			if (this.m_frameCounter_transform != 0)
			{
				this.m_frameCounter_transform.position = vector;
				return;
			}
			goto IL_111;
		}

		// Token: 0x04000385 RID: 901
		public float UpdateInterval = 5f;

		// Token: 0x04000386 RID: 902
		private float m_LastInterval;

		// Token: 0x04000387 RID: 903
		private int m_Frames;

		// Token: 0x04000388 RID: 904
		public TMP_FrameRateCounter.FpsCounterAnchorPositions AnchorPosition = (TMP_FrameRateCounter.FpsCounterAnchorPositions)2L;

		// Token: 0x04000389 RID: 905
		private string htmlColorTag;

		// Token: 0x0400038A RID: 906
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		// Token: 0x0400038B RID: 907
		private TextMeshPro m_TextMeshPro;

		// Token: 0x0400038C RID: 908
		private Transform m_frameCounter_transform;

		// Token: 0x0400038D RID: 909
		private Camera m_camera;

		// Token: 0x0400038E RID: 910
		private TMP_FrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;

		// Token: 0x020000A9 RID: 169
		public enum FpsCounterAnchorPositions
		{
			// Token: 0x040004A0 RID: 1184
			TopLeft,
			// Token: 0x040004A1 RID: 1185
			BottomLeft,
			// Token: 0x040004A2 RID: 1186
			TopRight,
			// Token: 0x040004A3 RID: 1187
			BottomRight
		}
	}
}
