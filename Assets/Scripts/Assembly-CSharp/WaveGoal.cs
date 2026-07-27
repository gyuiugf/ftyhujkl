using System;
using TMPro;
using UnityEngine;

// Token: 0x02000057 RID: 87
public class WaveGoal : GoalObject
{
	// Token: 0x0600025D RID: 605 RVA: 0x00034238 File Offset: 0x00032438
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		GameObject gameObject;
		for (;;)
		{
			base.Restart();
			int num;
			this.waveCount = num;
			if (this.waveText != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (this.waveText != 0)
				{
					gameObject = this.waveText.gameObject;
					if (gameObject != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		gameObject.SetActive(active);
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00034330 File Offset: 0x00032530
	public void OnNextWave()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BE10]");
		object str = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		GameObject gameObject;
		for (;;)
		{
			int num = this + 72L;
			int value = (int)((long)num.m_value + 1L);
			num.m_value = value;
			string str2 = num.ToString();
			string text = str + str2;
			Console.WriteLine("Unmanaged memory load: [v27 @ X0_v5 (System.Int32)+8]");
			if ((IntPtr)0 != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
				if (this.waveText != 0)
				{
					gameObject = this.waveText.gameObject;
					if (gameObject != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		bool active;
		gameObject.SetActive(active);
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000408A File Offset: 0x0000228A
	private void Start()
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000408C File Offset: 0x0000228C
	private void Update()
	{
	}

	// Token: 0x04000306 RID: 774
	public int waveCount;

	// Token: 0x04000307 RID: 775
	public int waveGoal;

	// Token: 0x04000308 RID: 776
	public TextMeshPro waveText;
}
