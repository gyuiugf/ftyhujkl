using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000056 RID: 86
public class VelocityTracker : MonoBehaviour
{
	// Token: 0x0600025A RID: 602 RVA: 0x00004088 File Offset: 0x00002288
	private void Start()
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00034060 File Offset: 0x00032260
	private void Update()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		while (this.rb == 0)
		{
			Console.WriteLine("Method not found @24D67E8");
		}
		Vector2 linearVelocity = this.rb.linearVelocity;
		Console.WriteLine("Unmanaged memory load: [559212F]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0003417C File Offset: 0x0003237C
	public VelocityTracker()
	{
		Console.WriteLine("Unmanaged memory load: [523BDF8]");
		object obj = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		int capacity;
		obj..ctor(capacity);
		this.lastVelocities = obj;
		Console.WriteLine("Method not found @24D64EC");
		base..ctor();
	}

	// Token: 0x04000303 RID: 771
	public List<Vector3> lastVelocities;

	// Token: 0x04000304 RID: 772
	public int framesCounter;

	// Token: 0x04000305 RID: 773
	public Rigidbody2D rb;
}
