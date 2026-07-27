using System;
using System.Collections.Generic;

// Token: 0x02000004 RID: 4
public class AttackGenerator : ObstacleObject
{
	// Token: 0x06000023 RID: 35 RVA: 0x00005C60 File Offset: 0x00003E60
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		int num;
		this.waveIndex = num;
		this.attackTimer = this.startTime;
		if (this.enemies == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00005D20 File Offset: 0x00003F20
	public AttackWave GetNextWave()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		AttackWave result;
		for (;;)
		{
			if (this.waves != 0)
			{
				int index;
				result = this.waves.get_Item(index);
				List<AttackWave> list = this.waves;
				if (this.waves != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction SDIV not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MSUB not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v40 @ X8_v4 (System.Collections.Generic.List`1<AttackWave>)+18]");
		this.waveIndex = (int)((IntPtr)0);
		return result;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00005E1C File Offset: 0x0000401C
	public EnemyScript GetActiveEnemy()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		if (this.enemies == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		EnemyScript result;
		return result;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003F8E File Offset: 0x0000218E
	private void Start()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00005EC4 File Offset: 0x000040C4
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [this @ X0 (AttackGenerator)+20]");
		if ((IntPtr)0 != 0)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		}
	}

	// Token: 0x04000011 RID: 17
	public List<AttackWave> waves;

	// Token: 0x04000012 RID: 18
	public int waveIndex;

	// Token: 0x04000013 RID: 19
	public float attackTimer;

	// Token: 0x04000014 RID: 20
	public float startTime = 2f;

	// Token: 0x04000015 RID: 21
	public float attackTempo;

	// Token: 0x04000016 RID: 22
	public List<EnemyScript> enemies;

	// Token: 0x04000017 RID: 23
	public WaveGoal waveGoal;
}
