using System;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class SliceAnimation : MonoBehaviour
{
	// Token: 0x060001A7 RID: 423 RVA: 0x00004051 File Offset: 0x00002251
	private void Awake()
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0002032C File Offset: 0x0001E52C
	public void PlaySliceAnimation()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			bool flag = ~this.sliced;
			if (!flag)
			{
				return;
			}
			Console.WriteLine("Unmanaged memory load: [523AE28]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v29 @ X8_v4+B8]");
			object obj2 = (IntPtr)0;
			SoundManager soundManager = obj2;
			if (obj2 != 0)
			{
				obj2.PlaySound(soundManager.sliceSound);
				if (this.sliceObject != 0)
				{
					this.sliceObject.SetActive(soundManager.sliceSound != null);
					if (this.normalObject != 0)
					{
						this.normalObject.SetActive(soundManager.sliceSound != null);
						if (this.backTransform != 0)
						{
							GameObject gameObject = this.backTransform.gameObject;
							if (gameObject != 0)
							{
								bool flag2;
								gameObject.SetActive(flag2);
								if (this.sliceAnimator != 0)
								{
									this.sliceAnimator.enabled = flag2;
									if (this.backTransform != 0)
									{
										Transform transform = this.backTransform.transform;
										Transform transform2 = base.transform;
										if (transform2 != 0)
										{
											Vector3 position = transform2.position;
											if (transform != 0)
											{
												transform.position = flag2;
												Console.WriteLine("Unmanaged memory load: [559212D]");
												bool flag3 = (IntPtr)0 == 0;
												if (flag3)
												{
													Console.WriteLine("Method not found @24D6540");
												}
												if (this.sliceRB != 0)
												{
													Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
													Transform transform3 = this.sliceRB.transform;
													if (transform3 != 0)
													{
														Vector3 localScale = transform3.localScale;
														if (this.backTransform != 0)
														{
															Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
															Console.WriteLine("Not implemented instruction: Instruction UNIMPLEMENTED not yet implemented.");
															Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
															Console.WriteLine("Not implemented instruction: Instruction INVALID not yet implemented.");
															this.backTransform.localScale = flag2;
															if (this.sliceRB != 0)
															{
																Vector2 linearVelocity = this.sliceRB.linearVelocity;
																Console.WriteLine("Unmanaged memory load: [this @ X0 (SliceAnimation)+50]");
																this.backVelocity = (IntPtr)0;
																if (this.sliceRB != 0)
																{
																	break;
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
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float angularVelocity = this.sliceRB.angularVelocity;
		Console.WriteLine("Unmanaged memory load: [this @ X0 (SliceAnimation)+50]");
		this.backAngularVelocity = (float)((IntPtr)0);
		this.sliced = (1L != 0L);
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00020750 File Offset: 0x0001E950
	public void DeactivateSliceAnimation()
	{
		/*
An exception occurred when decompiling this method (060001A9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SliceAnimation::DeactivateSliceAnimation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_C9:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00020830 File Offset: 0x0001EA30
	private void FixedUpdate()
	{
		/*
An exception occurred when decompiling this method (060001AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SliceAnimation::FixedUpdate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_100:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00004053 File Offset: 0x00002253
	private void Start()
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00004055 File Offset: 0x00002255
	private void Update()
	{
	}

	// Token: 0x040001BC RID: 444
	public GameObject sliceObject;

	// Token: 0x040001BD RID: 445
	public Rigidbody2D sliceRB;

	// Token: 0x040001BE RID: 446
	public GameObject normalObject;

	// Token: 0x040001BF RID: 447
	public Animator sliceAnimator;

	// Token: 0x040001C0 RID: 448
	public Transform backTransform;

	// Token: 0x040001C1 RID: 449
	public Vector3 backOffset;

	// Token: 0x040001C2 RID: 450
	private bool sliced;

	// Token: 0x040001C3 RID: 451
	public float backGravity;

	// Token: 0x040001C4 RID: 452
	private Vector3 backVelocity;

	// Token: 0x040001C5 RID: 453
	private float backAngularVelocity;
}
