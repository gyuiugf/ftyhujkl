using System;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

// Token: 0x02000055 RID: 85
public class UpdatePriceText : MonoBehaviour
{
	// Token: 0x06000258 RID: 600 RVA: 0x00033D60 File Offset: 0x00031F60
	public void UpdatePrice()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		bool flag3;
		for (;;)
		{
			CodelessIAPStoreListener instance = CodelessIAPStoreListener.Instance;
			if (instance != 0)
			{
				Product product = instance.GetProduct(this.productIdAndroid);
				if (product != 0)
				{
					ProductMetadata <metadata>k__BackingField = product.<metadata>k__BackingField;
					if (product.<metadata>k__BackingField != 0)
					{
						string text = this.prefix + <metadata>k__BackingField.<localizedPriceString>k__BackingField;
						if (this.priceText == 0)
						{
							goto IL_2AF;
						}
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						ProductMetadata <metadata>k__BackingField2 = product.<metadata>k__BackingField;
						if (product.<metadata>k__BackingField == 0)
						{
							goto IL_2AF;
						}
						Console.WriteLine("Unmanaged memory load: [523B100]");
						object obj = (IntPtr)0;
						bool flag = obj == 0;
						bool flag2 = <metadata>k__BackingField2.<localizedPriceString>k__BackingField == obj;
						if (!flag)
						{
							return;
						}
					}
				}
				if (~this.deactivateOnFail)
				{
					return;
				}
				if (this.priceText != 0)
				{
					GameObject gameObject = this.priceText.gameObject;
					if (gameObject != 0)
					{
						gameObject.SetActive(flag3);
						Console.WriteLine("Unmanaged memory load: [523ADE0]");
						object obj2 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v160 @ X0_v18+E4]");
						bool flag4 = (IntPtr)0 == 0;
						if (flag4)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag5 = !flag3;
						bool flag6 = this.alternativeText != flag3;
						if (!flag5)
						{
							return;
						}
						if (this.alternativeText != 0)
						{
							break;
						}
					}
				}
			}
			IL_2AF:
			Console.WriteLine("Method not found @24D67E8");
		}
		this.alternativeText.SetActive(flag3);
	}

	// Token: 0x040002FD RID: 765
	public string productIdIOS;

	// Token: 0x040002FE RID: 766
	public string productIdAndroid;

	// Token: 0x040002FF RID: 767
	public string prefix;

	// Token: 0x04000300 RID: 768
	public Text priceText;

	// Token: 0x04000301 RID: 769
	public bool deactivateOnFail;

	// Token: 0x04000302 RID: 770
	public GameObject alternativeText;
}
