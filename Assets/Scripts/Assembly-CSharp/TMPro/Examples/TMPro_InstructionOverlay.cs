using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200006A RID: 106
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		// Token: 0x060002AF RID: 687 RVA: 0x00039268 File Offset: 0x00037468
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
			for (;;)
			{
				Quaternion quaternion;
				bool flag = quaternion == 0;
				bool enabled = base.enabled;
				if (!flag)
				{
					return;
				}
				Console.WriteLine("Unmanaged memory load: [523BF70]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C108]");
				object name = (IntPtr)0;
				Camera main = Camera.main;
				this.m_camera = main;
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(name);
				if (obj != 0)
				{
					Transform transform = obj.transform;
					this.m_frameCounter_transform = transform;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.TMPro_InstructionOverlay)+8]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.TMPro_InstructionOverlay)+8]");
						Transform transform2 = ((IntPtr)0).transform;
						if (this != 0)
						{
							base.parent = transform2;
							Console.WriteLine("Unmanaged memory load: [5592203]");
							bool flag2 = (IntPtr)0 == 0;
							if (flag2)
							{
								Console.WriteLine("Method not found @24D6540");
							}
							if (this != 0)
							{
								base.localRotation = quaternion;
								Console.WriteLine("Method not found @292FD6C");
								this.m_TextMeshPro = obj;
								Console.WriteLine("Method not found @24D64EC");
								Console.WriteLine("Unmanaged memory load: [523C110]");
								object font = (IntPtr)0;
								Console.WriteLine("Method not found @2A6AE00");
								if (this != 0)
								{
									base.font = font;
									Console.WriteLine("Unmanaged memory load: [523C100]");
									object obj2 = (IntPtr)0;
									Console.WriteLine("Method not found @2A6AE00");
									if (this != 0)
									{
										Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
										if (this != 0)
										{
											float fontSize;
											base.fontSize = fontSize;
											if (this != 0)
											{
												base.isOverlay = (quaternion != null);
												Console.WriteLine("Method not found @292FDFC");
												this.m_textContainer = obj;
												Console.WriteLine("Method not found @24D64EC");
												this.Set_FrameCounter_Position(obj);
												TextMeshPro textMeshPro = this.m_TextMeshPro;
												if (this.m_TextMeshPro != 0)
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
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Indirect call: 254 IndirectCall [v52 @ X9_v7+558] (should have been resolved before IL gen)");
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0003964C File Offset: 0x0003784C
		private void Set_FrameCounter_Position(TMPro_InstructionOverlay.FpsCounterAnchorPositions anchor_position)
		{
			if (this.m_textContainer != 0)
			{
				this.m_textContainer.anchorPosition = (TextContainerAnchors)anchor_position;
				if (this.m_camera != 0)
				{
					goto IL_7B;
				}
			}
			IL_71:
			Console.WriteLine("Method not found @24D67E8");
			IL_7B:
			Vector3 position;
			Vector3 vector = this.m_camera.ViewportToWorldPoint(position);
			if (this.m_frameCounter_transform != 0)
			{
				this.m_frameCounter_transform.position = position;
				return;
			}
			goto IL_71;
		}

		// Token: 0x0400037A RID: 890
		public TMPro_InstructionOverlay.FpsCounterAnchorPositions AnchorPosition = (TMPro_InstructionOverlay.FpsCounterAnchorPositions)1L;

		// Token: 0x0400037B RID: 891
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		// Token: 0x0400037C RID: 892
		private TextMeshPro m_TextMeshPro;

		// Token: 0x0400037D RID: 893
		private TextContainer m_textContainer;

		// Token: 0x0400037E RID: 894
		private Transform m_frameCounter_transform;

		// Token: 0x0400037F RID: 895
		private Camera m_camera;

		// Token: 0x020000A7 RID: 167
		public enum FpsCounterAnchorPositions
		{
			// Token: 0x04000498 RID: 1176
			TopLeft,
			// Token: 0x04000499 RID: 1177
			BottomLeft,
			// Token: 0x0400049A RID: 1178
			TopRight,
			// Token: 0x0400049B RID: 1179
			BottomRight
		}
	}
}
