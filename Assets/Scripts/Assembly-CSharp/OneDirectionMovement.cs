using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class OneDirectionMovement : ObstacleObject
{
	// Token: 0x06000147 RID: 327 RVA: 0x0001ACE8 File Offset: 0x00018EE8
	public override void Restart()
	{
		Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [559212E]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Transform transform;
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FADDP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			bool flag2 = this.playOnStart;
			this.startTimer = this.startTime;
			transform = base.transform;
			if (transform != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Vector3 position;
		transform.position = position;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00004017 File Offset: 0x00002217
	public override void OnSolved()
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00004019 File Offset: 0x00002219
	private void Start()
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0001ADE4 File Offset: 0x00018FE4
	private void Update()
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Transform transform;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (OneDirectionMovement)+20]");
			if ((IntPtr)0 == 0)
			{
				return;
			}
			transform = base.transform;
			if (transform != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Vector3 position = transform.position;
		float deltaTime = Time.deltaTime;
		Vector3 position2;
		transform.position = position2;
	}

	// Token: 0x0400016B RID: 363
	public Vector3 startPosition;

	// Token: 0x0400016C RID: 364
	public Vector3 movementVector;

	// Token: 0x0400016D RID: 365
	public bool playOnStart;

	// Token: 0x0400016E RID: 366
	public float startTimer;

	// Token: 0x0400016F RID: 367
	public float startTime;
}
