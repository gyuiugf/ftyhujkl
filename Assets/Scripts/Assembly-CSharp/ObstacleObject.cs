using System;
using UnityEngine;

// Token: 0x02000026 RID: 38
public class ObstacleObject : MonoBehaviour
{
	// Token: 0x060000F9 RID: 249 RVA: 0x00003FFB File Offset: 0x000021FB
	public virtual void OnPhysicsButton(bool pressed)
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00015D04 File Offset: 0x00013F04
	public virtual void Restart()
	{
		bool flag;
		this.started = flag;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00015D1C File Offset: 0x00013F1C
	public virtual void OnPickUp()
	{
		if (!(~this.hasTrigger))
		{
			return;
		}
		this.started = (1L != 0L);
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00015D54 File Offset: 0x00013F54
	public virtual void OnTrigger()
	{
		this.started = (1L != 0L);
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00015D70 File Offset: 0x00013F70
	public virtual void OnFail()
	{
		bool flag;
		this.started = flag;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00015D88 File Offset: 0x00013F88
	public virtual void OnSolved()
	{
		bool flag;
		this.started = flag;
	}

	// Token: 0x04000103 RID: 259
	public bool started;

	// Token: 0x04000104 RID: 260
	public bool hasTrigger;
}
