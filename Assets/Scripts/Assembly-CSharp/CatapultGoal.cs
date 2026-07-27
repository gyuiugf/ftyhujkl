using System;

// Token: 0x02000008 RID: 8
public class CatapultGoal : GoalObject
{
	// Token: 0x0600003E RID: 62 RVA: 0x00003F9C File Offset: 0x0000219C
	public override void Restart()
	{
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00007410 File Offset: 0x00005610
	private void OnEnable()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Unmanaged memory load: [v40 @ X8_v5+B8]");
				object obj3 = (IntPtr)0;
				if (obj3 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float num = this.catapultIntensity;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00007508 File Offset: 0x00005708
	private void OnDisable()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v24 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v36 @ X0_v7+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				object obj4;
				bool flag3 = obj4 == 0;
				Console.WriteLine("Unmanaged memory load: [v28 @ X8_v3+128]");
				bool flag4 = (IntPtr)0 == this;
				if (!flag3)
				{
					return;
				}
				Console.WriteLine("Unmanaged memory load: [v91 @ X8_v5+B8]");
				object obj5 = (IntPtr)0;
				if (obj5 != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000076AC File Offset: 0x000058AC
	public void OnCatapult()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (CatapultGoal)+21]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Indirect call: 8 IndirectCall [v4 @ X8_v1+1C8] (should have been resolved before IL gen)");
		}
	}

	// Token: 0x04000032 RID: 50
	public float catapultIntensity;
}
