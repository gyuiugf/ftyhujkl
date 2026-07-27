using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x0200005B RID: 91
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000348D8 File Offset: 0x00032AD8
		// (set) Token: 0x06000269 RID: 617 RVA: 0x000348EC File Offset: 0x00032AEC
		public TMP_TextEventHandler.CharacterSelectionEvent onCharacterSelection
		{
			get
			{
				return this.m_OnCharacterSelection;
			}
			set
			{
				this.m_OnCharacterSelection = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00034910 File Offset: 0x00032B10
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00034924 File Offset: 0x00032B24
		public TMP_TextEventHandler.SpriteSelectionEvent onSpriteSelection
		{
			get
			{
				return this.m_OnSpriteSelection;
			}
			set
			{
				this.m_OnSpriteSelection = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00034948 File Offset: 0x00032B48
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0003495C File Offset: 0x00032B5C
		public TMP_TextEventHandler.WordSelectionEvent onWordSelection
		{
			get
			{
				return this.m_OnWordSelection;
			}
			set
			{
				this.m_OnWordSelection = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00034980 File Offset: 0x00032B80
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00034994 File Offset: 0x00032B94
		public TMP_TextEventHandler.LineSelectionEvent onLineSelection
		{
			get
			{
				return this.m_OnLineSelection;
			}
			set
			{
				this.m_OnLineSelection = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000349B8 File Offset: 0x00032BB8
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000349CC File Offset: 0x00032BCC
		public TMP_TextEventHandler.LinkSelectionEvent onLinkSelection
		{
			get
			{
				return this.m_OnLinkSelection;
			}
			set
			{
				this.m_OnLinkSelection = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000349F0 File Offset: 0x00032BF0
		private void Awake()
		{
			UnityEngine.Object @object;
			IntPtr cachedPtr;
			@object.m_CachedPtr = cachedPtr;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				GameObject gameObject = base.gameObject;
				if (gameObject != 0)
				{
					Console.WriteLine("Method not found @292FDFC");
					this.m_TextComponent = gameObject;
					Console.WriteLine("Method not found @24D64EC");
					if (this != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523BE60]");
						object handle = (IntPtr)0;
						Console.WriteLine("Unknown call target operand: 55 Call \"il2cpp_vm_object_is_inst\", v112 @ X0_v15 (System.Type), [this @ X0 (TMPro.TMP_TextEventHandler)]");
						Console.WriteLine("Unmanaged memory load: [523AFF8]");
						object obj = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v114 @ X8_v5+E0]");
						object obj2 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v52 @ X8_v6+E4]");
						bool flag = (IntPtr)0 == 0;
						if (flag)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						Type typeFromHandle = Type.GetTypeFromHandle(handle);
						bool flag2 = @object == 0;
						Type left;
						bool flag3 = left == typeFromHandle;
						if (!flag2)
						{
							goto IL_2CE;
						}
						GameObject gameObject2 = base.gameObject;
						if (gameObject2 != 0)
						{
							Console.WriteLine("Method not found @29302B4");
							this.m_Canvas = gameObject2;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Unmanaged memory load: [523ADE0]");
							object obj3 = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [v177 @ X0_v25+E4]");
							bool flag4 = (IntPtr)0 == 0;
							if (flag4)
							{
								Console.WriteLine("Method not found @24D66BC");
							}
							bool flag5 = @object == 0;
							bool flag6 = this != @object;
							if (!flag5)
							{
								return;
							}
							if (this != 0)
							{
								RenderMode renderMode = base.renderMode;
								object obj4;
								if (obj4 == 0)
								{
									goto IL_2F4;
								}
								if (this != 0)
								{
									break;
								}
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Camera worldCamera = base.worldCamera;
			Camera camera = worldCamera;
			goto IL_2E4;
			IL_2CE:
			Camera main = Camera.main;
			camera = main;
			IL_2E4:
			this.m_Camera = camera;
			goto IL_334;
			IL_2F4:
			this.m_Camera = @object;
			IL_334:
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00034D3C File Offset: 0x00032F3C
		private void LateUpdate()
		{
			object obj;
			Camera camera = obj - 192L;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				object obj2;
				camera = obj2;
				if (this.m_TextComponent != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
				Console.WriteLine("Method not found @24D67F0");
			}
			Console.WriteLine("Unmanaged memory load: [523BE70]");
			object obj3 = (IntPtr)0;
			RectTransform rectTransform = this.m_TextComponent.rectTransform;
			Vector3 mousePosition = Input.mousePosition;
			Console.WriteLine("Unmanaged memory load: [v54 @ X0_v11+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag2 = camera == 0;
			bool flag3 = TMP_TextUtilities.IsIntersectingRectTransform(rectTransform, this.m_Camera, camera);
			if (flag2)
			{
				Vector3 mousePosition2 = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v164 @ X0_v16+E4]");
				bool flag4 = (IntPtr)0 == 0;
				if (flag4)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int num = TMP_TextUtilities.FindIntersectingCharacter(this.m_TextComponent, this.m_Camera, camera, camera != null);
				Vector3 mousePosition3 = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v220 @ X0_v21+E4]");
				bool flag5 = (IntPtr)0 == 0;
				if (flag5)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int num2 = TMP_TextUtilities.FindIntersectingWord(this.m_TextComponent, this.m_Camera, camera);
				Vector3 mousePosition4 = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v254 @ X0_v26+E4]");
				bool flag6 = (IntPtr)0 == 0;
				if (flag6)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int num3 = TMP_TextUtilities.FindIntersectingLine(this.m_TextComponent, this.m_Camera, camera);
				Vector3 mousePosition5 = Input.mousePosition;
				Console.WriteLine("Unmanaged memory load: [v285 @ X0_v31+E4]");
				bool flag7 = (IntPtr)0 == 0;
				if (flag7)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int num4 = TMP_TextUtilities.FindIntersectingLink(this.m_TextComponent, this.m_Camera, camera);
			}
			else
			{
				int num5 = (int)(~(int)0L);
				this.m_selectedLink = num5;
				this.m_lastWordIndex = num5;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000408E File Offset: 0x0000228E
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004090 File Offset: 0x00002290
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000350E4 File Offset: 0x000332E4
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			if (this.m_OnCharacterSelection != 0)
			{
				this.m_OnCharacterSelection.Invoke(character, characterIndex);
				return;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00035180 File Offset: 0x00033380
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			if (this.m_OnSpriteSelection != 0)
			{
				this.m_OnSpriteSelection.Invoke(character, characterIndex);
				return;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0003521C File Offset: 0x0003341C
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			if (this.m_OnWordSelection != 0)
			{
				Console.WriteLine("Method not found @31D5358");
				return;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000352B4 File Offset: 0x000334B4
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			if (this.m_OnLineSelection != 0)
			{
				Console.WriteLine("Method not found @31D5358");
				return;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0003534C File Offset: 0x0003354C
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			if (this.m_OnLinkSelection != 0)
			{
				this.m_OnLinkSelection.Invoke(linkID, linkText, linkIndex);
				return;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000353F0 File Offset: 0x000335F0
		public TMP_TextEventHandler()
		{
			Console.WriteLine("Unmanaged memory load: [523BE90]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BE98]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BEA0]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BEA8]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BEB0]");
			object obj5 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			this.m_OnCharacterSelection = obj;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj2..ctor();
			this.m_OnSpriteSelection = obj2;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor();
			this.m_OnWordSelection = obj3;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj4..ctor();
			this.m_OnLineSelection = obj4;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj5..ctor();
			this.m_OnLinkSelection = obj5;
			Console.WriteLine("Method not found @24D64EC");
			int num = (int)(~(int)0L);
			this.m_selectedLink = num;
			this.m_lastWordIndex = num;
			base..ctor();
		}

		// Token: 0x04000309 RID: 777
		private TMP_TextEventHandler.CharacterSelectionEvent m_OnCharacterSelection;

		// Token: 0x0400030A RID: 778
		private TMP_TextEventHandler.SpriteSelectionEvent m_OnSpriteSelection;

		// Token: 0x0400030B RID: 779
		private TMP_TextEventHandler.WordSelectionEvent m_OnWordSelection;

		// Token: 0x0400030C RID: 780
		private TMP_TextEventHandler.LineSelectionEvent m_OnLineSelection;

		// Token: 0x0400030D RID: 781
		private TMP_TextEventHandler.LinkSelectionEvent m_OnLinkSelection;

		// Token: 0x0400030E RID: 782
		private TMP_Text m_TextComponent;

		// Token: 0x0400030F RID: 783
		private Camera m_Camera;

		// Token: 0x04000310 RID: 784
		private Canvas m_Canvas;

		// Token: 0x04000311 RID: 785
		private int m_selectedLink;

		// Token: 0x04000312 RID: 786
		private int m_lastCharIndex;

		// Token: 0x04000313 RID: 787
		private int m_lastWordIndex;

		// Token: 0x04000314 RID: 788
		private int m_lastLineIndex;

		// Token: 0x02000096 RID: 150
		[Serializable]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			// Token: 0x060003A3 RID: 931 RVA: 0x00044AF8 File Offset: 0x00042CF8
			public CharacterSelectionEvent()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				base..ctor();
			}
		}

		// Token: 0x02000097 RID: 151
		[Serializable]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			// Token: 0x060003A4 RID: 932 RVA: 0x00044B60 File Offset: 0x00042D60
			public SpriteSelectionEvent()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				base..ctor();
			}
		}

		// Token: 0x02000098 RID: 152
		[Serializable]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x060003A5 RID: 933 RVA: 0x00044BC8 File Offset: 0x00042DC8
			public WordSelectionEvent()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Method not found @31D4FD8");
			}
		}

		// Token: 0x02000099 RID: 153
		[Serializable]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x060003A6 RID: 934 RVA: 0x00044C34 File Offset: 0x00042E34
			public LineSelectionEvent()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Method not found @31D4FD8");
			}
		}

		// Token: 0x0200009A RID: 154
		[Serializable]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			// Token: 0x060003A7 RID: 935 RVA: 0x00044CA0 File Offset: 0x00042EA0
			public LinkSelectionEvent()
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				base..ctor();
			}
		}
	}
}
