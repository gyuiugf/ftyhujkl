using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class BallScript : MonoBehaviour
{
	// Token: 0x06000029 RID: 41 RVA: 0x00005FAC File Offset: 0x000041AC
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		while (~this.enemyBall)
		{
			if (collision != 0)
			{
				Vector2 relativeVelocity = collision.relativeVelocity;
				Console.WriteLine("Unmanaged memory load: [5592128]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [523AD40]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v186 @ X0_v15+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
				GameObject gameObject = collision.gameObject;
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v41 @ X8_v6+E4]");
				bool flag3 = (IntPtr)0 == 0;
				if (flag3)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				object obj3;
				bool flag4 = obj3 == 0;
				bool flag5 = gameObject == this.otherBall;
				SoundManager soundManager;
				float impactForce;
				if (flag4)
				{
					if (~this.green)
					{
						return;
					}
					if (this.gameManager == 0)
					{
						goto IL_37D;
					}
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [523AE28]");
					object obj4 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v230 @ X8_v10+B8]");
					object obj5 = (IntPtr)0;
					bool flag6 = obj5 == 0;
					object obj6 = !flag6;
					soundManager = obj5;
					if (obj6 == null)
					{
						goto IL_37D;
					}
				}
				else
				{
					GameObject gameObject2 = collision.gameObject;
					if (gameObject2 == 0)
					{
						goto IL_37D;
					}
					string tag = gameObject2.tag;
					Console.WriteLine("Unmanaged memory load: [523AE30]");
					object b = (IntPtr)0;
					bool flag7 = tag == b;
					Console.WriteLine("Unmanaged memory load: [523AE28]");
					object obj7 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v247 @ X9_v4+B8]");
					object obj8 = (IntPtr)0;
					bool flag8 = obj8 == 0;
					if (flag8)
					{
						if (obj8 != 0)
						{
							obj8.PlayHoopHitSound(impactForce);
							return;
						}
						goto IL_37D;
					}
					else
					{
						bool flag9 = obj8 == 0;
						soundManager = obj8;
						if (flag9)
						{
							goto IL_37D;
						}
					}
				}
				soundManager.PlayBounceSound(impactForce);
				return;
			}
			IL_37D:
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003F90 File Offset: 0x00002190
	private void OnCollisionExit2D(Collision2D collision)
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000063A0 File Offset: 0x000045A0
	public void OnSpike()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		GameManager gameManager;
		for (;;)
		{
			if (this.col != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj = (IntPtr)0;
				bool enabled;
				this.col.enabled = enabled;
				Console.WriteLine("Unmanaged memory load: [v55 @ X0_v6+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag2 = @object == 0;
				bool flag3 = this.playerManager != @object;
				if (flag2)
				{
					if (this.playerManager == 0)
					{
						goto IL_1BF;
					}
					this.playerManager.OnLose();
				}
				if (this.popAnimation != 0)
				{
					this.popAnimation.PlayPopAnimation();
					bool flag4 = ~this.enemyBall;
					if (!flag4)
					{
						return;
					}
					gameManager = this.gameManager;
					if (this.gameManager != 0)
					{
						break;
					}
				}
			}
			IL_1BF:
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		gameManager.loseTimer = (float)13107L;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00006598 File Offset: 0x00004798
	public void OnSlice()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.col != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj = (IntPtr)0;
				bool enabled;
				this.col.enabled = enabled;
				Console.WriteLine("Unmanaged memory load: [v67 @ X0_v6+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag2 = @object == 0;
				bool flag3 = this.playerManager != @object;
				if (flag2)
				{
					if (this.playerManager == 0)
					{
						goto IL_263;
					}
					this.playerManager.OnLose();
				}
				if (this.sliceAnimation != 0)
				{
					this.sliceAnimation.PlaySliceAnimation();
					this.sliced = (1L != 0L);
					Console.WriteLine("Unmanaged memory load: [v112 @ X0_v12+E4]");
					bool flag4 = (IntPtr)0 == 0;
					if (flag4)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag5 = @object == 0;
					bool flag6 = this.trail != @object;
					if (flag5)
					{
						if (this.trail == 0)
						{
							goto IL_263;
						}
						this.trail.enabled = (@object != null);
					}
					if (~this.enemyBall)
					{
						return;
					}
					if (this.rb != 0)
					{
						break;
					}
				}
			}
			IL_263:
			Console.WriteLine("Method not found @24D67E8");
		}
		this.rb.bodyType = @object;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00006830 File Offset: 0x00004A30
	public void Restart()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.col != 0)
			{
				bool enabled;
				this.col.enabled = enabled;
				bool flag = ~this.enemyBall;
				if (flag)
				{
					Console.WriteLine("Unmanaged memory load: [523AE38]");
					object obj = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v96 @ X8_v4+B8]");
					object obj2 = (IntPtr)0;
					if (obj2 == 0 || this.rb == 0)
					{
						goto IL_27D;
					}
					float gravityScale;
					this.rb.gravityScale = gravityScale;
				}
				if (this.sliceAnimation != 0)
				{
					this.sliceAnimation.DeactivateSliceAnimation();
					if (this.popAnimation != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523ADE0]");
						object obj3 = (IntPtr)0;
						this.popAnimation.DeactivatePopAnimation();
						bool flag2;
						this.sliced = flag2;
						Console.WriteLine("Unmanaged memory load: [v114 @ X0_v12+E4]");
						bool flag3 = (IntPtr)0 == 0;
						if (flag3)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag4 = @object == 0;
						bool flag5 = this.trail != @object;
						if (flag4)
						{
							if (this.trail == 0)
							{
								goto IL_27D;
							}
							this.trail.enabled = (@object != null);
						}
						if (~this.enemyBall)
						{
							return;
						}
						if (this.rb != 0)
						{
							break;
						}
					}
				}
			}
			IL_27D:
			Console.WriteLine("Method not found @24D67E8");
		}
		this.rb.bodyType = @object;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003F92 File Offset: 0x00002192
	private void Start()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003F94 File Offset: 0x00002194
	private void Update()
	{
	}

	// Token: 0x04000018 RID: 24
	public GameObject otherBall;

	// Token: 0x04000019 RID: 25
	public Collider2D col;

	// Token: 0x0400001A RID: 26
	public Rigidbody2D rb;

	// Token: 0x0400001B RID: 27
	public PlayerManager playerManager;

	// Token: 0x0400001C RID: 28
	public GameManager gameManager;

	// Token: 0x0400001D RID: 29
	public bool green;

	// Token: 0x0400001E RID: 30
	public SliceAnimation sliceAnimation;

	// Token: 0x0400001F RID: 31
	public PopAnimation popAnimation;

	// Token: 0x04000020 RID: 32
	public bool enemyBall;

	// Token: 0x04000021 RID: 33
	public TrailRenderer trail;

	// Token: 0x04000022 RID: 34
	public bool sliced;
}
