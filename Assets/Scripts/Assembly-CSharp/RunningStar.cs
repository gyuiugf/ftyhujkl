using System;
using UnityEngine;

// Token: 0x02000038 RID: 56
public class RunningStar : ObstacleObject
{
	// Token: 0x06000184 RID: 388 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
	public override void Restart()
	{
		object obj;
		Vector3 vector = obj - 96L;
		Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [559212E]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj3;
		Transform transform4;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [523AE20]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v26 @ X8_v3+B8]");
			obj3 = (IntPtr)0;
			Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FADDP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Transform transform = base.transform;
			if (transform != 0)
			{
				transform.position = vector;
				Transform transform2 = base.transform;
				if (transform2 != 0)
				{
					Vector3 localScale = transform2.localScale;
					if (this.ball != 0)
					{
						Vector3 localScale2 = this.ball.localScale;
						object obj4 = this.startPosition * 0.5;
						object obj5 = this.startPosition * 0.5;
						object obj6 = obj4 + obj5;
						float num = obj6 + 0.5;
						this.minDistance = num;
						float screenWidth = GameManager.GetScreenWidth();
						Transform transform3 = base.transform;
						if (transform3 != 0)
						{
							Vector3 localScale3 = transform3.localScale;
							float screenHeight = GameManager.GetScreenHeight();
							vector.x = screenHeight;
							transform4 = base.transform;
							if (transform4 != 0)
							{
								break;
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Vector3 localScale4 = transform4.localScale;
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
		this.leftEdge = obj3;
		Vector2 vector2;
		this.rightEdge = vector2;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00004045 File Offset: 0x00002245
	private void Start()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
	public bool UpdatePosition()
	{
		object obj2;
		object obj = obj2 - 112L;
		Transform transform = base.transform;
		if (transform != 0)
		{
			Vector3 position = transform.position;
			if (this.ball != 0)
			{
				Vector3 position2 = this.ball.position;
				Console.WriteLine("Unmanaged memory load: [5592130]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D6540");
					goto IL_137;
				}
				goto IL_137;
			}
		}
		IL_12D:
		Console.WriteLine("Method not found @24D67E8");
		IL_137:
		Console.WriteLine("Unmanaged memory load: [523AD40]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v109 @ X0_v10 (System.Boolean)+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		goto IL_12D;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0001E448 File Offset: 0x0001C648
	private void Update()
	{
		this.UpdatePosition();
	}

	// Token: 0x04000198 RID: 408
	public Vector3 startPosition;

	// Token: 0x04000199 RID: 409
	public float minDistance;

	// Token: 0x0400019A RID: 410
	public Transform ball;

	// Token: 0x0400019B RID: 411
	public Vector2 leftEdge;

	// Token: 0x0400019C RID: 412
	public Vector2 rightEdge;
}
