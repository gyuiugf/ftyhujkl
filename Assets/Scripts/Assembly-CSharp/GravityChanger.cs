using System;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class GravityChanger : ObstacleObject
{
	// Token: 0x060000A8 RID: 168 RVA: 0x0001056C File Offset: 0x0000E76C
	public override void Restart()
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
			bool flag2;
			this.reverse = flag2;
			Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				float num = this.gravityIntensity;
				if (this.rbBall1 != 0)
				{
					float gravityScale;
					this.rbBall1.gravityScale = gravityScale;
					Console.WriteLine("Unmanaged memory load: [v75 @ X8_v5+B8]");
					object obj3 = (IntPtr)0;
					if (obj3 != 0 && this.rbBall2 != 0)
					{
						this.rbBall2.gravityScale = gravityScale;
						if (this.gravityArrow != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Vector3 eulerAngles;
		this.gravityArrow.eulerAngles = eulerAngles;
		this.timer = this.time;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00010714 File Offset: 0x0000E914
	public void InvertGravity()
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
			bool flag2 = ((this.reverse ? 1L : 0L) ^ 1L) != 0L;
			this.reverse = flag2;
			if (!(~this.reverse))
			{
				if (obj2 != 0)
				{
					float num = this.gravityIntensity;
					if (this.rbBall1 != 0)
					{
						float gravityScale;
						this.rbBall1.gravityScale = gravityScale;
						Console.WriteLine("Unmanaged memory load: [v96 @ X8_v5+B8]");
						object obj3 = (IntPtr)0;
						if (obj3 != 0 && this.rbBall2 != 0)
						{
							this.rbBall2.gravityScale = gravityScale;
							if (this.gravityArrow != 0)
							{
								break;
							}
						}
					}
				}
			}
			else if (obj2 != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction FNEG not yet implemented.");
				float num2 = this.gravityIntensity;
				if (this.rbBall1 != 0)
				{
					float gravityScale;
					this.rbBall1.gravityScale = gravityScale;
					Console.WriteLine("Unmanaged memory load: [v101 @ X8_v8+B8]");
					object obj4 = (IntPtr)0;
					if (obj4 != 0 && this.rbBall2 != 0)
					{
						this.rbBall2.gravityScale = gravityScale;
						if (this.gravityArrow != 0)
						{
							goto Block_11;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Transform transform = this.gravityArrow;
		goto IL_2B5;
		Block_11:
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		transform = this.gravityArrow;
		IL_2B5:
		Vector3 eulerAngles;
		transform.eulerAngles = eulerAngles;
		this.timer = this.time;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00003FC5 File Offset: 0x000021C5
	private void Start()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000109F0 File Offset: 0x0000EBF0
	private void Update()
	{
		if (!(~this.gravityInvertor))
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (GravityChanger)+20]");
			if ((IntPtr)0 != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			}
		}
	}

	// Token: 0x040000B8 RID: 184
	public Rigidbody2D rbBall1;

	// Token: 0x040000B9 RID: 185
	public Rigidbody2D rbBall2;

	// Token: 0x040000BA RID: 186
	public Transform gravityArrow;

	// Token: 0x040000BB RID: 187
	public bool reverse;

	// Token: 0x040000BC RID: 188
	public float timer;

	// Token: 0x040000BD RID: 189
	public float time;

	// Token: 0x040000BE RID: 190
	public bool gravityInvertor;

	// Token: 0x040000BF RID: 191
	public float gravityIntensity;
}
