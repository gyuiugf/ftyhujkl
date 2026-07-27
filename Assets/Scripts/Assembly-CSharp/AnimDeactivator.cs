using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class AnimDeactivator : MonoBehaviour
{
	// Token: 0x0600001D RID: 29 RVA: 0x000059B8 File Offset: 0x00003BB8
	public void Deactivate()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Component component;
			if (~this.parent)
			{
				component = this;
				goto IL_1B2;
			}
			Transform transform = base.transform;
			if (transform != 0)
			{
				Transform transform2 = transform.parent;
				bool flag = transform2 == 0;
				object obj = !flag;
				component = transform2;
				if (obj != null)
				{
					goto IL_1B2;
				}
			}
			IL_18F:
			Console.WriteLine("Method not found @24D67E8");
			continue;
			IL_1B2:
			GameObject gameObject = component.gameObject;
			if (gameObject == 0)
			{
				goto IL_18F;
			}
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			bool flag2;
			gameObject.SetActive(flag2);
			Console.WriteLine("Unmanaged memory load: [v90 @ X0_v12+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag4 = !flag2;
			bool flag5 = this.spriteRenderer != flag2;
			if (!flag4)
			{
				return;
			}
			if (this.spriteRenderer != 0)
			{
				break;
			}
			goto IL_18F;
		}
		this.spriteRenderer.sprite = this.sprite;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003F88 File Offset: 0x00002188
	public void Restart()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00005BA0 File Offset: 0x00003DA0
	public void DeactivateAnimation()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ADE8]");
		object enabled = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Method not found @2894080");
			if (this != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		base.enabled = (enabled != null);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003F8A File Offset: 0x0000218A
	private void Start()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003F8C File Offset: 0x0000218C
	private void Update()
	{
	}

	// Token: 0x0400000E RID: 14
	private bool parent;

	// Token: 0x0400000F RID: 15
	private Sprite sprite;

	// Token: 0x04000010 RID: 16
	private SpriteRenderer spriteRenderer;
}
