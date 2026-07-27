using System;
using TMPro;
using UnityEngine;

// Token: 0x02000042 RID: 66
public class SpinSpeedGoal : GoalObject
{
	// Token: 0x060001CB RID: 459 RVA: 0x00021D1C File Offset: 0x0001FF1C
	public override void Restart()
	{
		base.Restart();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00021D30 File Offset: 0x0001FF30
	private void Update()
	{
		object obj2;
		object obj = obj2 - 48L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.targetRigidbody != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B748]");
				object format = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B740]");
				object str = (IntPtr)0;
				float angularVelocity = this.targetRigidbody.angularVelocity;
				float num = obj + 12L;
				Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FABS not yet implemented.");
				string str2 = num.ToString(format);
				string text = str2 + str;
				if (this.speedText != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
	}

	// Token: 0x040001E7 RID: 487
	public Rigidbody2D targetRigidbody;

	// Token: 0x040001E8 RID: 488
	public TextMeshPro speedText;

	// Token: 0x040001E9 RID: 489
	public float speedGoal;
}
