using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000061 RID: 97
	public class CameraController : MonoBehaviour
	{
		// Token: 0x06000287 RID: 647 RVA: 0x00035C70 File Offset: 0x00033E70
		private void Awake()
		{
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523B130]");
			object obj = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			int vSyncCount = QualitySettings.vSyncCount;
			int targetFrameRate = obj;
			Console.WriteLine("Not implemented instruction: Instruction CSINV not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [v29 @ X0_v6 (System.Int32)+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Application.targetFrameRate = targetFrameRate;
			Console.WriteLine("Unmanaged memory load: [v44 @ X0_v7+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			RuntimePlatform platform = Application.platform;
			Input.simulateMouseWithTouches = (platform != RuntimePlatform.OSXEditor);
			Transform transform = base.transform;
			this.cameraTransform = transform;
			Console.WriteLine("Method not found @24D64EC");
			float followDistance = this.FollowDistance;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00035DCC File Offset: 0x00033FCC
		private void Start()
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
			object obj2;
			for (;;)
			{
				object x = this + 48L;
				Console.WriteLine("Unmanaged memory load: [v24 @ X0_v8+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag3 = @object == 0;
				bool flag4 = x == @object;
				if (!flag3)
				{
					return;
				}
				Console.WriteLine("Unmanaged memory load: [523BF70]");
				obj2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523BFC8]");
				object name = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				obj2..ctor(name);
				if (obj2 != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Transform transform = obj2.transform;
			this.dummyTarget = transform;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D64EC");
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00035F84 File Offset: 0x00034184
		private void LateUpdate()
		{
			object obj;
			UnityEngine.Object @object = obj - 144L;
			bool flag = this == 0;
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Vector3 vector8;
			object obj7;
			Vector3 vector9;
			for (;;)
			{
				this.GetPlayerInput();
				Console.WriteLine("Unmanaged memory load: [v34 @ X0_v5+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag3 = @object == 0;
				bool flag4 = this.CameraTarget != @object;
				if (!flag3)
				{
					return;
				}
				Vector3 vector2;
				if (this.CameraMode != CameraController.CameraModes.Follow)
				{
					Vector3 vector = vector2;
					goto IL_572;
				}
				if (this.CameraTarget != 0)
				{
					Vector3 position = this.CameraTarget.position;
					Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
					ref Vector3 euler = @object + 32L;
					Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
					Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
					Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FNEG not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
					Vector3 vector3 = @object * @object;
					if (this.CameraTarget != 0)
					{
						Vector3 vector4 = this.CameraTarget.TransformDirection(@object);
						Vector3 vector5 = vector2 + this.ElevationAngle;
						object obj4;
						object obj3 = obj4 + obj4;
						object obj6;
						object obj5 = obj6 + obj6;
						this.desiredPosition = vector5;
						Vector3 vector = vector5;
						goto IL_572;
					}
				}
				IL_52A:
				Console.WriteLine("Method not found @24D67E8");
				continue;
				IL_572:
				if (!(~this.MovementSmoothing))
				{
					if (this.cameraTransform == 0)
					{
						goto IL_52A;
					}
					Vector3 position2 = this.cameraTransform.position;
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					float fixedDeltaTime = Time.fixedDeltaTime;
					Vector3 vector;
					Vector3 vector6 = this.MovementSmoothingValue * vector;
					IntPtr cachedPtr;
					@object.m_CachedPtr = cachedPtr;
					Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.CameraController)+7C]");
					IntPtr intPtr = (IntPtr)0;
					float deltaTime = Time.deltaTime;
					ref Vector3 current = @object + 32L;
					ref Vector3 target = @object + 16L;
					ref Vector3 ptr = this + 104L;
					float maxSpeed;
					float deltaTime2;
					Vector3 vector7 = Vector3.SmoothDamp(ref current, ref target, ref ptr, deltaTime, maxSpeed, deltaTime2);
					vector8 = vector;
					obj7 = 2139095040L;
					vector9 = vector6;
				}
				else
				{
					if (this.cameraTransform == 0)
					{
						goto IL_52A;
					}
					Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.CameraController)+7C]");
					vector8 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [this @ X0 (TMPro.Examples.CameraController)+78]");
					obj7 = (IntPtr)0;
					vector9 = this.desiredPosition;
				}
				this.cameraTransform.position = @object;
				if (!(~this.RotationSmoothing))
				{
					if (this.cameraTransform == 0)
					{
						goto IL_52A;
					}
					Quaternion rotation = this.cameraTransform.rotation;
					if (this.CameraTarget == 0)
					{
						goto IL_52A;
					}
					Vector3 position3 = this.CameraTarget.position;
					if (this.cameraTransform != 0)
					{
						break;
					}
					goto IL_52A;
				}
				else
				{
					if (this.cameraTransform != 0)
					{
						goto Block_12;
					}
					goto IL_52A;
				}
			}
			Vector3 position4 = this.cameraTransform.position;
			IntPtr cachedPtr2 = vector9 - vector9;
			object obj8 = obj7 - obj7;
			object obj9 = vector8 - vector8;
			@object.m_CachedPtr = @object;
			Console.WriteLine("Unmanaged memory load: [559212B]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			ref Vector3 forward = @object + 32L;
			ref Vector3 upwards = @object + 16L;
			Console.WriteLine("Unmanaged memory load: [523AE20]");
			object obj10 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v372 @ X8_v4+B8]");
			object obj11 = (IntPtr)0;
			UnityEngine.Object object2 = @object;
			Console.WriteLine("Unmanaged memory load: [v60 @ X8_v5+18]");
			object2.m_CachedPtr = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v60 @ X8_v5+20]");
			IntPtr intPtr2 = (IntPtr)0;
			Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			float deltaTime3 = Time.deltaTime;
			ref Quaternion a = @object + 32L;
			ref Quaternion b = @object + 16L;
			Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.Object)+C]");
			IntPtr intPtr3 = (IntPtr)0;
			@object.m_CachedPtr = cachedPtr2;
			Console.WriteLine("Unmanaged memory load: [v60 @ X8_v5+20]");
			IntPtr intPtr4 = (IntPtr)0;
			Quaternion quaternion3 = Quaternion.Internal_Lerp(ref a, ref b, deltaTime3);
			this.cameraTransform.rotation = @object;
			return;
			Block_12:
			this.cameraTransform.LookAt(this.CameraTarget);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0003664C File Offset: 0x0003484C
		private void GetPlayerInput()
		{
			object obj;
			Vector3 vector = obj - 464L;
			bool flag = this == 0;
			object obj2 = vector + 176L;
			if (!flag)
			{
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
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Console.WriteLine("Unmanaged memory load: [523BFE8]");
				object axisName = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [559212E]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [523AE20]");
				object obj3 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v58 @ X8_v3+B8]");
				object obj4 = (IntPtr)0;
				this.moveVector = obj4;
				Console.WriteLine("Unmanaged memory load: [v60 @ X8_v4+8]");
				IntPtr intPtr = (IntPtr)0;
				float axis = Input.GetAxis(axisName);
				float num;
				this.mouseWheel = num;
				int touchCount = Input.touchCount;
				bool flag3 = vector == 0;
				bool key = Input.GetKey((KeyCode)touchCount);
				object obj5 = !flag3;
				KeyCode key2 = key ? ((KeyCode)1) : KeyCode.None;
				if (obj5 != null)
				{
					bool flag4 = vector == 0;
					bool key3 = Input.GetKey(key ? ((KeyCode)1) : KeyCode.None);
					key2 = (key3 ? ((KeyCode)1) : KeyCode.None);
					if (!flag4)
					{
						break;
					}
				}
				bool flag5 = vector == 0;
				float num2 = (float)((double)this.mouseWheel * 10.0);
				this.mouseWheel = num2;
				bool keyDown = Input.GetKeyDown(key2);
				if (flag5)
				{
					this.CameraMode = (CameraController.CameraModes)1L;
				}
				bool flag6 = vector == 0;
				bool keyDown2 = Input.GetKeyDown(keyDown ? ((KeyCode)1) : KeyCode.None);
				CameraController.CameraModes cameraModes;
				if (flag6)
				{
					this.CameraMode = cameraModes;
				}
				bool flag7 = vector == 0;
				bool keyDown3 = Input.GetKeyDown(keyDown2 ? ((KeyCode)1) : KeyCode.None);
				if (flag7)
				{
					bool movementSmoothing = ((this.MovementSmoothing ? 1L : 0L) ^ 1L) != 0L;
					this.MovementSmoothing = movementSmoothing;
				}
				bool flag8 = vector == 0;
				bool mouseButton = Input.GetMouseButton(keyDown3 ? 1 : 0);
				object obj6 = !flag8;
				float maxDistance = axis;
				float num3 = num2;
				int button = mouseButton ? 1 : 0;
				if (obj6 == null)
				{
					Console.WriteLine("Unmanaged memory load: [523BFD8]");
					object axisName2 = (IntPtr)0;
					float axis2 = Input.GetAxis(axisName2);
					Console.WriteLine("Unmanaged memory load: [523BFE0]");
					object obj7 = (IntPtr)0;
					this.mouseY = num2;
					float axis3 = Input.GetAxis(obj7);
					this.mouseX = num2;
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					object obj8 = this.mouseY * this.MoveSensitivity;
					float elevationAngle = this.ElevationAngle - obj8;
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
					this.ElevationAngle = elevationAngle;
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					object obj9 = num2 * this.MoveSensitivity;
					float num4 = this.OrbitalAngle + obj9;
					float num5 = (float)((long)num4 + 3283353600L);
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					this.OrbitalAngle = num4;
					Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
					this.OrbitalAngle = num5;
					maxDistance = axis3;
					num3 = num5;
					button = obj7;
				}
				bool flag9 = vector == 0;
				bool mouseButton2 = Input.GetMouseButton(button);
				object obj10 = !flag9;
				float num6 = num3;
				int button2 = mouseButton2 ? 1 : 0;
				if (obj10 != null)
				{
					goto IL_B74;
				}
				Camera main = Camera.main;
				Vector3 mousePosition = Input.mousePosition;
				if (main != 0)
				{
					Ray ray = main.ScreenPointToRay(vector);
					Console.WriteLine("Unmanaged memory load: [523BFD0]");
					object obj11 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v481 @ X0_v39+E4]");
					bool flag10 = (IntPtr)0 == 0;
					if (flag10)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					Ray ray2 = vector + 80L;
					ref RaycastHit hitInfo = vector + 336L;
					bool flag11 = 1133903872L == 0L;
					int layerMask;
					bool flag12 = Physics.Raycast(ray2, out hitInfo, maxDistance, layerMask);
					object obj12 = !flag11;
					num6 = (float)1133903872L;
					button2 = (flag12 ? 1 : 0);
					if (obj12 != null)
					{
						goto IL_B74;
					}
					RaycastHit raycastHit = vector + 336L;
					Transform transform = raycastHit.transform;
					Console.WriteLine("Unmanaged memory load: [523ADE0]");
					object obj13 = (IntPtr)0;
					int num7 = this + 48L;
					Console.WriteLine("Unmanaged memory load: [v351 @ X8_v16+E4]");
					bool flag13 = (IntPtr)0 == 0;
					if (flag13)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag14 = vector == 0;
					bool flag15 = transform == num7.m_value;
					if (flag14)
					{
						this.OrbitalAngle = (float)cameraModes;
						num6 = (float)1133903872L;
						button2 = (flag15 ? 1 : 0);
						goto IL_B74;
					}
					RaycastHit raycastHit2 = vector + 336L;
					Transform transform2 = raycastHit2.transform;
					this.CameraTarget = transform2;
					Console.WriteLine("Method not found @24D64EC");
					this.OrbitalAngle = (float)cameraModes;
					this.MovementSmoothing = this.previousSmoothing;
					num6 = (float)1133903872L;
					button2 = num7;
					goto IL_B74;
				}
				IL_99E:
				Console.WriteLine("Method not found @24D67E8");
				continue;
				IL_B74:
				bool flag16 = vector == 0;
				bool mouseButton3 = Input.GetMouseButton(button2);
				if (!flag16)
				{
					break;
				}
				Console.WriteLine("Unmanaged memory load: [523ADE0]");
				object obj14 = (IntPtr)0;
				object obj15 = this + 40L;
				Console.WriteLine("Unmanaged memory load: [v406 @ X0_v54+E4]");
				bool flag17 = (IntPtr)0 == 0;
				if (flag17)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag18 = vector == 0;
				bool flag19 = obj15 == vector;
				object obj18;
				Transform transform4;
				Transform transform5;
				if (flag18)
				{
					Console.WriteLine("Unmanaged memory load: [523BF70]");
					object obj16 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523BFC8]");
					object name = (IntPtr)0;
					obj16..ctor(name);
					if (obj16 == 0)
					{
						goto IL_99E;
					}
					Transform transform3 = obj16.transform;
					this.dummyTarget = transform3;
					Console.WriteLine("Method not found @24D64EC");
					object obj17 = this + 48L;
					if (obj17 == 0)
					{
						goto IL_99E;
					}
					obj18 = obj17;
					transform4 = this.dummyTarget;
					transform5 = obj17;
				}
				else
				{
					object obj19 = this + 48L;
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					Console.WriteLine("Unmanaged memory load: [v497 @ X0_v62+E4]");
					bool flag20 = (IntPtr)0 == 0;
					if (flag20)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					bool flag21 = vector == 0;
					UnityEngine.Object x;
					bool flag22 = x != obj19;
					if (!flag21)
					{
						goto IL_BE2;
					}
					if (obj19 == 0)
					{
						goto IL_99E;
					}
					obj18 = obj19;
					transform4 = obj15;
					transform5 = obj19;
				}
				Vector3 position = transform5.position;
				if (transform4 == 0)
				{
					goto IL_99E;
				}
				transform4.position = vector;
				if (obj18 == 0)
				{
					goto IL_99E;
				}
				Quaternion rotation = obj18.rotation;
				if (obj15 == 0)
				{
					goto IL_99E;
				}
				obj15.rotation = vector;
				Console.WriteLine("Method not found @24D64EC");
				this.MovementSmoothing = (cameraModes != CameraController.CameraModes.Follow);
				this.previousSmoothing = this.MovementSmoothing;
				IL_BE2:
				Console.WriteLine("Unmanaged memory load: [523BFD8]");
				object axisName3 = (IntPtr)0;
				float axis4 = Input.GetAxis(axisName3);
				Console.WriteLine("Unmanaged memory load: [523BFE0]");
				object axisName4 = (IntPtr)0;
				this.mouseY = num6;
				float axis5 = Input.GetAxis(axisName4);
				this.mouseX = num6;
				if (this.cameraTransform == 0)
				{
					goto IL_99E;
				}
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				float y;
				float z;
				Vector3 vector2 = this.cameraTransform.TransformDirection(axis5, y, z);
				this.moveVector = num6;
				float num8 = this.mouseY;
				if (this.dummyTarget != 0)
				{
					goto Block_18;
				}
				goto IL_99E;
			}
			goto IL_BA9;
			Block_18:
			Console.WriteLine("Not implemented instruction: Instruction FNEG not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FNEG not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FNEG not yet implemented.");
			this.dummyTarget.Translate(vector, vector);
			IL_BA9:
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			object obj20 = (double)this.mouseWheel * -5.0;
			float followDistance = this.FollowDistance + obj20;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
			this.FollowDistance = followDistance;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00037328 File Offset: 0x00035528
		public CameraController()
		{
			Console.WriteLine("Unmanaged memory load: [DBF09C]");
			this.FollowDistance = (float)((IntPtr)0);
			Console.WriteLine("Unmanaged memory load: [DC1880]");
			this.MovementSmoothingValue = (float)((IntPtr)0);
			this.MoveSensitivity = 2f;
			Console.WriteLine("Unmanaged memory load: [559212E]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523AE20]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v31 @ X8_v5+B8]");
			object obj2 = (IntPtr)0;
			this.currentVelocity = obj2;
			Console.WriteLine("Unmanaged memory load: [v33 @ X8_v6+8]");
			IntPtr intPtr = (IntPtr)0;
			base..ctor();
		}

		// Token: 0x04000335 RID: 821
		private Transform cameraTransform;

		// Token: 0x04000336 RID: 822
		private Transform dummyTarget;

		// Token: 0x04000337 RID: 823
		public Transform CameraTarget;

		// Token: 0x04000338 RID: 824
		public float FollowDistance;

		// Token: 0x04000339 RID: 825
		public float MaxFollowDistance;

		// Token: 0x0400033A RID: 826
		public float MinFollowDistance;

		// Token: 0x0400033B RID: 827
		public float ElevationAngle;

		// Token: 0x0400033C RID: 828
		public float MaxElevationAngle = 85f;

		// Token: 0x0400033D RID: 829
		public float MinElevationAngle;

		// Token: 0x0400033E RID: 830
		public float OrbitalAngle;

		// Token: 0x0400033F RID: 831
		public CameraController.CameraModes CameraMode;

		// Token: 0x04000340 RID: 832
		public bool MovementSmoothing = 1L != 0L;

		// Token: 0x04000341 RID: 833
		public bool RotationSmoothing;

		// Token: 0x04000342 RID: 834
		private bool previousSmoothing;

		// Token: 0x04000343 RID: 835
		public float MovementSmoothingValue;

		// Token: 0x04000344 RID: 836
		public float RotationSmoothingValue;

		// Token: 0x04000345 RID: 837
		public float MoveSensitivity;

		// Token: 0x04000346 RID: 838
		private Vector3 currentVelocity;

		// Token: 0x04000347 RID: 839
		private Vector3 desiredPosition;

		// Token: 0x04000348 RID: 840
		private float mouseX;

		// Token: 0x04000349 RID: 841
		private float mouseY;

		// Token: 0x0400034A RID: 842
		private Vector3 moveVector;

		// Token: 0x0400034B RID: 843
		private float mouseWheel;

		// Token: 0x0400034C RID: 844
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		// Token: 0x0400034D RID: 845
		private const string event_FollowDistance = "Slider - Camera Zoom";

		// Token: 0x0200009E RID: 158
		public enum CameraModes
		{
			// Token: 0x04000460 RID: 1120
			Follow,
			// Token: 0x04000461 RID: 1121
			Isometric,
			// Token: 0x04000462 RID: 1122
			Free
		}
	}
}
