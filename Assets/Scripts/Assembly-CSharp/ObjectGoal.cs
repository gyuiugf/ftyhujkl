using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
public class ObjectGoal : GoalObject
{
	// Token: 0x06000143 RID: 323 RVA: 0x0001AA94 File Offset: 0x00018C94
	public bool IsRectInsideRect()
	{
		Transform[] array = this.targetPoints;
		bool position2;
		if (this.targetPoints != 0)
		{
			Console.WriteLine("Unmanaged memory load: [v4 @ X8_v1 (UnityEngine.Transform[])+18]");
			if ((IntPtr)0 == 0)
			{
				goto IL_139;
			}
			Console.WriteLine("Unmanaged memory load: [v4 @ X8_v1 (UnityEngine.Transform[])+20]");
			if ((IntPtr)0 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v4 @ X8_v1 (UnityEngine.Transform[])+20]");
				Vector3 position = ((IntPtr)0).position;
				Transform[] array2 = this.goalPoints;
				if (this.goalPoints != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v28 @ X8_v3 (UnityEngine.Transform[])+18]");
					if ((IntPtr)0 == 0)
					{
						goto IL_139;
					}
					Console.WriteLine("Unmanaged memory load: [v28 @ X8_v3 (UnityEngine.Transform[])+20]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v28 @ X8_v3 (UnityEngine.Transform[])+20]");
						position2 = (((IntPtr)0).position != null);
						Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					}
				}
			}
		}
		Console.WriteLine("Method not found @24D67E8");
		IL_139:
		Console.WriteLine("Method not found @24D67F0");
		return position2;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00004015 File Offset: 0x00002215
	private void Start()
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0001ABF4 File Offset: 0x00018DF4
	private void Update()
	{
		Console.WriteLine("Unmanaged memory load: [this @ X0 (ObjectGoal)+21]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (ObjectGoal)+20]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				bool flag2 = this == 0;
				bool flag3 = this.IsRectInsideRect();
				if (flag2)
				{
					float deltaTime = Time.deltaTime;
					object obj;
					float num = this.goalTimer + obj;
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					this.goalTimer = num;
				}
				else
				{
					float num2;
					this.goalTimer = num2;
				}
			}
		}
	}

	// Token: 0x04000167 RID: 359
	public Transform[] goalPoints;

	// Token: 0x04000168 RID: 360
	public Transform[] targetPoints;

	// Token: 0x04000169 RID: 361
	public float goalTime;

	// Token: 0x0400016A RID: 362
	public float goalTimer;
}
