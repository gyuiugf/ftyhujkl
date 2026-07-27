using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200006B RID: 107
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x0003972C File Offset: 0x0003792C
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
			RectTransform rectTransform;
			for (;;)
			{
				TMP_ExampleScript_01 text;
				GameObject gameObject2;
				if (this.ObjectType != TMP_ExampleScript_01.objectType.TextMeshPro)
				{
					Console.WriteLine("Method not found @2894080");
					bool flag = this == 0;
					object obj = !flag;
					text = this;
					if (obj != null)
					{
						goto IL_2FD;
					}
					GameObject gameObject = base.gameObject;
					if (gameObject != 0)
					{
						gameObject2 = gameObject;
						goto IL_34A;
					}
				}
				else
				{
					Console.WriteLine("Method not found @2894080");
					bool flag2 = this == 0;
					object obj2 = !flag2;
					text = this;
					if (obj2 != null)
					{
						goto IL_2FD;
					}
					GameObject gameObject3 = base.gameObject;
					if (gameObject3 != 0)
					{
						gameObject2 = gameObject3;
						goto IL_34A;
					}
				}
				IL_2D4:
				Console.WriteLine("Method not found @24D67E8");
				continue;
				IL_2FD:
				this.m_text = text;
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Unmanaged memory load: [523C138]");
				object font = (IntPtr)0;
				Console.WriteLine("Method not found @2A6AE00");
				if (this.m_text == 0)
				{
					goto IL_2D4;
				}
				Console.WriteLine("Unmanaged memory load: [523C130]");
				object obj3 = (IntPtr)0;
				this.m_text.font = font;
				Console.WriteLine("Method not found @2A6AE00");
				if (this.m_text == 0)
				{
					goto IL_2D4;
				}
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (this.m_text == 0)
				{
					goto IL_2D4;
				}
				float num;
				this.m_text.fontSize = num;
				if (this.m_text == 0)
				{
					goto IL_2D4;
				}
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (this.m_text == 0)
				{
					goto IL_2D4;
				}
				float height;
				Vector2 preferredValues = this.m_text.GetPreferredValues(num, height);
				if (this.m_text == 0)
				{
					goto IL_2D4;
				}
				rectTransform = this.m_text.rectTransform;
				if (rectTransform != 0)
				{
					break;
				}
				goto IL_2D4;
				IL_34A:
				Console.WriteLine("Method not found @292FD6C");
				text = gameObject2;
				goto IL_2FD;
			}
			Vector2 sizeDelta;
			rectTransform.sizeDelta = sizeDelta;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00039A9C File Offset: 0x00037C9C
		private void Update()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				bool flag = ~this.isStatic;
				if (!flag)
				{
					return;
				}
				if (this.m_text != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SMADDL not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SBFM not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MSUB not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523C140]");
			object sourceText = (IntPtr)0;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			float arg;
			this.m_text.SetText(sourceText, arg);
			int num = (int)((long)this.count + 1L);
			this.count = num;
		}

		// Token: 0x04000380 RID: 896
		public TMP_ExampleScript_01.objectType ObjectType;

		// Token: 0x04000381 RID: 897
		public bool isStatic;

		// Token: 0x04000382 RID: 898
		private TMP_Text m_text;

		// Token: 0x04000383 RID: 899
		private const string k_label = "The count is <#0080ff>{0}</color>";

		// Token: 0x04000384 RID: 900
		private int count;

		// Token: 0x020000A8 RID: 168
		public enum objectType
		{
			// Token: 0x0400049D RID: 1181
			TextMeshPro,
			// Token: 0x0400049E RID: 1182
			TextMeshProUGUI
		}
	}
}
