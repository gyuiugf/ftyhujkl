using System;
using TMPro;
using UnityEngine;

// Token: 0x02000047 RID: 71
public class DropdownSample : MonoBehaviour
{
	// Token: 0x060001E0 RID: 480 RVA: 0x00022B30 File Offset: 0x00020D30
	public void OnButtonClick()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (this.dropdownWithPlaceholder != 0)
			{
				if (this.text != 0)
				{
					TMP_Dropdown tmp_Dropdown = this.dropdownWithoutPlaceholder;
					if (this.dropdownWithoutPlaceholder != 0)
					{
						object obj;
						int num = obj + 12L;
						int value = tmp_Dropdown.m_Value;
						string str = num.ToString();
						TMP_Dropdown tmp_Dropdown2 = this.dropdownWithPlaceholder;
						if (this.dropdownWithPlaceholder != 0)
						{
							Console.WriteLine("Unmanaged memory load: [523B7C8]");
							object str2 = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [523B7D0]");
							object str3 = (IntPtr)0;
							int num2 = obj + 12L;
							int value2 = tmp_Dropdown2.m_Value;
							string str4 = num2.ToString();
							string text = str2 + str + str3 + str4;
							if (this.text != 0)
							{
								break;
							}
						}
					}
				}
				else
				{
					bool flag = this.text == 0;
					if (!flag)
					{
						break;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
	}

	// Token: 0x040001F5 RID: 501
	private TextMeshProUGUI text;

	// Token: 0x040001F6 RID: 502
	private TMP_Dropdown dropdownWithoutPlaceholder;

	// Token: 0x040001F7 RID: 503
	private TMP_Dropdown dropdownWithPlaceholder;
}
