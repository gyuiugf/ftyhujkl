using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro.Examples
{
	// Token: 0x02000070 RID: 112
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x0003BB3C File Offset: 0x00039D3C
		private void Awake()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			bool flag;
			GameObject gameObject3;
			for (;;)
			{
				GameObject gameObject = base.gameObject;
				if (gameObject != 0)
				{
					Console.WriteLine("Method not found @292FDFC");
					this.m_TextMeshPro = gameObject;
					Console.WriteLine("Method not found @24D64EC");
					GameObject gameObject2 = base.gameObject;
					if (gameObject2 != 0)
					{
						Console.WriteLine("Method not found @29302B4");
						this.m_Canvas = gameObject2;
						Console.WriteLine("Method not found @24D64EC");
						if (this != 0)
						{
							RenderMode renderMode = base.renderMode;
							object obj;
							if (obj != 0)
							{
								if (this == 0)
								{
									goto IL_29F;
								}
								Camera worldCamera = base.worldCamera;
								this.m_Camera = worldCamera;
							}
							else
							{
								this.m_Camera = flag;
							}
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Unmanaged memory load: [523ADE0]");
							object obj2 = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [v145 @ X0_v26+E4]");
							bool flag2 = (IntPtr)0 == 0;
							if (flag2)
							{
								Console.WriteLine("Method not found @24D66BC");
							}
							Console.WriteLine("Method not found @29B33F4");
							this.m_TextPopup_RectTransform = this.TextPopup_Prefab_01;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.TMP_TextSelector_B)+18]");
							if ((IntPtr)0 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.TMP_TextSelector_B)+18]");
								Transform transform = ((IntPtr)0).transform;
								if (this != 0)
								{
									bool worldPositionStays;
									base.SetParent(transform, worldPositionStays);
									if (this != 0)
									{
										Console.WriteLine("Method not found @289425C");
										this.m_TextPopup_TMPComponent = this;
										Console.WriteLine("Method not found @24D64EC");
										Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
										if (this != 0)
										{
											gameObject3 = base.gameObject;
											if (gameObject3 != 0)
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
				IL_29F:
				Console.WriteLine("Method not found @24D67E8");
			}
			gameObject3.SetActive(flag);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0003BE6C File Offset: 0x0003A06C
		private void OnEnable()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523C068]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [523C070]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C280]");
				object method = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v25 @ X0_v10+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v37 @ X0_v12+B8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(this, method);
				Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
				if ((IntPtr)0 != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
			((IntPtr)0).Add(obj2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0003BFF0 File Offset: 0x0003A1F0
		private void OnDisable()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523C068]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [523C070]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523C280]");
				object method = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v25 @ X0_v10+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v37 @ X0_v12+B8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(this, method);
				Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
				if ((IntPtr)0 != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [v41 @ X8_v1+58]");
			((IntPtr)0).Remove(obj2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0003C174 File Offset: 0x0003A374
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			TMP_TextInfo textInfo;
			for (;;)
			{
				Console.WriteLine("Unmanaged memory load: [v27 @ X0_v4+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				object obj3;
				bool flag2 = obj3 == 0;
				bool flag3 = obj == this.m_TextMeshPro;
				if (!flag2)
				{
					return;
				}
				if (this.m_TextMeshPro != 0)
				{
					textInfo = this.m_TextMeshPro.textInfo;
					if (textInfo != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			TMP_MeshInfo[] cachedMeshInfoVertexData = textInfo.CopyMeshInfoVertexData();
			this.m_cachedMeshInfoVertexData = cachedMeshInfoVertexData;
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		private void LateUpdate()
		{
			object obj;
			bool flag = obj - 432L != null;
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
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			if (!(~this.isHoveringObject))
			{
				Console.WriteLine("Unmanaged memory load: [523BE70]");
				object obj2 = (IntPtr)0;
				Vector3 mousePosition = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v60 @ X0_v20+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Camera camera;
				int num = TMP_TextUtilities.FindIntersectingCharacter(this.m_TextMeshPro, this.m_Camera, camera, flag);
				this.RestoreCachedVertexAttributes(this.m_Camera);
				int lastIndex = (int)(~(int)0L);
				this.m_lastIndex = lastIndex;
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj3 = (IntPtr)0;
				Vector3 mousePosition2 = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v183 @ X0_v26+E4]");
				bool flag3 = (IntPtr)0 == 0;
				if (flag3)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int num2 = TMP_TextUtilities.FindIntersectingWord(this.m_TextMeshPro, this.m_Camera, flag);
				Console.WriteLine("Unmanaged memory load: [v80 @ X8_v1+E4]");
				bool flag4 = (IntPtr)0 == 0;
				if (flag4)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag5 = !flag;
				bool flag6 = this.m_TextPopup_RectTransform != flag;
				if (flag5)
				{
				}
				Vector3 mousePosition3 = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v244 @ X0_v35+E4]");
				bool flag7 = (IntPtr)0 == 0;
				if (flag7)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int num3 = TMP_TextUtilities.FindIntersectingLink(this.m_TextMeshPro, this.m_Camera, flag);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0003C668 File Offset: 0x0003A868
		public void OnPointerEnter(PointerEventData eventData)
		{
			this.isHoveringObject = (1L != 0L);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0003C684 File Offset: 0x0003A884
		public void OnPointerExit(PointerEventData eventData)
		{
			bool flag;
			this.isHoveringObject = flag;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00004096 File Offset: 0x00002296
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00004098 File Offset: 0x00002298
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0003C69C File Offset: 0x0003A89C
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0003C6EC File Offset: 0x0003A8EC
		public TMP_TextSelector_B()
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			int lastIndex = (int)(~(int)0L);
			this.m_lastIndex = lastIndex;
			int selectedWord;
			this.m_selectedWord = selectedWord;
			base..ctor();
		}

		// Token: 0x04000397 RID: 919
		public RectTransform TextPopup_Prefab_01;

		// Token: 0x04000398 RID: 920
		private RectTransform m_TextPopup_RectTransform;

		// Token: 0x04000399 RID: 921
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		// Token: 0x0400039A RID: 922
		private const string k_LinkText = "You have selected link <#ffff00>";

		// Token: 0x0400039B RID: 923
		private const string k_WordText = "Word Index: <#ffff00>";

		// Token: 0x0400039C RID: 924
		private TextMeshProUGUI m_TextMeshPro;

		// Token: 0x0400039D RID: 925
		private Canvas m_Canvas;

		// Token: 0x0400039E RID: 926
		private Camera m_Camera;

		// Token: 0x0400039F RID: 927
		private bool isHoveringObject;

		// Token: 0x040003A0 RID: 928
		private int m_selectedWord;

		// Token: 0x040003A1 RID: 929
		private int m_selectedLink;

		// Token: 0x040003A2 RID: 930
		private int m_lastIndex;

		// Token: 0x040003A3 RID: 931
		private Matrix4x4 m_matrix;

		// Token: 0x040003A4 RID: 932
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;
	}
}
