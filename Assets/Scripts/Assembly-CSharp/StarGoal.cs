using System;
using System.Collections.Generic;

// Token: 0x02000045 RID: 69
public class StarGoal : GoalObject
{
	// Token: 0x060001D7 RID: 471 RVA: 0x0002248C File Offset: 0x0002068C
	public void OnCollected()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [this @ X0 (StarGoal)+21]");
		if ((IntPtr)0 != 0)
		{
			if (this.stars == 0)
			{
				Console.WriteLine("Method not found @24D67E8");
			}
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00022560 File Offset: 0x00020760
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		base.Restart();
		if (this.stars == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00004067 File Offset: 0x00002267
	private void Start()
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00004069 File Offset: 0x00002269
	private void Update()
	{
	}

	// Token: 0x040001F0 RID: 496
	public List<Star> stars;

	// Token: 0x040001F1 RID: 497
	public int starsGoal;
}
