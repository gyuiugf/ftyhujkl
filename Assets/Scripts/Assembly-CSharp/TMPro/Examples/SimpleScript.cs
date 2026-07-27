using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000064 RID: 100
	public class SimpleScript : MonoBehaviour
	{
		// Token: 0x06000293 RID: 659 RVA: 0x00037A78 File Offset: 0x00035C78
		private void Start()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			TextAlignmentOptions textAlignmentOptions;
			for (;;)
			{
				GameObject gameObject = base.gameObject;
				if (gameObject != 0)
				{
					Console.WriteLine("Method not found @292FD6C");
					this.m_textMeshPro = gameObject;
					Console.WriteLine("Method not found @24D64EC");
					if (this != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						if (this != 0)
						{
							float fontSize;
							base.fontSize = fontSize;
							if (this != 0)
							{
								base.alignment = textAlignmentOptions;
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
			base.textWrappingMode = (TextWrappingModes)textAlignmentOptions;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00037BB8 File Offset: 0x00035DB8
		private void Update()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			while (this.m_textMeshPro == 0)
			{
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C018]");
			object sourceText = (IntPtr)0;
			Console.WriteLine("Method not found @4F265F0");
			float arg;
			this.m_textMeshPro.SetText(sourceText, arg);
			float deltaTime = Time.deltaTime;
			float frame = this.m_frame + this.m_frame;
			this.m_frame = frame;
		}

		// Token: 0x0400035D RID: 861
		private TextMeshPro m_textMeshPro;

		// Token: 0x0400035E RID: 862
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		// Token: 0x0400035F RID: 863
		private float m_frame;
	}
}
