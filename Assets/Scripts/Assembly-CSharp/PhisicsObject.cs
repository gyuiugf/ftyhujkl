using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class PhisicsObject : ObstacleObject
{
	// Token: 0x0600014C RID: 332 RVA: 0x0001AEC0 File Offset: 0x000190C0
	public override void Restart()
	{
		bool flag = ~this.set;
		if (!flag)
		{
			goto IL_1DE;
		}
		Transform transform = base.transform;
		if (transform != 0)
		{
			Vector3 position = transform.position;
			Vector3 vector;
			this.pos = vector;
			Transform transform2 = base.transform;
			if (transform2 != 0)
			{
				Vector3 eulerAngles = transform2.eulerAngles;
				float num;
				this.rot = num;
				this.set = (1L != 0L);
				goto IL_1DE;
			}
		}
		IL_1D4:
		Console.WriteLine("Method not found @24D67E8");
		IL_1DE:
		Transform transform3 = base.transform;
		if (transform3 == 0)
		{
			goto IL_1D4;
		}
		Vector3 vector2;
		transform3.position = vector2;
		Transform transform4 = base.transform;
		if (transform4 == 0)
		{
			goto IL_1D4;
		}
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		transform4.eulerAngles = vector2;
		Console.WriteLine("Unmanaged memory load: [559212F]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		if (this.rb == 0)
		{
			goto IL_1D4;
		}
		this.rb.linearVelocity = vector2;
		if (this.rb != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			float angularVelocity;
			this.rb.angularVelocity = angularVelocity;
			return;
		}
		goto IL_1D4;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0000401B File Offset: 0x0000221B
	private void Start()
	{
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0000401D File Offset: 0x0000221D
	private void Update()
	{
	}

	// Token: 0x04000170 RID: 368
	public Vector3 pos;

	// Token: 0x04000171 RID: 369
	public float rot;

	// Token: 0x04000172 RID: 370
	public Rigidbody2D rb;

	// Token: 0x04000173 RID: 371
	private bool set;
}
