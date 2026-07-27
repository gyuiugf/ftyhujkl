using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000046 RID: 70
public class ChatController : MonoBehaviour
{
	// Token: 0x060001DC RID: 476 RVA: 0x00022620 File Offset: 0x00020820
	private void OnEnable()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		TMP_InputField chatInputField;
		object obj;
		for (;;)
		{
			chatInputField = this.ChatInputField;
			if (this.ChatInputField != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B788]");
				obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B780]");
				object method = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(this, method);
				if (chatInputField.m_OnSubmit != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		chatInputField.m_OnSubmit.AddListener(obj);
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00022740 File Offset: 0x00020940
	private void OnDisable()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		TMP_InputField chatInputField;
		object obj;
		for (;;)
		{
			chatInputField = this.ChatInputField;
			if (this.ChatInputField != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B788]");
				obj = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B780]");
				object method = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor(this, method);
				if (chatInputField.m_OnSubmit != 0)
				{
					break;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		chatInputField.m_OnSubmit.RemoveListener(obj);
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00022860 File Offset: 0x00020A60
	private void AddToChatOutput(string newText)
	{
		object obj2;
		object obj = obj2 - 80L;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.ChatInputField != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AFF8]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v39 @ X23_v2+90]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v42 @ X8_v1+B8]");
				object text = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B7A0]");
				object obj5 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523B0E8]");
				object obj6 = (IntPtr)0;
				this.ChatInputField.text = text;
				Console.WriteLine("Unmanaged memory load: [v83 @ X0_v19+E4]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				DateTime now = DateTime.Now;
				Console.WriteLine("Method not found @24D662C");
				if (obj6 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v61 @ X8_v3+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523B7C0]");
						object obj7 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [523B7B8]");
						object format = (IntPtr)0;
						Console.WriteLine("Method not found @24D64EC");
						DateTime dateTime = obj + 8L;
						int hour = dateTime.Hour;
						int num = obj + 4L;
						string text2 = num.ToString(format);
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					}
					Console.WriteLine("Method not found @24D67F0");
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x040001F2 RID: 498
	public TMP_InputField ChatInputField;

	// Token: 0x040001F3 RID: 499
	public TMP_Text ChatDisplayOutput;

	// Token: 0x040001F4 RID: 500
	public Scrollbar ChatScrollbar;
}
