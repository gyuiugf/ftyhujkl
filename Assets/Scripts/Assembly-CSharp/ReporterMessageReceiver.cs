using System;
using UnityEngine;

// Token: 0x02000052 RID: 82
public class ReporterMessageReceiver : MonoBehaviour
{
	// Token: 0x06000249 RID: 585 RVA: 0x00032BC4 File Offset: 0x00030DC4
	private void Start()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		GameObject gameObject;
		for (;;)
		{
			gameObject = base.gameObject;
			if (gameObject != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Method not found @292FDFC");
		this.reporter = gameObject;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00032C74 File Offset: 0x00030E74
	private void OnPreStart()
	{
		UnityEngine.Object @object;
		IntPtr cachedPtr;
		@object.m_CachedPtr = cachedPtr;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523ADE0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			object obj2 = this + 32L;
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v8+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag3 = @object == 0;
			bool flag4 = obj2 == @object;
			if (!flag3)
			{
				goto IL_115;
			}
			GameObject gameObject = base.gameObject;
			if (gameObject != 0)
			{
				Console.WriteLine("Method not found @292FDFC");
				obj2 = gameObject;
				Console.WriteLine("Method not found @24D64EC");
				goto IL_115;
			}
			IL_160:
			Console.WriteLine("Method not found @24D67E8");
			continue;
			IL_115:
			int width = Screen.width;
			if (obj2 != 0 && obj2 != 0)
			{
				break;
			}
			goto IL_160;
		}
		Console.WriteLine("Unmanaged memory load: [523BD18]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00004082 File Offset: 0x00002282
	private void OnHideReporter()
	{
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00004084 File Offset: 0x00002284
	private void OnShowReporter()
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00004086 File Offset: 0x00002286
	private void OnLog(Reporter.Log log)
	{
	}

	// Token: 0x040002ED RID: 749
	private Reporter reporter;
}
