using System;
using UnityEngine;

// Token: 0x02000032 RID: 50
public class PlayerManager : MonoBehaviour
{
	// Token: 0x06000156 RID: 342 RVA: 0x00004021 File Offset: 0x00002221
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0001B56C File Offset: 0x0001976C
	public void OnLose()
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
			Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [v25 @ X9_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0 && this.rb != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float gravityScale;
		this.rb.gravityScale = gravityScale;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00004023 File Offset: 0x00002223
	public void Reset()
	{
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0000402F File Offset: 0x0000222F
	private void Awake()
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0001B654 File Offset: 0x00019854
	private void OnMouseDown()
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
			Console.WriteLine("Unmanaged memory load: [v25 @ X8_v1+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v29 @ X8_v3+1F8]");
				if ((IntPtr)0 == 0 || !(~this.lost))
				{
					break;
				}
				if (this.rb != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
					float gravityScale;
					this.rb.gravityScale = gravityScale;
					Console.WriteLine("Unmanaged memory load: [559212F]");
					bool flag2 = (IntPtr)0 == 0;
					if (flag2)
					{
						Console.WriteLine("Method not found @24D6540");
					}
					if (this.rb != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523B1A0]");
						object obj3 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v128 @ X8_v7+B8]");
						object obj4 = (IntPtr)0;
						Vector2 vector;
						this.rb.linearVelocity = vector;
						Camera main = Camera.main;
						Vector3 mousePosition = Input.mousePosition;
						if (main != 0)
						{
							Vector3 vector2 = main.ScreenToWorldPoint(vector);
							Transform transform = base.transform;
							if (transform != 0)
							{
								Vector3 position = transform.position;
								Vector3 vector3 = obj4 - obj4;
								Console.WriteLine("Unmanaged memory load: [v50 @ X8_v8+4]");
								object obj5 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [v50 @ X8_v8+4]");
								object obj6 = obj5 - (IntPtr)0;
								this.isDragging = (1L != 0L);
								GameManager gameManager;
								this.gameManager = gameManager;
								this.offset = vector3;
								if (this.gameManager != 0)
								{
									goto Block_7;
								}
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_7:
		this.gameManager.OnPickUp();
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0001B934 File Offset: 0x00019B34
	private void OnMouseUp()
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
			if (obj2 != 0 && this.rb != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float gravityScale;
		this.rb.gravityScale = gravityScale;
		bool flag2;
		this.isDragging = flag2;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0001BA1C File Offset: 0x00019C1C
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		while (!(~this.isDragging))
		{
			Camera main = Camera.main;
			Vector3 mousePosition = Input.mousePosition;
			if (main != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj = (IntPtr)0;
				Vector3 vector2;
				Vector3 vector = main.ScreenToWorldPoint(vector2);
				Console.WriteLine("Unmanaged memory load: [v148 @ X0_v13+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag2 = vector2 == 0;
				bool flag3 = this.restrictionTransform != vector2;
				if (flag2)
				{
					if (this.restrictionTransform != 0)
					{
						Vector3 position = this.restrictionTransform.position;
						if (this.restrictionTransform != 0)
						{
							Vector3 localScale = this.restrictionTransform.localScale;
							Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [523AE38]");
							object obj2 = (IntPtr)0;
							bool flag4;
							this.isDragging = flag4;
							Console.WriteLine("Unmanaged memory load: [v178 @ X8_v4+B8]");
							object obj3 = (IntPtr)0;
							if (obj3 != 0 && this.rb != 0)
							{
								float gravityScale;
								this.rb.gravityScale = gravityScale;
								return;
							}
						}
					}
				}
				else if (this.rb != 0)
				{
					this.rb.MovePosition(vector2);
					return;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x0400017B RID: 379
	public Rigidbody2D rb;

	// Token: 0x0400017C RID: 380
	public bool isDragging;

	// Token: 0x0400017D RID: 381
	public bool lost;

	// Token: 0x0400017E RID: 382
	private Vector3 offset;

	// Token: 0x0400017F RID: 383
	public GameManager gameManager;

	// Token: 0x04000180 RID: 384
	public Transform restrictionTransform;

	// Token: 0x04000181 RID: 385
	public GameObject otherBall;
}
