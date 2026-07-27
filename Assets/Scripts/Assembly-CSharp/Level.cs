using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class Level : MonoBehaviour
{
	// Token: 0x06000107 RID: 263 RVA: 0x00004009 File Offset: 0x00002209
	private void Start()
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000400B File Offset: 0x0000220B
	private void Update()
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000164B4 File Offset: 0x000146B4
	public Level()
	{
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
		this.bottomBorder = (1L != 0L);
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [DBF01E]");
		this.startPosition1 = (IntPtr)0;
		this.solvedBadgeHeight = (float)52429L;
		float num;
		this.scale1 = num;
		base..ctor();
	}

	// Token: 0x0400010C RID: 268
	public string levelID;

	// Token: 0x0400010D RID: 269
	public Vector2 startPosition1;

	// Token: 0x0400010E RID: 270
	public Vector2 startPosition2;

	// Token: 0x0400010F RID: 271
	public float scale1;

	// Token: 0x04000110 RID: 272
	public float scale2;

	// Token: 0x04000111 RID: 273
	public List<GoalObject> goalObjects;

	// Token: 0x04000112 RID: 274
	public List<ObstacleObject> obstacleObjects;

	// Token: 0x04000113 RID: 275
	public List<GameObject> activateOnStart;

	// Token: 0x04000114 RID: 276
	public List<GameObject> deactivateOnStart;

	// Token: 0x04000115 RID: 277
	public Transform restrictionTransform;

	// Token: 0x04000116 RID: 278
	public GameObject tutorial;

	// Token: 0x04000117 RID: 279
	public bool leftBorder;

	// Token: 0x04000118 RID: 280
	public bool rightBorder;

	// Token: 0x04000119 RID: 281
	public bool bottomBorder;

	// Token: 0x0400011A RID: 282
	public bool topBorder;

	// Token: 0x0400011B RID: 283
	public float solvedBadgeHeight;
}
