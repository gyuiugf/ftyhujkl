using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000022 RID: 34
public class Laser : ObstacleObject
{
	// Token: 0x060000E1 RID: 225 RVA: 0x000130D4 File Offset: 0x000112D4
	private void OnDisable()
	{
		Console.WriteLine("Unmanaged memory load: [523AE28]");
		object obj = (IntPtr)0;
		object obj2;
		if (obj2 == null)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj3;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v21 @ X8_v1+B8]");
			obj3 = (IntPtr)0;
			if (obj3 != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		obj3.StopLaserLoopSound();
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0001317C File Offset: 0x0001137C
	public void DrawLaser(Vector2 A, Vector2 B)
	{
		object obj;
		Vector3 vector = obj - 80L;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Transform transform3;
		if (transform2 != 0)
		{
			Vector3 position = transform2.position;
			if (transform != 0)
			{
				transform.position = vector;
				transform3 = base.transform;
				Console.WriteLine("Unmanaged memory load: [5592130]");
				bool flag = (IntPtr)0 == 0;
				if (flag)
				{
					Console.WriteLine("Method not found @24D6540");
					goto IL_212;
				}
				goto IL_212;
			}
		}
		IL_208:
		Console.WriteLine("Method not found @24D67E8");
		IL_212:
		Console.WriteLine("Unmanaged memory load: [523AD40]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v64 @ X0_v12+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		if (transform3 == 0)
		{
			goto IL_208;
		}
		object obj4;
		object obj5;
		object obj3 = obj4 - obj5;
		Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
		transform3.localScale = vector;
		Console.WriteLine("Method not found @4F26550");
		object obj6 = obj3;
		Console.WriteLine("Unmanaged memory load: [DBDEA0]");
		object obj7 = obj6 * (IntPtr)0;
		Transform transform4 = base.transform;
		ref Vector3 euler = vector + 0L;
		vector.x = vector;
		float num = obj7;
		Console.WriteLine("Unmanaged memory load: [DBE06C]");
		float z = (float)((IntPtr)num * (IntPtr)0);
		vector.z = z;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		if (transform4 != 0)
		{
			transform4.rotation = vector;
			return;
		}
		goto IL_208;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000133E4 File Offset: 0x000115E4
	public override void Restart()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			List<Transform> list = this.prevHits;
			if (this.prevHits != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [v20 @ X8_v1 (System.Collections.Generic.List`1<UnityEngine.Transform>)+1C]");
		object obj = (IntPtr)0 + 1;
		Transform transform;
		this.prevBlocker = transform;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000134B8 File Offset: 0x000116B8
	public override void OnPhysicsButton(bool pressed)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		bool flag = ~(1L != 0L) != 0L;
		Console.WriteLine("Not implemented instruction: Instruction ORN not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction BIC not yet implemented.");
		this.active = (1L != 0L);
		if (!flag)
		{
			Transform transform = base.transform;
			if (transform != 0)
			{
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				Vector3 localScale;
				transform.localScale = localScale;
				if (this.hitAnimTransforms != 0 && this.blockerAnimTransform != 0)
				{
					GameObject gameObject = this.blockerAnimTransform.gameObject;
					if (gameObject != 0)
					{
						gameObject.SetActive(localScale != null);
						return;
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00013634 File Offset: 0x00011834
	public void Start()
	{
		/*
An exception occurred when decompiling this method (060000E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Laser::Start()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_9E:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00003FF1 File Offset: 0x000021F1
	public void CheckIfPlayerSliced()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x000136E8 File Offset: 0x000118E8
	public bool LaserUpdate()
	{
		object obj;
		bool flag = obj - 336L != null;
		bool flag2 = this == 0;
		Laser result = this;
		if (!flag2)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Laser laser;
			result = laser;
		}
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
			if (!(~this.active))
			{
				bool flag3 = this.laserOrigin == 0;
				object obj3;
				object obj2 = obj3;
				UnityEngine.Object object2;
				UnityEngine.Object @object = object2;
				object obj5;
				object obj4 = obj5;
				bool flag5;
				bool flag4 = flag5;
				RaycastHit2D[] array2;
				RaycastHit2D[] array = array2;
				List<object> list2;
				List<object> list = list2;
				bool flag7;
				bool flag6 = flag7;
				object obj7;
				object obj6 = obj7;
				object obj9;
				object obj8 = obj9;
				object obj11;
				object obj10 = obj11;
				object obj13;
				object obj12 = obj13;
				object obj15;
				object obj14 = obj15;
				object obj17;
				object obj16 = obj17;
				object obj19;
				object obj18 = obj19;
				Vector2 vector2;
				Vector2 vector = vector2;
				bool flag9;
				bool flag8 = flag9;
				object obj21;
				object obj20 = obj21;
				object obj23;
				object obj22 = obj23;
				object obj25;
				object obj24 = obj25;
				object obj27;
				object obj26 = obj27;
				object obj29;
				object obj28 = obj29;
				object obj31;
				object obj30 = obj31;
				object obj33;
				object obj32 = obj33;
				object obj35;
				object obj34 = obj35;
				bool flag11;
				bool flag10 = flag11;
				object obj36 = 1;
				bool flag12 = this.active;
				object obj37 = 50061312L;
				bool flag20;
				if (!flag3)
				{
					Vector3 position = this.laserOrigin.position;
					bool flag13 = this.laserEnd == 0;
					obj2 = obj3;
					@object = object2;
					obj4 = obj5;
					flag4 = flag5;
					array = array2;
					list = list2;
					flag6 = flag7;
					obj6 = obj7;
					obj8 = obj9;
					obj10 = obj11;
					obj12 = obj13;
					obj14 = obj15;
					obj16 = obj17;
					obj18 = obj19;
					vector = vector2;
					flag8 = flag9;
					obj20 = obj21;
					obj22 = obj23;
					obj24 = obj25;
					obj26 = obj27;
					obj28 = obj29;
					obj30 = obj31;
					obj32 = obj33;
					obj34 = obj35;
					flag10 = flag;
					obj36 = 1;
					flag12 = this.active;
					obj37 = 50061312L;
					if (!flag13)
					{
						Vector3 position2 = this.laserEnd.position;
						ref Vector2 value = (flag ? 1L : 0L) + 168L;
						object obj38 = obj27 - obj27;
						object obj39 = obj25 - obj25;
						Vector2 vector3 = Vector2.Normalize(ref value);
						bool flag14 = this.blockerAnimTransform == 0;
						obj2 = obj3;
						@object = object2;
						obj4 = obj5;
						flag4 = flag5;
						array = array2;
						list = list2;
						flag6 = flag7;
						obj6 = obj7;
						obj8 = obj9;
						obj10 = obj11;
						obj12 = obj13;
						obj14 = obj15;
						obj16 = obj17;
						obj18 = obj19;
						vector = vector2;
						flag8 = flag9;
						obj20 = obj21;
						obj22 = obj23;
						obj24 = obj39;
						obj26 = obj38;
						obj28 = obj25;
						obj30 = obj27;
						obj32 = obj25;
						obj34 = obj27;
						flag10 = flag;
						obj36 = 1;
						flag12 = this.active;
						obj37 = 50061312L;
						if (!flag14)
						{
							GameObject gameObject = this.blockerAnimTransform.gameObject;
							bool flag15 = gameObject == 0;
							obj2 = obj3;
							@object = object2;
							obj4 = obj5;
							flag4 = flag5;
							array = array2;
							list = list2;
							flag6 = flag7;
							obj6 = obj7;
							obj8 = obj9;
							obj10 = obj11;
							obj12 = obj13;
							obj14 = obj15;
							obj16 = obj17;
							obj18 = obj19;
							vector = vector2;
							flag8 = flag9;
							obj20 = obj39;
							obj22 = obj38;
							obj24 = obj39;
							obj26 = obj38;
							obj28 = obj25;
							obj30 = obj27;
							obj32 = obj25;
							obj34 = obj27;
							flag10 = flag;
							obj36 = 1;
							flag12 = this.active;
							obj37 = 50061312L;
							if (!flag15)
							{
								gameObject.SetActive(flag);
								Console.WriteLine("Unmanaged memory load: [5592130]");
								bool flag16 = (IntPtr)0 == 0;
								if (flag16)
								{
									Console.WriteLine("Method not found @24D6540");
								}
								Console.WriteLine("Unmanaged memory load: [523AD40]");
								List<object> list3 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [523B380]");
								object obj40 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [v523 @ X0_v66+E4]");
								bool flag17 = (IntPtr)0 == 0;
								if (flag17)
								{
									Console.WriteLine("Method not found @24D66BC");
								}
								Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
								Console.WriteLine("Unmanaged memory load: [v558 @ X0_v69+E4]");
								bool flag18 = ~((IntPtr)0 != 0) != 0;
								object obj41 = !flag18;
								if (obj41 == null)
								{
									Console.WriteLine("Method not found @24D66BC");
								}
								float distance;
								RaycastHit2D[] array3 = Physics2D.RaycastAll(flag, flag, distance);
								bool flag19 = array3 == 0;
								obj2 = obj3;
								@object = object2;
								obj4 = obj5;
								flag4 = flag5;
								array = array2;
								list = list3;
								flag6 = flag7;
								obj6 = obj7;
								obj8 = obj9;
								obj10 = obj11;
								object obj42;
								obj12 = obj42;
								obj14 = obj39;
								obj16 = obj38;
								obj18 = 50061312L;
								vector = flag;
								flag8 = flag20;
								obj20 = obj39;
								obj22 = obj38;
								obj24 = obj25;
								obj26 = obj27;
								obj28 = obj25;
								obj30 = obj27;
								obj32 = obj25;
								obj34 = obj27;
								flag10 = flag;
								obj36 = obj41;
								Console.WriteLine("Unmanaged memory load: [v558 @ X0_v69+E4]");
								flag12 = ((IntPtr)0 != 0);
								obj37 = obj40;
								if (!flag19)
								{
									this.DrawLaser(flag, flag);
									Console.WriteLine("Unmanaged memory load: [5592130]");
									bool flag21 = (IntPtr)0 == 0;
									if (flag21)
									{
										Console.WriteLine("Method not found @24D6540");
									}
									Console.WriteLine("Unmanaged memory load: [523B380]");
									object obj43 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [v814 @ X0_v79+E4]");
									bool flag22 = (IntPtr)0 == 0;
									if (flag22)
									{
										Console.WriteLine("Method not found @24D66BC");
									}
									Console.WriteLine("Unmanaged memory load: [523B370]");
									object obj44 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [523B368]");
									object obj45 = (IntPtr)0;
									Console.WriteLine("Not implemented instruction: Instruction FSQRT not yet implemented.");
									Console.WriteLine("Unmanaged memory load: [v833 @ X0_v82+E4]");
									bool flag23 = ~((IntPtr)0 != 0) != 0;
									object obj46 = !flag23;
									if (obj46 == null)
									{
										Console.WriteLine("Method not found @24D66BC");
									}
									RaycastHit2D[] array4 = Physics2D.RaycastAll(flag, flag, distance);
									Console.WriteLine("Method not found @24D67D8");
									List<object> list4;
									list4..ctor();
									bool flag24 = array4 == 0;
									obj2 = obj3;
									@object = object2;
									obj4 = obj5;
									flag4 = flag5;
									array = array4;
									list = list4;
									flag6 = flag7;
									Console.WriteLine("Unmanaged memory load: [523ADE0]");
									obj6 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [523B330]");
									obj8 = (IntPtr)0;
									obj10 = obj44;
									obj12 = obj42;
									obj14 = obj39;
									obj16 = obj38;
									obj18 = 50061312L;
									vector = flag;
									flag8 = flag20;
									obj20 = obj39;
									obj22 = obj38;
									obj24 = obj25;
									obj26 = obj27;
									obj28 = obj25;
									obj30 = obj27;
									obj32 = obj25;
									obj34 = obj27;
									flag10 = (obj45 != null);
									obj36 = obj46;
									Console.WriteLine("Unmanaged memory load: [v833 @ X0_v82+E4]");
									flag12 = ((IntPtr)0 != 0);
									obj37 = obj45;
									if (!flag24)
									{
										Console.WriteLine("Unmanaged memory load: [v833 @ X0_v82+E4]");
										object obj47 = (IntPtr)0 - 1;
									}
								}
							}
						}
					}
				}
				for (;;)
				{
					Console.WriteLine("Method not found @24D67E8");
					object obj48 = obj2;
					UnityEngine.Object object3 = @object;
					object obj49 = obj4;
					bool flag25 = flag4;
					RaycastHit2D[] array5 = array;
					List<object> list5 = list;
					bool flag26 = flag6;
					object obj50 = obj6;
					object obj51 = obj8;
					object obj52 = obj10;
					object obj53 = obj12;
					object obj54 = obj14;
					object obj55 = obj16;
					object obj56 = obj18;
					Vector2 vector4 = vector;
					bool flag27 = flag8;
					object obj57 = obj20;
					object obj58 = obj22;
					object obj59 = obj24;
					object obj60 = obj26;
					object obj61 = obj28;
					object obj62 = obj30;
					object obj63 = obj32;
					object obj64 = obj34;
					bool flag28 = flag10;
					object obj65 = obj36;
					bool flag29 = flag12;
					object obj66 = obj37;
					object obj67 = this + 80L;
					bool flag30 = obj67 == 0;
					obj2 = obj48;
					@object = object3;
					obj4 = obj49;
					flag4 = flag25;
					array = array5;
					list = list5;
					flag6 = flag26;
					obj6 = obj50;
					obj8 = obj51;
					obj10 = obj52;
					obj12 = obj53;
					obj14 = obj54;
					obj16 = obj55;
					obj18 = obj56;
					vector = vector4;
					flag8 = flag27;
					obj20 = obj57;
					obj22 = obj58;
					obj24 = obj59;
					obj26 = obj60;
					obj28 = obj61;
					obj30 = obj62;
					obj32 = obj63;
					obj34 = obj64;
					flag10 = flag28;
					obj36 = obj65;
					flag12 = flag29;
					obj37 = obj66;
					if (!flag30)
					{
						List<object>.Enumerator enumerator = obj67.GetEnumerator();
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+28]");
						IntPtr intPtr = (IntPtr)0;
						object obj68 = (flag ? 1L : 0L) + 48L;
						object obj69 = obj48;
						UnityEngine.Object object4 = object3;
						RaycastHit2D[] array6 = array5;
						bool flag31 = flag20;
						object obj70 = obj54;
						object obj71 = obj55;
						object obj72 = obj59;
						object obj73 = obj60;
						for (;;)
						{
							bool flag32 = obj56 == 0;
							List<object>.Enumerator enumerator2 = (flag ? 1L : 0L) + 48L;
							bool flag33 = enumerator2.MoveNext();
							if (!flag32)
							{
								break;
							}
							if (list5 == 0)
							{
								goto IL_1A7C;
							}
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
							bool flag34 = (IntPtr)0 == 0;
							List<object> list6 = list5;
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
							bool flag35 = list6.Contains((IntPtr)0);
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
							array6 = (IntPtr)0;
							if (!flag34)
							{
								Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
								if ((IntPtr)0 == 0)
								{
									goto IL_1A8B;
								}
								Console.WriteLine("Method not found @2894080");
								Console.WriteLine("Unmanaged memory load: [v605 @ X0_v102+E4]");
								bool flag36 = (IntPtr)0 == 0;
								if (flag36)
								{
									Console.WriteLine("Method not found @24D66BC");
								}
								bool flag37 = !flag;
								UnityEngine.Object object5;
								bool flag38 = object5 != flag;
								object obj74 = !flag37;
								object4 = object5;
								Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
								array6 = (IntPtr)0;
								if (obj74 == null)
								{
									if (object5 == 0)
									{
										goto IL_1A9A;
									}
									bool flag39 = !flag;
									Laser laser2;
									bool flag40 = object5.SideChanged(this, flag, laser2);
									object obj75 = !flag39;
									object4 = object5;
									Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
									array6 = (IntPtr)0;
									obj70 = obj61;
									obj71 = obj62;
									obj72 = obj63;
									obj73 = obj64;
									if (obj75 == null)
									{
										Console.WriteLine("Unmanaged memory load: [523AE38]");
										object obj76 = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v824 @ X8_v13+B8]");
										object obj77 = (IntPtr)0;
										if (obj77 == 0)
										{
											goto IL_1AA9;
										}
										Console.WriteLine("Unmanaged memory load: [v843 @ X0_v109+E4]");
										bool flag41 = (IntPtr)0 == 0;
										if (flag41)
										{
											Console.WriteLine("Method not found @24D66BC");
										}
										bool flag42 = !flag;
										Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
										UnityEngine.Object x = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v573 @ X8_v15+20]");
										bool flag43 = x == (IntPtr)0;
										if (flag42)
										{
											Console.WriteLine("Unmanaged memory load: [523AE38]");
											object obj78 = (IntPtr)0;
											Console.WriteLine("Unmanaged memory load: [v880 @ X8_v18+B8]");
											object obj79 = (IntPtr)0;
											if (obj79 == 0)
											{
												goto IL_1AC7;
											}
											Console.WriteLine("Unmanaged memory load: [v663 @ X8_v20+30]");
											if ((IntPtr)0 == 0)
											{
												goto IL_1AF4;
											}
											Console.WriteLine("Unmanaged memory load: [v663 @ X8_v20+30]");
											((IntPtr)0).OnSlice();
										}
										Console.WriteLine("Unmanaged memory load: [523AE38]");
										object obj80 = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v889 @ X8_v24+B8]");
										object obj81 = (IntPtr)0;
										if (obj81 == 0)
										{
											goto IL_1AB8;
										}
										Console.WriteLine("Unmanaged memory load: [v897 @ X0_v116+E4]");
										bool flag44 = (IntPtr)0 == 0;
										if (flag44)
										{
											Console.WriteLine("Method not found @24D66BC");
										}
										bool flag45 = !flag;
										Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+40]");
										UnityEngine.Object x2 = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v616 @ X8_v26+28]");
										bool flag46 = x2 == (IntPtr)0;
										object obj82 = !flag45;
										bool flag47 = flag31;
										if (obj82 == null)
										{
											Console.WriteLine("Unmanaged memory load: [523AE38]");
											object obj83 = (IntPtr)0;
											Console.WriteLine("Unmanaged memory load: [v918 @ X8_v29+B8]");
											object obj84 = (IntPtr)0;
											if (obj84 == 0)
											{
												goto IL_1B03;
											}
											Console.WriteLine("Unmanaged memory load: [v705 @ X8_v31+38]");
											if ((IntPtr)0 == 0)
											{
												goto IL_1AD6;
											}
											Console.WriteLine("Unmanaged memory load: [v705 @ X8_v31+38]");
											((IntPtr)0).OnSlice();
											flag47 = (1L != 0L);
										}
										Console.WriteLine("Method not found @2894080");
										Console.WriteLine("Unmanaged memory load: [v940 @ X0_v125+E4]");
										bool flag48 = (IntPtr)0 == 0;
										if (flag48)
										{
											Console.WriteLine("Method not found @24D66BC");
										}
										bool flag49 = !flag;
										UnityEngine.Object object6;
										bool flag50 = object6 != flag;
										object obj85 = !flag49;
										Console.WriteLine("Unmanaged memory load: [v897 @ X0_v116+E4]");
										obj69 = (IntPtr)0;
										Console.WriteLine("Unmanaged memory load: [v616 @ X8_v26+28]");
										object4 = (IntPtr)0;
										array6 = object6;
										flag31 = flag47;
										obj70 = obj61;
										obj71 = obj62;
										obj72 = obj63;
										obj73 = obj64;
										if (obj85 == null)
										{
											if (object6 == 0)
											{
												goto IL_1AE5;
											}
											Console.WriteLine("Unmanaged memory load: [v933 @ X0_v124 (UnityEngine.Object)+60]");
											bool flag51 = (IntPtr)0 == 0;
											Console.WriteLine("Unmanaged memory load: [v897 @ X0_v116+E4]");
											obj69 = (IntPtr)0;
											Console.WriteLine("Unmanaged memory load: [v616 @ X8_v26+28]");
											object4 = (IntPtr)0;
											array6 = object6;
											flag31 = flag47;
											obj70 = obj61;
											obj71 = obj62;
											obj72 = obj63;
											obj73 = obj64;
											if (!flag51)
											{
												object6.OnSlice();
												Console.WriteLine("Unmanaged memory load: [v897 @ X0_v116+E4]");
												obj69 = (IntPtr)0;
												Console.WriteLine("Unmanaged memory load: [v616 @ X8_v26+28]");
												object4 = (IntPtr)0;
												array6 = object6;
												flag31 = flag47;
												obj70 = obj61;
												obj71 = obj62;
												obj72 = obj63;
												obj73 = obj64;
											}
										}
									}
								}
							}
						}
						List<object>.Enumerator enumerator3 = (flag ? 1L : 0L) + 48L;
						enumerator3.Dispose();
						bool flag52 = ~this.hasHit;
						object obj86 = !flag52;
						Console.WriteLine("Unmanaged memory load: [523B338]");
						object obj87 = (IntPtr)0;
						Vector2 vector5;
						bool flag58;
						if (obj86 == null)
						{
							Console.WriteLine("Unmanaged memory load: [v488 @ X0_v156+E4]");
							bool flag53 = ~((IntPtr)0 != 0) != 0;
							if (flag53)
							{
								Console.WriteLine("Method not found @24D66BC");
							}
							bool flag54 = !flag;
							Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+10]");
							bool flag55 = (IntPtr)0 != flag;
							if (!flag54)
							{
								bool flag56 = list5 == 0;
								obj2 = obj69;
								@object = object4;
								obj4 = obj49;
								flag4 = flag25;
								array = array6;
								list = list5;
								flag6 = flag31;
								obj6 = obj50;
								obj8 = obj51;
								Console.WriteLine("Unmanaged memory load: [523B338]");
								obj10 = (IntPtr)0;
								obj12 = obj53;
								obj14 = obj70;
								obj16 = obj71;
								obj18 = obj56;
								vector = flag;
								flag8 = flag27;
								obj20 = obj57;
								obj22 = obj58;
								obj24 = obj72;
								obj26 = obj73;
								obj28 = obj61;
								obj30 = obj62;
								obj32 = obj63;
								obj34 = obj64;
								flag10 = flag;
								obj36 = 1;
								Console.WriteLine("Unmanaged memory load: [v488 @ X0_v156+E4]");
								flag12 = ((IntPtr)0 != 0);
								obj37 = obj66;
								if (flag56)
								{
									continue;
								}
								bool flag57 = ~this.hasHit;
								object obj88 = !flag57;
								Console.WriteLine("Unmanaged memory load: [523B338]");
								obj87 = (IntPtr)0;
								if (obj88 == null)
								{
									vector5 = flag;
									flag58 = flag;
									goto IL_1F64;
								}
							}
							else
							{
								Console.WriteLine("Unmanaged memory load: [523AE28]");
								object obj89 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [v635 @ X8_v46+B8]");
								object obj90 = (IntPtr)0;
								bool flag59 = obj90 == 0;
								obj2 = obj69;
								@object = object4;
								obj4 = obj49;
								flag4 = flag25;
								array = array6;
								list = list5;
								flag6 = flag31;
								obj6 = obj50;
								obj8 = obj51;
								obj10 = obj90;
								obj12 = obj53;
								obj14 = obj70;
								obj16 = obj71;
								obj18 = obj56;
								vector = flag;
								flag8 = flag27;
								obj20 = obj57;
								obj22 = obj58;
								obj24 = obj72;
								obj26 = obj73;
								obj28 = obj61;
								obj30 = obj62;
								obj32 = obj63;
								obj34 = obj64;
								flag10 = flag;
								obj36 = 1;
								Console.WriteLine("Unmanaged memory load: [v488 @ X0_v156+E4]");
								flag12 = ((IntPtr)0 != 0);
								obj37 = obj66;
								if (flag59)
								{
									continue;
								}
								obj90.PlayLaserLoopSound();
								this.hasHit = (1L != 0L);
								obj87 = obj90;
							}
						}
						Console.WriteLine("Unmanaged memory load: [v505 @ X0_v163+E4]");
						bool flag60 = ~((IntPtr)0 != 0) != 0;
						if (flag60)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag61 = !flag;
						Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+10]");
						bool flag62 = (IntPtr)0 == flag;
						object obj91 = !flag61;
						vector5 = flag;
						flag58 = flag;
						if (obj91 == null)
						{
							bool flag63 = list5 == 0;
							obj2 = obj69;
							@object = object4;
							obj4 = obj49;
							flag4 = flag25;
							array = array6;
							list = list5;
							flag6 = flag31;
							obj6 = obj50;
							obj8 = obj51;
							obj10 = obj87;
							obj12 = obj53;
							obj14 = obj70;
							obj16 = obj71;
							obj18 = obj56;
							vector = flag;
							flag8 = flag27;
							obj20 = obj57;
							obj22 = obj58;
							obj24 = obj72;
							obj26 = obj73;
							obj28 = obj61;
							obj30 = obj62;
							obj32 = obj63;
							obj34 = obj64;
							flag10 = flag;
							obj36 = obj91;
							Console.WriteLine("Unmanaged memory load: [v505 @ X0_v163+E4]");
							flag12 = ((IntPtr)0 != 0);
							obj37 = obj66;
							if (flag63)
							{
								continue;
							}
							Console.WriteLine("Unmanaged memory load: [v79 @ X21_v8 (System.Collections.Generic.List`1<System.Object>)+18]");
							bool flag64 = ~((IntPtr)0 != 0) != 0;
							object obj92 = !flag64;
							vector5 = flag;
							flag58 = flag;
							if (obj92 == null)
							{
								Console.WriteLine("Unmanaged memory load: [523AE28]");
								object obj93 = (IntPtr)0;
								Console.WriteLine("Unmanaged memory load: [v725 @ X8_v51+B8]");
								object obj94 = (IntPtr)0;
								bool flag65 = obj94 == 0;
								obj2 = obj69;
								@object = object4;
								obj4 = obj49;
								flag4 = flag25;
								array = array6;
								list = list5;
								flag6 = flag31;
								obj6 = obj50;
								obj8 = obj51;
								obj10 = obj94;
								obj12 = obj53;
								obj14 = obj70;
								obj16 = obj71;
								obj18 = obj56;
								vector = flag;
								flag8 = flag27;
								obj20 = obj57;
								obj22 = obj58;
								obj24 = obj72;
								obj26 = obj73;
								obj28 = obj61;
								obj30 = obj62;
								obj32 = obj63;
								obj34 = obj64;
								flag10 = flag;
								obj36 = obj92;
								Console.WriteLine("Unmanaged memory load: [v79 @ X21_v8 (System.Collections.Generic.List`1<System.Object>)+18]");
								flag12 = ((IntPtr)0 != 0);
								obj37 = obj66;
								if (flag65)
								{
									continue;
								}
								obj94.StopLaserLoopSound();
								this.hasHit = flag20;
								vector5 = flag;
								flag58 = flag;
							}
						}
						IL_1F64:
						Console.WriteLine("Unmanaged memory load: [v647 @ X0_v170+E4]");
						bool flag66 = ~((IntPtr)0 != 0) != 0;
						object obj95 = !flag66;
						if (obj95 == null)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						Console.WriteLine("Method not found @29B3354");
						object obj96;
						bool flag67 = obj96 == 0;
						obj2 = obj69;
						@object = object4;
						obj4 = obj49;
						flag4 = flag25;
						array = array6;
						list = list5;
						flag6 = flag31;
						obj6 = obj50;
						obj8 = obj51;
						Console.WriteLine("Unmanaged memory load: [523B378]");
						obj10 = (IntPtr)0;
						obj12 = obj53;
						obj14 = obj70;
						obj16 = obj71;
						obj18 = obj56;
						vector = vector5;
						flag8 = flag27;
						obj20 = obj57;
						obj22 = obj58;
						obj24 = obj72;
						obj26 = obj73;
						obj28 = obj61;
						obj30 = obj62;
						obj32 = obj63;
						obj34 = obj64;
						flag10 = flag58;
						obj36 = obj95;
						Console.WriteLine("Unmanaged memory load: [v647 @ X0_v170+E4]");
						flag12 = ((IntPtr)0 != 0);
						obj37 = obj66;
						if (!flag67)
						{
							goto Block_41;
						}
					}
				}
				IL_1B03:
				Console.WriteLine("Method not found @24D67E8");
				continue;
				IL_1AF4:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1B03;
				IL_1AE5:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1AF4;
				IL_1AD6:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1AE5;
				IL_1AC7:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1AD6;
				IL_1AB8:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1AC7;
				IL_1AA9:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1AB8;
				IL_1A9A:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1AA9;
				IL_1A8B:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1A9A;
				IL_1A7C:
				Console.WriteLine("Method not found @24D67E8");
				goto IL_1A8B;
			}
			break;
		}
		return result != null;
		Block_41:
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Boolean)+10]");
		this.prevBlocker = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
		bool result2;
		return result2;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x000156C4 File Offset: 0x000138C4
	private static bool Intersect(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		return p1 != null;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00015730 File Offset: 0x00013930
	private static float Direction(Vector2 a, Vector2 b, Vector2 c)
	{
		float result;
		return result;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00015744 File Offset: 0x00013944
	private static bool OnSegment(Vector2 a, Vector2 b, Vector2 c)
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		return a != null;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00015778 File Offset: 0x00013978
	private void Update()
	{
		this.LaserUpdate();
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0001578C File Offset: 0x0001398C
	public Laser()
	{
		Console.WriteLine("Unmanaged memory load: [523B370]");
		object obj = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this.hitAnimTransforms = obj;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this.prevHits = obj;
		Console.WriteLine("Method not found @24D64EC");
		this.active = (1L != 0L);
		base..ctor();
	}

	// Token: 0x040000F1 RID: 241
	public Transform laserOrigin;

	// Token: 0x040000F2 RID: 242
	public Transform laserEnd;

	// Token: 0x040000F3 RID: 243
	public LayerMask hitMask;

	// Token: 0x040000F4 RID: 244
	public Transform blockerAnimTransform;

	// Token: 0x040000F5 RID: 245
	public List<Transform> hitAnimTransforms;

	// Token: 0x040000F6 RID: 246
	private List<Transform> prevHits;

	// Token: 0x040000F7 RID: 247
	public Transform prevBlocker;

	// Token: 0x040000F8 RID: 248
	public bool active;

	// Token: 0x040000F9 RID: 249
	private bool hasHit;
}
