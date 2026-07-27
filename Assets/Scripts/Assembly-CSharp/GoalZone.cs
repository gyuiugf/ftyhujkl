using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000014 RID: 20
public class GoalZone : GoalObject
{
	// Token: 0x060000A4 RID: 164 RVA: 0x0000FF9C File Offset: 0x0000E19C
	public override void Restart()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ADE0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj2;
		Transform transform;
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
			this.timer = this.goalTime;
			Console.WriteLine("Unmanaged memory load: [v23 @ X0_v4+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag3 = @object == 0;
			bool time_ = this.timerText != @object;
			if (!flag3)
			{
				goto IL_1E7;
			}
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			string text = GameManager.ReturnTimeTextMilliseconds(time_ ? 1L : 0L);
			if (this.timerText != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				goto IL_1E7;
			}
			IL_18F:
			Console.WriteLine("Method not found @24D67E8");
			continue;
			IL_1E7:
			if (this.fillImage == 0)
			{
				goto IL_18F;
			}
			obj2 = this.goalTime - this.timer;
			Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
			float fillAmount;
			this.fillImage.fillAmount = fillAmount;
			transform = base.transform;
			if (transform != 0)
			{
				break;
			}
			goto IL_18F;
		}
		Vector3 localScale = transform.localScale;
		float num = obj2 * 0.5;
		this.radius = num;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00003FC3 File Offset: 0x000021C3
	private void Start()
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000101B0 File Offset: 0x0000E3B0
	private void Update()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [this @ X0 (GoalZone)+21]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (GoalZone)+20]");
			if ((IntPtr)0 == 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v78 @ X8_v4+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v82 @ X8_v6+28]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v82 @ X8_v6+28]");
						Vector3 position = ((IntPtr)0).position;
						Transform transform = base.transform;
						if (transform != 0)
						{
							Vector3 position2 = transform.position;
							Console.WriteLine("Unmanaged memory load: [5592130]");
							bool flag = (IntPtr)0 == 0;
							if (flag)
							{
								Console.WriteLine("Method not found @24D6540");
								goto IL_323;
							}
							goto IL_323;
						}
					}
				}
				IL_319:
				Console.WriteLine("Method not found @24D67E8");
				IL_323:
				Console.WriteLine("Unmanaged memory load: [523AD40]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v187 @ X0_v15+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				if (this.fillImage == 0)
				{
					goto IL_319;
				}
				Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
				float fillAmount;
				this.fillImage.fillAmount = fillAmount;
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v206 @ X0_v17+E4]");
				bool flag3 = (IntPtr)0 == 0;
				if (flag3)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag4 = @object == 0;
				bool time_ = this.timerText != @object;
				if (flag4)
				{
					TextMeshPro textMeshPro = this.timerText;
					Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					string text = GameManager.ReturnTimeTextMilliseconds(time_ ? 1L : 0L);
					if (this.timerText != 0)
					{
						Console.WriteLine("Indirect call: 292 IndirectCall [v141 @ X8_v12+558] (should have been resolved before IL gen)");
						goto IL_319;
					}
					goto IL_319;
				}
			}
		}
	}

	// Token: 0x040000B1 RID: 177
	public SpriteRenderer spriteRenderer;

	// Token: 0x040000B2 RID: 178
	public float timer;

	// Token: 0x040000B3 RID: 179
	public TextMeshPro timerText;

	// Token: 0x040000B4 RID: 180
	public float goalTime;

	// Token: 0x040000B5 RID: 181
	public Image fillImage;

	// Token: 0x040000B6 RID: 182
	public float radius;
}
