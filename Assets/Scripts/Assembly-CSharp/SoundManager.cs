using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000040 RID: 64
public class SoundManager : MonoBehaviour
{
	// Token: 0x060001AE RID: 430 RVA: 0x0002095C File Offset: 0x0001EB5C
	public void SetSoundCooldown(float cooldown)
	{
		float num;
		this.soundCooldown = num;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00020974 File Offset: 0x0001EB74
	public void PlaySound(AudioSource sound)
	{
		/*
An exception occurred when decompiling this method (060001AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SoundManager::PlaySound(UnityEngine.AudioSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_36:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x060001B0 RID: 432 RVA: 0x000209C8 File Offset: 0x0001EBC8
	private void Awake()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523AE28]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v23 @ X8_v1+B8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00020A60 File Offset: 0x0001EC60
	private void OnEnable()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Slider slider;
		object obj;
		for (;;)
		{
			if (this.bounceSound != 0)
			{
				float volume = this.bounceSound.volume;
				float num;
				this.bounceVolume = num;
				if (this.clickSound != 0)
				{
					float volume2 = this.clickSound.volume;
					this.clickVolume = num;
					if (this.transitionSound != 0)
					{
						float volume3 = this.transitionSound.volume;
						this.transitionVolume = num;
						if (this.starSound != 0)
						{
							float volume4 = this.starSound.volume;
							this.starVolume = num;
							if (this.hoopScoreSound != 0)
							{
								float volume5 = this.hoopScoreSound.volume;
								this.hoopScoreVolume = num;
								if (this.hoopScoreSound2 != 0)
								{
									float volume6 = this.hoopScoreSound2.volume;
									this.hoopScoreVolume2 = num;
									if (this.hoopHitSound != 0)
									{
										float volume7 = this.hoopHitSound.volume;
										this.hoopHitVolume = num;
										if (this.netSound != 0)
										{
											float volume8 = this.netSound.volume;
											this.netVolume = num;
											if (this.laserImpactSound != 0)
											{
												float volume9 = this.laserImpactSound.volume;
												this.laserImpactVolume = num;
												if (this.laserLoopSound != 0)
												{
													float volume10 = this.laserLoopSound.volume;
													this.laserLoopVolume = num;
													if (this.sliceSound != 0)
													{
														float volume11 = this.sliceSound.volume;
														this.sliceVolume = num;
														if (this.popSound != 0)
														{
															float volume12 = this.popSound.volume;
															this.popVolume = num;
															if (this.metalHitSound != 0)
															{
																float volume13 = this.metalHitSound.volume;
																slider = this.volumeSlider;
																this.metalHitVolume = num;
																if (this.volumeSlider != 0)
																{
																	Console.WriteLine("Unmanaged memory load: [523B708]");
																	obj = (IntPtr)0;
																	Console.WriteLine("Unmanaged memory load: [523B700]");
																	object method = (IntPtr)0;
																	Console.WriteLine("Method not found @24D67D8");
																	obj..ctor(this, method);
																	if (slider.m_OnValueChanged != 0)
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
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		slider.m_OnValueChanged.AddListener(obj);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00020E58 File Offset: 0x0001F058
	public void PlayBounceSound(float impactForce)
	{
		/*
An exception occurred when decompiling this method (060001B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SoundManager::PlayBounceSound(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_77:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x060001B3 RID: 435 RVA: 0x00020EE8 File Offset: 0x0001F0E8
	public void PlayTransitionSound()
	{
		float time;
		IEnumerator routine = this.PlaySoundAfterTime(this.transitionSound, time);
		base.StartCoroutine(routine);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00020F24 File Offset: 0x0001F124
	public void PlayClickSound()
	{
		this.PlaySound(this.clickSound);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00020F40 File Offset: 0x0001F140
	public IEnumerator PlaySoundAfterTime(AudioSource sound, float time)
	{
		if (sound != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		object obj;
		obj..ctor();
		Console.WriteLine("Method not found @24D64EC");
		return obj;
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00020FE0 File Offset: 0x0001F1E0
	public void SetVolume(float value)
	{
		/*
An exception occurred when decompiling this method (060001B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SoundManager::SetVolume(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_23D:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00021234 File Offset: 0x0001F434
	public void SaveVolumeSettings()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B720]");
		object key = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		float value;
		PlayerPrefs.SetFloat(key, value);
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x000212B4 File Offset: 0x0001F4B4
	public void PlayStarSound()
	{
		this.PlaySound(this.starSound);
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x000212D0 File Offset: 0x0001F4D0
	public void PlayHoopScoreSound()
	{
		this.PlaySound(this.hoopScoreSound);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x000212EC File Offset: 0x0001F4EC
	public void PlayHoopScoreSound2()
	{
		this.PlaySound(this.hoopScoreSound2);
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00021308 File Offset: 0x0001F508
	public void PlayLaserImpact()
	{
		this.PlaySound(this.laserImpactSound);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00004057 File Offset: 0x00002257
	public void PlayLaserLoopSound()
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00004059 File Offset: 0x00002259
	public void StopLaserLoopSound()
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00021324 File Offset: 0x0001F524
	public void PlaySliceSound()
	{
		this.PlaySound(this.sliceSound);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00021340 File Offset: 0x0001F540
	public void PlayPopSound()
	{
		this.PlaySound(this.popSound);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0002135C File Offset: 0x0001F55C
	public void PlayMetalHitSound()
	{
		this.PlaySound(this.metalHitSound);
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00021378 File Offset: 0x0001F578
	public void PlayHoopHitSound(float impactForce)
	{
		/*
An exception occurred when decompiling this method (060001C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SoundManager::PlayHoopHitSound(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_77:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

	// Token: 0x060001C2 RID: 450 RVA: 0x00021408 File Offset: 0x0001F608
	public void PlayNetSound()
	{
		this.PlaySound(this.hoopScoreSound2);
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00021424 File Offset: 0x0001F624
	private void Start()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B720]");
		object key = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		float num2;
		for (;;)
		{
			int @int = PlayerPrefs.GetInt(key);
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			float num;
			this.globalVolume = num;
			object obj;
			bool flag2 = obj == 0;
			if (flag2)
			{
				this.globalVolume = 0.5f;
				PlayerPrefs.SetFloat(key, num2);
			}
			if (this.volumeSlider != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		this.SetVolume(num2);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00021538 File Offset: 0x0001F738
	private void Update()
	{
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
	}

	// Token: 0x040001C6 RID: 454
	public static SoundManager Instance;

	// Token: 0x040001C7 RID: 455
	public AudioSource bounceSound;

	// Token: 0x040001C8 RID: 456
	public AudioSource clickSound;

	// Token: 0x040001C9 RID: 457
	public AudioSource transitionSound;

	// Token: 0x040001CA RID: 458
	public AudioSource starSound;

	// Token: 0x040001CB RID: 459
	public AudioSource netSound;

	// Token: 0x040001CC RID: 460
	public AudioSource hoopScoreSound;

	// Token: 0x040001CD RID: 461
	public AudioSource hoopScoreSound2;

	// Token: 0x040001CE RID: 462
	public AudioSource hoopHitSound;

	// Token: 0x040001CF RID: 463
	public AudioSource laserImpactSound;

	// Token: 0x040001D0 RID: 464
	public AudioSource laserLoopSound;

	// Token: 0x040001D1 RID: 465
	public AudioSource sliceSound;

	// Token: 0x040001D2 RID: 466
	public AudioSource popSound;

	// Token: 0x040001D3 RID: 467
	public AudioSource metalHitSound;

	// Token: 0x040001D4 RID: 468
	public float bounceVolume;

	// Token: 0x040001D5 RID: 469
	public float clickVolume;

	// Token: 0x040001D6 RID: 470
	public float transitionVolume;

	// Token: 0x040001D7 RID: 471
	public float starVolume;

	// Token: 0x040001D8 RID: 472
	public float netVolume;

	// Token: 0x040001D9 RID: 473
	public float hoopScoreVolume;

	// Token: 0x040001DA RID: 474
	public float hoopScoreVolume2;

	// Token: 0x040001DB RID: 475
	public float hoopHitVolume;

	// Token: 0x040001DC RID: 476
	public float laserImpactVolume;

	// Token: 0x040001DD RID: 477
	public float laserLoopVolume;

	// Token: 0x040001DE RID: 478
	public float sliceVolume;

	// Token: 0x040001DF RID: 479
	public float popVolume;

	// Token: 0x040001E0 RID: 480
	public float metalHitVolume;

	// Token: 0x040001E1 RID: 481
	public float minBounceIntensity;

	// Token: 0x040001E2 RID: 482
	public float maxBounceIntensity;

	// Token: 0x040001E3 RID: 483
	public float globalVolume;

	// Token: 0x040001E4 RID: 484
	public Slider volumeSlider;

	// Token: 0x040001E5 RID: 485
	public float soundCooldown;

	// Token: 0x02000089 RID: 137
	private sealed class <PlaySoundAfterTime>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00043958 File Offset: 0x00041B58
		public <PlaySoundAfterTime>d__39(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000040C5 File Offset: 0x000022C5
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00043984 File Offset: 0x00041B84
		bool IEnumerator.MoveNext()
		{
			bool flag = this == 0;
			SoundManager.<PlaySoundAfterTime>d__39 <PlaySoundAfterTime>d__ = this;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				SoundManager.<PlaySoundAfterTime>d__39 <PlaySoundAfterTime>d__2;
				<PlaySoundAfterTime>d__ = <PlaySoundAfterTime>d__2;
			}
			bool result;
			if (this.<>1__state != 0)
			{
				result = (<PlaySoundAfterTime>d__ != null);
			}
			else
			{
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				Console.WriteLine("Method not found @24D67D8");
				WaitForSeconds waitForSeconds;
				float seconds;
				waitForSeconds..ctor(seconds);
				this.<>2__current = waitForSeconds;
				Console.WriteLine("Method not found @24D64EC");
				this.<>1__state = (int)1L;
				bool flag2;
				result = flag2;
			}
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			return result;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00043A98 File Offset: 0x00041C98
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00043AAC File Offset: 0x00041CAC
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (06000377)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void SoundManager/<PlaySoundAfterTime>d__39::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00043B10 File Offset: 0x00041D10
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000413 RID: 1043
		private int <>1__state;

		// Token: 0x04000414 RID: 1044
		private object <>2__current;

		// Token: 0x04000415 RID: 1045
		public float time;

		// Token: 0x04000416 RID: 1046
		public AudioSource sound;
	}
}
