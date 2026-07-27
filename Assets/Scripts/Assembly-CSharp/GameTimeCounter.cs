using System;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class GameTimeCounter : MonoBehaviour
{
	// Token: 0x0600009F RID: 159 RVA: 0x0000FCCC File Offset: 0x0000DECC
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AD68]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0000FD64 File Offset: 0x0000DF64
	public float GetTotalMinutes()
	{
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		float result;
		return result;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000FD80 File Offset: 0x0000DF80
	private void Start()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B240]");
		object key = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		float @float = PlayerPrefs.GetFloat(key);
		Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCVT not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction SMADDL not yet implemented.");
		double num;
		this.sessionMinutes = num;
		object obj2;
		object obj = 26215L + obj2;
		object obj3 = obj + obj;
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		int num2 = obj3 + 5L;
		this.storeTimer = this.storePeriod;
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		this.nextMilestone = num2;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000FE98 File Offset: 0x0000E098
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		float deltaTime = Time.deltaTime;
		Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCVT not yet implemented.");
		object obj;
		double num = this.sessionMinutes + obj;
		this.sessionMinutes = num;
		float deltaTime2 = Time.deltaTime;
		object obj2;
		float num2 = this.storeTimer - obj2;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		this.storeTimer = num2;
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x040000AC RID: 172
	public static GameTimeCounter instance;

	// Token: 0x040000AD RID: 173
	public double sessionMinutes;

	// Token: 0x040000AE RID: 174
	private float storePeriod;

	// Token: 0x040000AF RID: 175
	private float storeTimer;

	// Token: 0x040000B0 RID: 176
	public int nextMilestone;
}
