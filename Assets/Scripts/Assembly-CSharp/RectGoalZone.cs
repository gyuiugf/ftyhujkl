using System;
using UnityEngine;

// Token: 0x02000035 RID: 53
public class RectGoalZone : GoalZone
{
	// Token: 0x06000177 RID: 375 RVA: 0x0000403B File Offset: 0x0000223B
	private void Start()
	{
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0001DAFC File Offset: 0x0001BCFC
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [this @ X0 (RectGoalZone)+21]");
			if ((IntPtr)0 == 0)
			{
				break;
			}
			Console.WriteLine("Unmanaged memory load: [this @ X0 (RectGoalZone)+20]");
			if ((IntPtr)0 != 0)
			{
				break;
			}
			Console.WriteLine("Unmanaged memory load: [523AE38]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v40 @ X8_v2+B8]");
			object obj2 = (IntPtr)0;
			if (obj2 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v44 @ X8_v4+28]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v44 @ X8_v4+28]");
					Vector3 position = ((IntPtr)0).position;
					Transform transform = base.transform;
					if (transform != 0)
					{
						Vector3 position2 = transform.position;
						Transform transform2 = base.transform;
						if (transform2 != 0)
						{
							Console.WriteLine("Not implemented instruction: Instruction FABD not yet implemented.");
							Vector3 localScale = transform2.localScale;
							Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
							Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [this @ X0 (RectGoalZone)+68]");
							if ((IntPtr)0 != 0)
							{
								goto Block_7;
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_7:
		Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [this @ X0 (RectGoalZone)+68]");
		float fillAmount;
		((IntPtr)0).fillAmount = fillAmount;
	}
}
