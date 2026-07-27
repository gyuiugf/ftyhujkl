using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000041 RID: 65
public class Spike : ObstacleObject
{
	// Token: 0x060001C6 RID: 454 RVA: 0x00021578 File Offset: 0x0001F778
	public override void Restart()
	{
		/*
An exception occurred when decompiling this method (060001C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Spike::Restart()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_3F:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x060001C7 RID: 455 RVA: 0x000215D0 File Offset: 0x0001F7D0
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			if (collision != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523AE38]");
				object obj = (IntPtr)0;
				Transform transform = collision.transform;
				Console.WriteLine("Unmanaged memory load: [v160 @ X8_v2+B8]");
				object obj2 = (IntPtr)0;
				if (obj2 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523ADE0]");
					object obj3 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v224 @ X0_v13+E4]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Color color;
					bool flag2 = color == 0;
					UnityEngine.Object x = transform;
					Console.WriteLine("Unmanaged memory load: [v90 @ X8_v4+20]");
					bool flag3 = x == (IntPtr)0;
					if (flag2)
					{
						Console.WriteLine("Unmanaged memory load: [v236 @ X8_v5+B8]");
						object obj4 = (IntPtr)0;
						if (obj4 == 0)
						{
							goto IL_705;
						}
						Console.WriteLine("Unmanaged memory load: [v91 @ X8_v7+30]");
						if ((IntPtr)0 == 0)
						{
							goto IL_705;
						}
						Console.WriteLine("Unmanaged memory load: [v91 @ X8_v7+30]");
						((IntPtr)0).OnSpike();
						Console.WriteLine("Unmanaged memory load: [v270 @ X8_v8+B8]");
						object obj5 = (IntPtr)0;
						if (obj5 == 0 || this.spriteRenderer == 0)
						{
							goto IL_705;
						}
						this.spriteRenderer.color = color;
						Console.WriteLine("Unmanaged memory load: [v296 @ X8_v11+B8]");
						object obj6 = (IntPtr)0;
						if (obj6 == 0)
						{
							goto IL_705;
						}
						Console.WriteLine("Unmanaged memory load: [v93 @ X8_v13+200]");
						if ((IntPtr)0 == 0)
						{
							goto IL_705;
						}
						Console.WriteLine("Unmanaged memory load: [523B738]");
						object obj7 = (IntPtr)0;
						bool flag4 = obj7 == 0;
						Console.WriteLine("Unmanaged memory load: [v93 @ X8_v13+200]");
						bool flag5 = ((IntPtr)0).Contains(this);
						if (!flag4)
						{
							Console.WriteLine("Unmanaged memory load: [v314 @ X8_v16+B8]");
							object obj8 = (IntPtr)0;
							if (obj8 == 0)
							{
								goto IL_705;
							}
							Console.WriteLine("Unmanaged memory load: [v94 @ X8_v18+200]");
							List<object> list = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [v94 @ X8_v18+200]");
							if ((IntPtr)0 == 0)
							{
								goto IL_705;
							}
							Console.WriteLine("Unmanaged memory load: [v119 @ X0_v20 (System.Collections.Generic.List`1<System.Object>)+1C]");
							object obj9 = (IntPtr)0 + 1;
							Console.WriteLine("Unmanaged memory load: [v119 @ X0_v20 (System.Collections.Generic.List`1<System.Object>)+10]");
							if ((IntPtr)0 == 0)
							{
								goto IL_705;
							}
							Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
							Console.WriteLine("Unmanaged memory load: [v94 @ X8_v18+200]");
							((IntPtr)0).AddWithResize(this);
						}
					}
					Transform transform2 = collision.transform;
					Console.WriteLine("Unmanaged memory load: [v257 @ X8_v23+B8]");
					object obj10 = (IntPtr)0;
					if (obj10 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v264 @ X0_v24+E4]");
						bool flag6 = (IntPtr)0 == 0;
						if (flag6)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						bool flag7 = color == 0;
						UnityEngine.Object x2 = transform2;
						Console.WriteLine("Unmanaged memory load: [v96 @ X8_v25+28]");
						bool flag8 = x2 == (IntPtr)0;
						if (!flag7)
						{
							break;
						}
						Console.WriteLine("Unmanaged memory load: [v288 @ X8_v26+B8]");
						object obj11 = (IntPtr)0;
						if (obj11 != 0)
						{
							Console.WriteLine("Unmanaged memory load: [v97 @ X8_v28+38]");
							if ((IntPtr)0 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [v97 @ X8_v28+38]");
								((IntPtr)0).OnSpike();
								Console.WriteLine("Unmanaged memory load: [v306 @ X8_v29+B8]");
								object obj12 = (IntPtr)0;
								if (obj12 != 0 && this.spriteRenderer != 0)
								{
									this.spriteRenderer.color = color;
									Console.WriteLine("Unmanaged memory load: [v325 @ X8_v32+B8]");
									object obj13 = (IntPtr)0;
									if (obj13 != 0)
									{
										Console.WriteLine("Unmanaged memory load: [v99 @ X8_v34+200]");
										if ((IntPtr)0 != 0)
										{
											Console.WriteLine("Unmanaged memory load: [523B738]");
											object obj14 = (IntPtr)0;
											bool flag9 = obj14 == 0;
											Console.WriteLine("Unmanaged memory load: [v99 @ X8_v34+200]");
											bool flag10 = ((IntPtr)0).Contains(this);
											if (flag9)
											{
												break;
											}
											Console.WriteLine("Unmanaged memory load: [v348 @ X8_v37+B8]");
											object obj15 = (IntPtr)0;
											if (obj15 != 0)
											{
												Console.WriteLine("Unmanaged memory load: [v100 @ X8_v39+200]");
												List<object> list2 = (IntPtr)0;
												Console.WriteLine("Unmanaged memory load: [v100 @ X8_v39+200]");
												if ((IntPtr)0 != 0)
												{
													Console.WriteLine("Unmanaged memory load: [v101 @ X8_v40 (System.Collections.Generic.List`1<System.Object>)+1C]");
													object obj16 = (IntPtr)0 + 1;
													Console.WriteLine("Unmanaged memory load: [v101 @ X8_v40 (System.Collections.Generic.List`1<System.Object>)+10]");
													if ((IntPtr)0 != 0)
													{
														goto Block_26;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			IL_705:
			Console.WriteLine("Method not found @24D67E8");
		}
		return;
		Block_26:
		Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v100 @ X8_v39+200]");
		((IntPtr)0).AddWithResize(this);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000405B File Offset: 0x0000225B
	private void Start()
	{
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000405D File Offset: 0x0000225D
	private void Update()
	{
	}

	// Token: 0x040001E6 RID: 486
	public SpriteRenderer spriteRenderer;
}
