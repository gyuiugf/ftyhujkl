using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class MovementBehaviour : ObstacleObject
{
	// Token: 0x06000135 RID: 309 RVA: 0x00019E78 File Offset: 0x00018078
	public override void Restart()
	{
		if (!(~this.resetPosition))
		{
			Transform transform = base.transform;
			if (transform != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Vector3 localPosition;
				transform.localPosition = localPosition;
				float num;
				this.timer = num;
				this.reverse = (num != null);
			}
			else
			{
				Console.WriteLine("Method not found @24D67E8");
			}
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000400F File Offset: 0x0000220F
	private void Start()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00019F10 File Offset: 0x00018110
	private void Update()
	{
		Vector3 vector;
		float z;
		vector.z = z;
		float deltaTime = Time.deltaTime;
		object obj;
		float num = this.timer + obj;
		Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
		this.timer = num;
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Transform transform;
		while (transform == 0)
		{
			for (;;)
			{
				Console.WriteLine("Method not found @24D67E8");
				transform = base.transform;
				if (!(~this.reverse))
				{
					break;
				}
				if (transform != 0)
				{
					goto Block_2;
				}
			}
			continue;
			Block_2:
			IL_BF:
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			transform.localPosition = vector;
			return;
		}
		goto IL_BF;
	}

	// Token: 0x0400014D RID: 333
	public Vector2 startPosition;

	// Token: 0x0400014E RID: 334
	public Vector2 endPosition;

	// Token: 0x0400014F RID: 335
	public float time;

	// Token: 0x04000150 RID: 336
	public float timer;

	// Token: 0x04000151 RID: 337
	public bool reverse;

	// Token: 0x04000152 RID: 338
	public bool resetPosition;
}
