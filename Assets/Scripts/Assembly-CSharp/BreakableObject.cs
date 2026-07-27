using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class BreakableObject : ObstacleObject
{
	// Token: 0x06000038 RID: 56 RVA: 0x00006F18 File Offset: 0x00005118
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		int num;
		object obj;
		for (;;)
		{
			GameObject gameObject = base.gameObject;
			if (gameObject != 0)
			{
				bool flag;
				gameObject.SetActive(flag);
				this.collisionCounter = num;
				if (this.sprites != 0)
				{
					obj = this.sprites.get_Item(flag ? 1 : 0);
					if (this.spriteRenderer != 0)
					{
						this.spriteRenderer.sprite = obj;
						if (this.col != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.col.enabled = (obj != null);
		this.broken = (num != 0);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000705C File Offset: 0x0000525C
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		while (other == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		Vector2 relativeVelocity = other.relativeVelocity;
		Console.WriteLine("Unmanaged memory load: [5592128]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523AD40]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v60 @ X0_v10+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000071D8 File Offset: 0x000053D8
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object sprite;
		for (;;)
		{
			int num = this.collisionStep + this.collisionCounter;
			this.collisionCounter = num;
			if (this.sprites != 0)
			{
				sprite = this.sprites.get_Item(other);
				if (this.spriteRenderer != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.spriteRenderer.sprite = sprite;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003F9A File Offset: 0x0000219A
	private void Start()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000072C0 File Offset: 0x000054C0
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		if (!(~this.broken))
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00007358 File Offset: 0x00005558
	public BreakableObject()
	{
		Console.WriteLine("Unmanaged memory load: [523AE50]");
		object obj = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this.sprites = obj;
		Console.WriteLine("Method not found @24D64EC");
		base..ctor();
	}

	// Token: 0x04000028 RID: 40
	public SpriteRenderer spriteRenderer;

	// Token: 0x04000029 RID: 41
	public int collisionCounter;

	// Token: 0x0400002A RID: 42
	public int collisionStep;

	// Token: 0x0400002B RID: 43
	public int breakPoint;

	// Token: 0x0400002C RID: 44
	public List<Sprite> sprites;

	// Token: 0x0400002D RID: 45
	public Collider2D col;

	// Token: 0x0400002E RID: 46
	public bool broken;

	// Token: 0x0400002F RID: 47
	public int frameCounter;

	// Token: 0x04000030 RID: 48
	public float frameTimer;

	// Token: 0x04000031 RID: 49
	public float frameTime;
}
