using System;
using System.Collections.Generic;
using TMPro;

// Token: 0x02000017 RID: 23
public class HitGoal : GoalObject
{
	// Token: 0x060000AD RID: 173 RVA: 0x00010A70 File Offset: 0x0000EC70
	public void OnHit()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (HitGoal)+21]");
		if ((IntPtr)0 != 0)
		{
			int num = this + 80L;
			int value = (int)((long)num.m_value + 1L);
			num.m_value = value;
			string text = num.ToString();
			Console.WriteLine("Unmanaged memory load: [v10 @ X0_v2 (System.Int32)+8]");
			if ((IntPtr)0 != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
			}
			else
			{
				Console.WriteLine("Method not found @24D67E8");
			}
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00010B30 File Offset: 0x0000ED30
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction STURH not yet implemented.");
		string text = base.ToString();
		Console.WriteLine("Unmanaged memory load: [this @ X0 (HitGoal)+8]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
			if (this.hitTargets != 0)
			{
				return;
			}
		}
		Console.WriteLine("Method not found @24D67E8");
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00003FC7 File Offset: 0x000021C7
	private void Start()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00003FC9 File Offset: 0x000021C9
	private void Update()
	{
	}

	// Token: 0x040000C0 RID: 192
	public List<HitTarget> hitTargets;

	// Token: 0x040000C1 RID: 193
	public int hitCount;

	// Token: 0x040000C2 RID: 194
	public int hitGoal;

	// Token: 0x040000C3 RID: 195
	public TextMeshPro hitText;
}
