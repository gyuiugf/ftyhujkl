using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000062 RID: 98
	public class ObjectSpin : MonoBehaviour
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00037430 File Offset: 0x00035630
		private void Awake()
		{
			object obj;
			Vector3 vector = obj - 48L;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				vector.x = vector;
				vector.z = vector;
				Transform transform = base.transform;
				this.m_transform = transform;
				Console.WriteLine("Method not found @24D64EC");
				if (this != 0)
				{
					Quaternion rotation = base.rotation;
					ref Quaternion rotation2 = vector + 0L;
					float num;
					vector.x = num;
					float num2;
					vector.z = num2;
					float num3;
					vector.z = num3;
					Vector3 vector2 = Quaternion.Internal_ToEulerRad(ref rotation2);
					Vector3 vector3 = num;
					Console.WriteLine("Unmanaged memory load: [DBDEA0]");
					Vector3 vector4 = vector3 * (IntPtr)0;
					object obj2 = num2;
					Console.WriteLine("Unmanaged memory load: [DBDEA0]");
					object obj3 = obj2 * (IntPtr)0;
					object obj4 = num3;
					Console.WriteLine("Unmanaged memory load: [DBDEA0]");
					object obj5 = obj4 * (IntPtr)0;
					Vector3 vector5 = Quaternion.Internal_MakePositive(vector);
					this.m_initial_Rotation = vector4;
					if (this.m_transform != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523ADE0]");
						object obj6 = (IntPtr)0;
						Vector3 position = this.m_transform.position;
						this.m_initial_Position = vector4;
						Console.WriteLine("Method not found @2894080");
						Console.WriteLine("Unmanaged memory load: [v63 @ X8_v3+E4]");
						bool flag = (IntPtr)0 == 0;
						if (flag)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag2 = vector == 0;
						bool flag3 = this != vector;
						if (!flag2)
						{
							goto IL_236;
						}
						if (this != 0)
						{
							break;
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Color color = base.color;
			goto IL_2B5;
			IL_236:
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			IL_2B5:
			Console.WriteLine("Method not found @25FCA0C");
			Color32 lightColor;
			this.m_lightColor = lightColor;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00037708 File Offset: 0x00035908
		private void Update()
		{
			object obj;
			Vector3 position = obj - 80L;
			float deltaTime = Time.deltaTime;
			object obj3;
			object obj2 = this.TranslationSpeed * obj3;
			float time = this.m_time + obj2;
			this.m_time = time;
			if (this.m_transform != 0)
			{
				Console.WriteLine("Method not found @4F265E0");
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+3C]");
				object obj4 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.ObjectSpin)+28]");
				object obj5 = obj4 * (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+3C]");
				object obj6 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.ObjectSpin)+2C]");
				object obj7 = obj6 * (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+38]");
				object obj8 = (IntPtr)0 * this.TranslationDistance;
				Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Vector3)+38]");
				object obj9 = (IntPtr)0 * obj5;
				Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.ObjectSpin)+6C]");
				object obj10 = (IntPtr)0 + obj9;
				Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.ObjectSpin)+68]");
				object obj11 = (IntPtr)0 + obj7;
				Vector3 prevPOS = this.m_initial_Position + obj8;
				this.m_transform.position = position;
				if (this.m_transform != 0)
				{
					Vector3 position2 = this.m_transform.position;
					this.m_prevPOS = prevPOS;
					return;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000378A4 File Offset: 0x00035AA4
		public ObjectSpin()
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [DBE00B]");
			this.TranslationDistance = (IntPtr)0;
			this.SpinSpeed = 5f;
			base..ctor();
		}

		// Token: 0x0400034E RID: 846
		public ObjectSpin.MotionType Motion;

		// Token: 0x0400034F RID: 847
		public Vector3 TranslationDistance;

		// Token: 0x04000350 RID: 848
		public float TranslationSpeed;

		// Token: 0x04000351 RID: 849
		public float SpinSpeed;

		// Token: 0x04000352 RID: 850
		public int RotationRange;

		// Token: 0x04000353 RID: 851
		private Transform m_transform;

		// Token: 0x04000354 RID: 852
		private float m_time;

		// Token: 0x04000355 RID: 853
		private Vector3 m_prevPOS;

		// Token: 0x04000356 RID: 854
		private Vector3 m_initial_Rotation;

		// Token: 0x04000357 RID: 855
		private Vector3 m_initial_Position;

		// Token: 0x04000358 RID: 856
		private Color32 m_lightColor;

		// Token: 0x0200009F RID: 159
		public enum MotionType
		{
			// Token: 0x04000464 RID: 1124
			Rotation,
			// Token: 0x04000465 RID: 1125
			SearchLight,
			// Token: 0x04000466 RID: 1126
			Translation
		}
	}
}
