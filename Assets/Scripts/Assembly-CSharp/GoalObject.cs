using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class GoalObject : MonoBehaviour
{
	// Token: 0x06000100 RID: 256 RVA: 0x00003FFD File Offset: 0x000021FD
	public virtual void Restart()
	{
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00015DB4 File Offset: 0x00013FB4
	public virtual void OnPickUp()
	{
		if (!(~this.hasTrigger))
		{
			return;
		}
		this.started = (1L != 0L);
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00015DEC File Offset: 0x00013FEC
	public virtual void OnTrigger()
	{
		this.started = (1L != 0L);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00015E08 File Offset: 0x00014008
	public virtual void OnFail()
	{
		bool flag;
		this.started = flag;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00015E20 File Offset: 0x00014020
	public virtual void OnSolved()
	{
		bool flag;
		this.started = flag;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00015E38 File Offset: 0x00014038
	public virtual void OnGoal()
	{
		object obj2;
		object obj = obj2 - 224L;
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
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj11;
		for (;;)
		{
			this.goalReached = (1L != 0L);
			if (this.triggedObstacles != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B0A8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B0B0]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B150]");
				object obj5 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj6 = (IntPtr)0;
				List<object>.Enumerator enumerator = this.triggedObstacles.GetEnumerator();
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+18]");
				IntPtr intPtr = (IntPtr)0;
				object obj7 = obj + 96L;
				for (;;)
				{
					bool flag = obj3 == 0;
					List<object>.Enumerator enumerator2 = obj + 96L;
					bool flag2 = enumerator2.MoveNext();
					if (!flag)
					{
						break;
					}
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+70]");
					if ((IntPtr)0 == 0)
					{
						goto IL_47D;
					}
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				}
				List<object>.Enumerator enumerator3 = obj + 96L;
				enumerator3.Dispose();
				if (this.triggedGoals == 0)
				{
					goto IL_4B9;
				}
				List<object>.Enumerator enumerator4 = this.triggedGoals.GetEnumerator();
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+18]");
				IntPtr intPtr2 = (IntPtr)0;
				object obj8 = obj + 64L;
				for (;;)
				{
					bool flag3 = obj4 == 0;
					List<object>.Enumerator enumerator5 = obj + 64L;
					bool flag4 = enumerator5.MoveNext();
					if (!flag3)
					{
						break;
					}
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+50]");
					if ((IntPtr)0 == 0)
					{
						goto IL_48C;
					}
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				}
				List<object>.Enumerator enumerator6 = obj + 64L;
				enumerator6.Dispose();
				if (this.activateOnGoal == 0)
				{
					goto IL_4B9;
				}
				List<object>.Enumerator enumerator7 = this.activateOnGoal.GetEnumerator();
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+18]");
				IntPtr intPtr3 = (IntPtr)0;
				object obj9 = obj + 32L;
				for (;;)
				{
					bool flag5 = ~(obj5 != null) != null;
					List<object>.Enumerator enumerator8 = obj + 32L;
					bool flag6 = enumerator8.MoveNext();
					if (!flag5)
					{
						break;
					}
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+30]");
					if ((IntPtr)0 == 0)
					{
						goto IL_49B;
					}
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+30]");
					((IntPtr)0).SetActive(obj5 != null);
				}
				List<object>.Enumerator enumerator9 = obj + 32L;
				enumerator9.Dispose();
				if (this.deactivateOnGoal == 0)
				{
					goto IL_4B9;
				}
				List<object>.Enumerator enumerator10 = this.deactivateOnGoal.GetEnumerator();
				Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+18]");
				IntPtr intPtr4 = (IntPtr)0;
				object obj10 = obj + 32L;
				for (;;)
				{
					bool flag7 = ~(obj5 != null) != null;
					List<object>.Enumerator enumerator11 = obj + 32L;
					bool flag8 = enumerator11.MoveNext();
					if (!flag7)
					{
						break;
					}
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+30]");
					if ((IntPtr)0 == 0)
					{
						goto IL_4AA;
					}
					Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+30]");
					((IntPtr)0).SetActive(obj5 != null);
				}
				List<object>.Enumerator enumerator12 = obj + 32L;
				enumerator12.Dispose();
				Console.WriteLine("Unmanaged memory load: [v299 @ X8_v20+B8]");
				obj11 = (IntPtr)0;
				if (obj11 != 0)
				{
					break;
				}
				goto IL_4B9;
				IL_4AA:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_4B9;
				IL_49B:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_4AA;
				IL_48C:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_49B;
				IL_47D:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_48C;
			}
			IL_4B9:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @214840C");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
		}
		obj11.OnGoalReached();
	}

	// Token: 0x04000105 RID: 261
	public bool goalReached;

	// Token: 0x04000106 RID: 262
	public bool started;

	// Token: 0x04000107 RID: 263
	public bool hasTrigger;

	// Token: 0x04000108 RID: 264
	public List<ObstacleObject> triggedObstacles;

	// Token: 0x04000109 RID: 265
	public List<GoalObject> triggedGoals;

	// Token: 0x0400010A RID: 266
	public List<GameObject> activateOnGoal;

	// Token: 0x0400010B RID: 267
	public List<GameObject> deactivateOnGoal;
}
