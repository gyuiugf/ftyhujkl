using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
public class TimeGoalAC : TimeGoal
{
	// Token: 0x060001EA RID: 490 RVA: 0x0000406D File Offset: 0x0000226D
	private void Start()
	{
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00023120 File Offset: 0x00021320
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523AD40]");
			object obj = (IntPtr)0;
			long time_;
			object obj10;
			if (!(~this.onlyAir))
			{
				if (this.ball1 != 0)
				{
					Vector3 position = this.ball1.position;
					if (this.ball2 != 0)
					{
						Vector3 position2 = this.ball2.position;
						Console.WriteLine("Unmanaged memory load: [5592130]");
						bool flag = (IntPtr)0 == 0;
						if (flag)
						{
							Console.WriteLine("Method not found @24D6540");
						}
						Console.WriteLine("Unmanaged memory load: [v228 @ X0_v12+E4]");
						bool flag2 = (IntPtr)0 == 0;
						if (flag2)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						object obj3;
						object obj2 = obj3 - obj3;
						object obj5;
						object obj4 = obj5 - obj5;
						object obj6 = obj4 * obj4;
						object obj7 = obj2 * obj2;
						object obj8 = obj6 + obj7;
						Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
						Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
						if (~this.resetIfNot)
						{
							return;
						}
						Console.WriteLine("Unmanaged memory load: [this @ X0 (TimeGoalAC)+48]");
						object obj9 = (IntPtr)0;
						string text = GameManager.ReturnTimeTextMilliseconds(time_);
						Console.WriteLine("Unmanaged memory load: [this @ X0 (TimeGoalAC)+48]");
						if ((IntPtr)0 != 0)
						{
							Console.WriteLine("Indirect call: 205 IndirectCall [v128 @ X8_v2+558] (should have been resolved before IL gen)");
							obj10 = obj8;
							Console.WriteLine("Unmanaged memory load: [v0 @ X31 (System.Int64)+38]");
							TimeGoalAC timeGoalAC = (IntPtr)0;
							goto IL_4BE;
						}
					}
				}
			}
			else
			{
				bool flag3 = ~this.onlyConnected;
				object obj5;
				obj10 = obj5;
				if (flag3)
				{
					goto IL_4BE;
				}
				if (this.ball1 != 0)
				{
					Vector3 position3 = this.ball1.position;
					if (this.ball2 != 0)
					{
						Vector3 position4 = this.ball2.position;
						Console.WriteLine("Unmanaged memory load: [5592130]");
						bool flag4 = (IntPtr)0 == 0;
						if (flag4)
						{
							Console.WriteLine("Method not found @24D6540");
						}
						Console.WriteLine("Unmanaged memory load: [v144 @ X0_v23+E4]");
						bool flag5 = (IntPtr)0 == 0;
						if (flag5)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						object obj3;
						object obj11 = obj3 - obj3;
						object obj12 = obj5 - obj5;
						object obj13 = obj12 * obj12;
						object obj14 = obj11 * obj11;
						object obj15 = obj13 + obj14;
						Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
						Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
						obj10 = obj15;
						goto IL_4BE;
					}
				}
			}
			IL_46D:
			Console.WriteLine("Method not found @24D67E8");
			continue;
			IL_4BE:
			Console.WriteLine("Unmanaged memory load: [v115 @ X19_v5 (TimeGoalAC)+21]");
			if ((IntPtr)0 == 0)
			{
				return;
			}
			Console.WriteLine("Unmanaged memory load: [v115 @ X19_v5 (TimeGoalAC)+20]");
			bool flag6 = (IntPtr)0 == 0;
			if (!flag6)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			Console.WriteLine("Unmanaged memory load: [v115 @ X19_v5 (TimeGoalAC)+50]");
			object obj16 = (IntPtr)0 + obj10;
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			string text2 = GameManager.ReturnTimeTextMilliseconds(time_);
			Console.WriteLine("Unmanaged memory load: [v115 @ X19_v5 (TimeGoalAC)+48]");
			if ((IntPtr)0 != 0)
			{
				break;
			}
			goto IL_46D;
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v115 @ X19_v5 (TimeGoalAC)+58]");
		bool flag7 = (IntPtr)0 == 0;
		if (flag7)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x04000200 RID: 512
	public Transform ball1;

	// Token: 0x04000201 RID: 513
	public Transform ball2;

	// Token: 0x04000202 RID: 514
	public bool onlyAir;

	// Token: 0x04000203 RID: 515
	public bool onlyConnected;

	// Token: 0x04000204 RID: 516
	public bool resetIfNot;

	// Token: 0x04000205 RID: 517
	public float criteria;
}
