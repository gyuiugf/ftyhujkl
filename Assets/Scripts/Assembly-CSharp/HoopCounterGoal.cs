using System;
using System.Collections.Generic;
using TMPro;

// Token: 0x0200001C RID: 28
public class HoopCounterGoal : HoopGoal
{
	// Token: 0x060000C3 RID: 195 RVA: 0x00011C3C File Offset: 0x0000FE3C
	public override void OnHoop()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (HoopCounterGoal)+21]");
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

	// Token: 0x060000C4 RID: 196 RVA: 0x00011CFC File Offset: 0x0000FEFC
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction STURH not yet implemented.");
		string text = base.ToString();
		Console.WriteLine("Unmanaged memory load: [this @ X0 (HoopCounterGoal)+8]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
			if (this.hoops != 0)
			{
				return;
			}
		}
		Console.WriteLine("Method not found @24D67E8");
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00003FD5 File Offset: 0x000021D5
	private void Start()
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00003FD7 File Offset: 0x000021D7
	private void Update()
	{
	}

	// Token: 0x040000DC RID: 220
	public List<Hoop> hoops;

	// Token: 0x040000DD RID: 221
	public int hoopCount;

	// Token: 0x040000DE RID: 222
	public int hoopGoal;

	// Token: 0x040000DF RID: 223
	public TextMeshPro hoopText;
}
