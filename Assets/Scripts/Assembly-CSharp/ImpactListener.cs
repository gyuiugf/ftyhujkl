using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class ImpactListener : MonoBehaviour
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00012574 File Offset: 0x00010774
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (other != 0)
			{
				Vector2 relativeVelocity = other.relativeVelocity;
				Console.WriteLine("Unmanaged memory load: [5592128]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [523AD40]");
				object obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v51 @ X0_v10+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [523AE28]");
				object obj2 = (IntPtr)0;
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [v112 @ X8_v6+B8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
				if (obj3 != 0 && this.impactSound != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
					float volume;
					this.impactSound.volume = volume;
					if (this.impactSound != 0)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		this.impactSound.Play();
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00003FE9 File Offset: 0x000021E9
	private void Start()
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00003FEB File Offset: 0x000021EB
	private void Update()
	{
	}

	// Token: 0x040000E5 RID: 229
	public AudioSource impactSound;

	// Token: 0x040000E6 RID: 230
	public float minSoundIntensity;

	// Token: 0x040000E7 RID: 231
	public float maxSoundIntensity;

	// Token: 0x040000E8 RID: 232
	public float soundVolume;
}
