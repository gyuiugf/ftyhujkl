using System;
using System.Collections.Generic;
using TMPro;

// Token: 0x0200001F RID: 31
public class HoopRun : HoopGoal
{
	// Token: 0x060000D1 RID: 209 RVA: 0x00011FEC File Offset: 0x000101EC
	public override void OnHoop()
	{
		object obj2;
		object obj = obj2 - 64L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [55920E2]");
		object obj3 = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			obj3 = 1L;
		}
		List<Hoop> list = this.hoops;
		bool flag2 = this.hoops == 0;
		object obj5;
		object obj4 = obj5;
		string text2;
		string text = text2;
		string text4;
		string text3 = text4;
		object obj7;
		object obj6 = obj7;
		object obj9;
		object obj8 = obj9;
		object obj11;
		object obj10 = obj11;
		object obj12 = 1;
		object obj13 = obj3;
		if (flag2)
		{
			goto IL_25A;
		}
		object obj15;
		object obj14 = obj15;
		Console.WriteLine("Unmanaged memory load: [v25 @ X0_v8 (System.Collections.Generic.List`1<Hoop>)+18]");
		object obj16 = obj14 - (IntPtr)0;
		object obj17 = obj5;
		string text5 = text2;
		string text6 = text4;
		object obj18 = obj15;
		Console.WriteLine("Unmanaged memory load: [523B290]");
		object obj19 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B288]");
		object obj20 = (IntPtr)0;
		object obj21 = obj16;
		Console.WriteLine("Unmanaged memory load: [v25 @ X0_v8 (System.Collections.Generic.List`1<Hoop>)+18]");
		object obj22 = (IntPtr)0;
		IL_102:
		int num = obj + 12L;
		string text7 = num.ToString();
		List<Hoop> list2 = this.hoops;
		bool flag3 = this.hoops == 0;
		object obj23 = obj17;
		string text8 = text5;
		string text9 = text6;
		object obj24 = obj22;
		if (!flag3)
		{
			int num2 = obj + 8L;
			Console.WriteLine("Unmanaged memory load: [v48 @ X8_v3 (System.Collections.Generic.List`1<Hoop>)+18]");
			IntPtr intPtr = (IntPtr)0;
			string text10 = num2.ToString();
			string text11 = text7 + obj19 + text10;
			bool flag4 = this.hoopText == 0;
			obj23 = obj;
			text8 = text10;
			text9 = text7;
			Console.WriteLine("Unmanaged memory load: [v48 @ X8_v3 (System.Collections.Generic.List`1<Hoop>)+18]");
			obj24 = (IntPtr)0;
			if (!flag4)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				return;
			}
		}
		Console.WriteLine("Method not found @24D67E8");
		obj4 = obj23;
		text = text8;
		text3 = text9;
		obj6 = obj18;
		obj8 = obj19;
		obj10 = obj20;
		obj12 = obj21;
		obj13 = obj24;
		IL_25A:
		Console.WriteLine("Method not found @24D67E8");
		obj17 = obj4;
		text5 = text;
		text6 = text3;
		obj18 = obj6;
		obj19 = obj8;
		obj20 = obj10;
		obj21 = obj12;
		obj22 = obj13;
		goto IL_102;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00012344 File Offset: 0x00010544
	public override void Restart()
	{
		object obj2;
		object obj = obj2 - 48L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		List<Hoop> list = this.hoops;
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
		if (this.hoops != 0)
		{
			int num = obj + 12L;
			Console.WriteLine("Unmanaged memory load: [523B298]");
			object str = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1 (System.Collections.Generic.List`1<Hoop>)+18]");
			IntPtr intPtr = (IntPtr)0;
			string str2 = num.ToString();
			string text = str + str2;
			if (this.hoopText != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (this.hoops != 0)
				{
					return;
				}
			}
		}
		Console.WriteLine("Method not found @24D67E8");
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x000124B8 File Offset: 0x000106B8
	public override void OnHoopFail()
	{
		Console.WriteLine("Unmanaged memory load: [523AE38]");
		object obj = (IntPtr)0;
		object obj2;
		if (obj2 == null)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj3;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v21 @ X8_v1+B8]");
			obj3 = (IntPtr)0;
			if (obj3 != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj3.OnLose();
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00003FE5 File Offset: 0x000021E5
	private void Start()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00003FE7 File Offset: 0x000021E7
	private void Update()
	{
	}

	// Token: 0x040000E2 RID: 226
	public List<Hoop> hoops;

	// Token: 0x040000E3 RID: 227
	public int hoopGoal;

	// Token: 0x040000E4 RID: 228
	public TextMeshPro hoopText;
}
