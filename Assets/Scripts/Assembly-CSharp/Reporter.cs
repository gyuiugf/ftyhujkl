using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

// Token: 0x02000050 RID: 80
public class Reporter : MonoBehaviour
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000224 RID: 548 RVA: 0x000273E8 File Offset: 0x000255E8
	public float TotalMemUsage
	{
		get
		{
			float result;
			return result;
		}
	}

	// Token: 0x06000225 RID: 549 RVA: 0x000273FC File Offset: 0x000255FC
	private void Awake()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523B8D8]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B8C8]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B8D0]");
		object obj2 = (IntPtr)0;
		bool flag = ~this.Initialized;
		if (flag)
		{
			this.Initialize();
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		Console.WriteLine("Unmanaged memory load: [v50 @ X0_v11+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		SceneManager.sceneLoaded += obj;
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00027548 File Offset: 0x00025748
	private void OnDestroy()
	{
		Console.WriteLine("Unmanaged memory load: [523B8D8]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B8C8]");
		object method = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B8D0]");
		object obj2 = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor(this, method);
		Console.WriteLine("Unmanaged memory load: [v43 @ X0_v9+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		SceneManager.sceneLoaded -= obj;
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00027664 File Offset: 0x00025864
	private void OnEnable()
	{
		/*
An exception occurred when decompiling this method (06000227)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Reporter::OnEnable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_AD:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00004080 File Offset: 0x00002280
	private void OnDisable()
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00027728 File Offset: 0x00025928
	private void addSample()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BAA8]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Reporter.Sample sample = obj;
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			if (obj != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B8D0]");
				object obj2 = (IntPtr)0;
				sample.fpsText = this.fpsText;
				float num = this.fps;
				Console.WriteLine("Method not found @24D64EC");
				Console.WriteLine("Unmanaged memory load: [v84 @ X0_v13+E4]");
				bool flag2 = (IntPtr)0 == 0;
				if (flag2)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Scene activeScene = SceneManager.GetActiveScene();
				object obj3;
				Scene scene = obj3 + 12L;
				int buildIndex = scene.buildIndex;
				byte loadedScene;
				sample.loadedScene = loadedScene;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				List<object> list = this.samples;
				sample.time = this.fps;
				sample.memory = this.gcTotalMemory;
				if (this.samples != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v73 @ X0_v19 (System.Collections.Generic.List`1<System.Object>)+1C]");
					object obj4 = (IntPtr)0 + 1;
					Console.WriteLine("Unmanaged memory load: [v73 @ X0_v19 (System.Collections.Generic.List`1<System.Object>)+10]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
						this.samples.AddWithResize(obj);
						if (this.samples != 0)
						{
							break;
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		float num2 = Reporter.Sample.MemSize();
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		object obj5 = this.fps * this.gcTotalMemory;
		object obj6 = obj5 * 981467136L;
		float num3 = obj6 * 981467136L;
		this.graphMemUsage = num3;
	}

	// Token: 0x0600022A RID: 554 RVA: 0x000279E8 File Offset: 0x00025BE8
	public void Initialize()
	{
		object obj;
		bool flag = obj - 80L != null;
		bool flag2 = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B8E0]");
		object obj2 = (IntPtr)0;
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
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		string text10;
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v27 @ X8_v1+B8]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj4 = (IntPtr)0;
			if (obj3 != 0)
			{
				goto Block_33;
			}
			GameObject gameObject = base.gameObject;
			if (gameObject != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523B918]");
				object methodName = (IntPtr)0;
				gameObject.SendMessage(methodName);
				Console.WriteLine("Unmanaged memory load: [523B8D0]");
				object obj5 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v133 @ X0_v126+E4]");
				bool flag3 = (IntPtr)0 == 0;
				if (flag3)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				int sceneCountInBuildSettings = SceneManager.sceneCountInBuildSettings;
				Console.WriteLine("Unmanaged memory load: [523B0E8]");
				object obj6 = (IntPtr)0;
				Console.WriteLine("Method not found @24D662C");
				Console.WriteLine("Unmanaged memory load: [v222 @ X8_v14+B8]");
				object obj7 = (IntPtr)0;
				Console.WriteLine("Method not found @24D64EC");
				Scene activeScene = SceneManager.GetActiveScene();
				Scene scene = (flag ? 1L : 0L) + 28L;
				string name = scene.name;
				this.currentScene = name;
				Console.WriteLine("Method not found @24D64EC");
				GameObject gameObject2 = base.gameObject;
				Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
				bool flag4 = ~((IntPtr)0 != 0) != 0;
				if (flag4)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				UnityEngine.Object.DontDestroyOnLoad(gameObject2);
				Console.WriteLine("Unmanaged memory load: [523B8F8]");
				object obj8 = (IntPtr)0;
				Console.WriteLine("Method not found @24D67D8");
				Console.WriteLine("Unmanaged memory load: [523B900]");
				object method = (IntPtr)0;
				obj8..ctor(this, method);
				Console.WriteLine("Unmanaged memory load: [523B130]");
				object obj9 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v294 @ X0_v142+E4]");
				bool flag5 = ~((IntPtr)0 != 0) != 0;
				if (flag5)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Application.logMessageReceivedThreaded += obj8;
				Console.WriteLine("Unmanaged memory load: [v308 @ X8_v23+B8]");
				object obj10 = (IntPtr)0;
				Images images = this.images;
				if (this.images != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523B8F0]");
					object obj11 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523B0F8]");
					object obj12 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523BA70]");
					object obj13 = (IntPtr)0;
					obj11..ctor(obj12, images.clearImage, obj13);
					this.clearContent = obj11;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					if (obj13 != 0)
					{
						Console.WriteLine("Method not found @24D67D8");
						Console.WriteLine("Unmanaged memory load: [523B9F0]");
						object obj14 = (IntPtr)0;
						GUIContent guicontent = obj11;
						string text = obj12;
						Console.WriteLine("Unmanaged memory load: [v412 @ X8_v26+18]");
						guicontent..ctor(text, (IntPtr)0, obj14);
						this.collapseContent = obj11;
						Console.WriteLine("Method not found @24D64EC");
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
						if (obj14 != 0)
						{
							Console.WriteLine("Method not found @24D67D8");
							Console.WriteLine("Unmanaged memory load: [523B9D0]");
							object obj15 = (IntPtr)0;
							GUIContent guicontent2 = obj11;
							string text2 = obj12;
							Console.WriteLine("Unmanaged memory load: [v413 @ X8_v28+20]");
							guicontent2..ctor(text2, (IntPtr)0, obj15);
							this.clearOnNewSceneContent = obj11;
							Console.WriteLine("Method not found @24D64EC");
							Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
							if (obj15 != 0)
							{
								Console.WriteLine("Method not found @24D67D8");
								Console.WriteLine("Unmanaged memory load: [523B9C0]");
								object obj16 = (IntPtr)0;
								GUIContent guicontent3 = obj11;
								string text3 = obj12;
								Console.WriteLine("Unmanaged memory load: [v414 @ X8_v30+28]");
								guicontent3..ctor(text3, (IntPtr)0, obj16);
								this.showTimeContent = obj11;
								Console.WriteLine("Method not found @24D64EC");
								Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
								if (obj16 != 0)
								{
									Console.WriteLine("Method not found @24D67D8");
									Console.WriteLine("Unmanaged memory load: [523B9E0]");
									object obj17 = (IntPtr)0;
									GUIContent guicontent4 = obj11;
									string text4 = obj12;
									Console.WriteLine("Unmanaged memory load: [v415 @ X8_v32+30]");
									guicontent4..ctor(text4, (IntPtr)0, obj17);
									this.showSceneContent = obj11;
									Console.WriteLine("Method not found @24D64EC");
									Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
									if (obj17 != 0)
									{
										Console.WriteLine("Method not found @24D67D8");
										Console.WriteLine("Unmanaged memory load: [523B9A8]");
										object obj18 = (IntPtr)0;
										GUIContent guicontent5 = obj11;
										string text5 = obj12;
										Console.WriteLine("Unmanaged memory load: [v416 @ X8_v34+40]");
										guicontent5..ctor(text5, (IntPtr)0, obj18);
										this.showMemoryContent = obj11;
										Console.WriteLine("Method not found @24D64EC");
										Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
										if (obj18 != 0)
										{
											Console.WriteLine("Method not found @24D67D8");
											Console.WriteLine("Unmanaged memory load: [523BA38]");
											object tooltip = (IntPtr)0;
											GUIContent guicontent6 = obj11;
											string text6 = obj12;
											Console.WriteLine("Unmanaged memory load: [v417 @ X8_v36+48]");
											guicontent6..ctor(text6, (IntPtr)0, tooltip);
											this.softwareContent = obj11;
											Console.WriteLine("Method not found @24D64EC");
											Images images2 = this.images;
											if (this.images != 0)
											{
												Console.WriteLine("Method not found @24D67D8");
												Console.WriteLine("Unmanaged memory load: [523B960]");
												object tooltip2 = (IntPtr)0;
												obj11..ctor(obj12, images2.dateImage, tooltip2);
												this.dateContent = obj11;
												Console.WriteLine("Method not found @24D64EC");
												Images images3 = this.images;
												if (this.images != 0)
												{
													Console.WriteLine("Method not found @24D67D8");
													Console.WriteLine("Unmanaged memory load: [523B948]");
													object tooltip3 = (IntPtr)0;
													obj11..ctor(obj12, images3.showFpsImage, tooltip3);
													this.showFpsContent = obj11;
													Console.WriteLine("Method not found @24D64EC");
													Images images4 = this.images;
													if (this.images != 0)
													{
														Console.WriteLine("Method not found @24D67D8");
														Console.WriteLine("Unmanaged memory load: [523B998]");
														object tooltip4 = (IntPtr)0;
														obj11..ctor(obj12, images4.infoImage, tooltip4);
														this.infoContent = obj11;
														Console.WriteLine("Method not found @24D64EC");
														Images images5 = this.images;
														if (this.images != 0)
														{
															Console.WriteLine("Method not found @24D67D8");
															Console.WriteLine("Unmanaged memory load: [523B9F8]");
															object tooltip5 = (IntPtr)0;
															obj11..ctor(obj12, images5.saveLogsImage, tooltip5);
															this.saveLogsContent = obj11;
															Console.WriteLine("Method not found @24D64EC");
															Images images6 = this.images;
															if (this.images != 0)
															{
																Console.WriteLine("Method not found @24D67D8");
																Console.WriteLine("Unmanaged memory load: [523BA28]");
																object tooltip6 = (IntPtr)0;
																obj11..ctor(obj12, images6.searchImage, tooltip6);
																this.searchContent = obj11;
																Console.WriteLine("Method not found @24D64EC");
																Images images7 = this.images;
																if (this.images != 0)
																{
																	Console.WriteLine("Method not found @24D67D8");
																	Console.WriteLine("Unmanaged memory load: [523B978]");
																	object tooltip7 = (IntPtr)0;
																	obj11..ctor(obj12, images7.copyImage, tooltip7);
																	this.copyContent = obj11;
																	Console.WriteLine("Method not found @24D64EC");
																	Images images8 = this.images;
																	if (this.images != 0)
																	{
																		Console.WriteLine("Method not found @24D67D8");
																		Console.WriteLine("Unmanaged memory load: [523BA08]");
																		object tooltip8 = (IntPtr)0;
																		obj11..ctor(obj12, images8.closeImage, tooltip8);
																		this.closeContent = obj11;
																		Console.WriteLine("Method not found @24D64EC");
																		Images images9 = this.images;
																		if (this.images != 0)
																		{
																			Console.WriteLine("Method not found @24D67D8");
																			Console.WriteLine("Unmanaged memory load: [523B970]");
																			object obj19 = (IntPtr)0;
																			obj11..ctor(obj12, images9.userImage, obj19);
																			this.userContent = obj11;
																			Console.WriteLine("Method not found @24D64EC");
																			Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
																			if (obj19 != 0)
																			{
																				Console.WriteLine("Method not found @24D67D8");
																				Console.WriteLine("Unmanaged memory load: [523B940]");
																				object tooltip9 = (IntPtr)0;
																				GUIContent guicontent7 = obj11;
																				string text7 = obj12;
																				Console.WriteLine("Unmanaged memory load: [v426 @ X8_v62+88]");
																				guicontent7..ctor(text7, (IntPtr)0, tooltip9);
																				this.buildFromContent = obj11;
																				Console.WriteLine("Method not found @24D64EC");
																				Images images10 = this.images;
																				if (this.images != 0)
																				{
																					Console.WriteLine("Method not found @24D67D8");
																					Console.WriteLine("Unmanaged memory load: [523B930]");
																					object tooltip10 = (IntPtr)0;
																					obj11..ctor(obj12, images10.systemInfoImage, tooltip10);
																					this.systemInfoContent = obj11;
																					Console.WriteLine("Method not found @24D64EC");
																					Images images11 = this.images;
																					if (this.images != 0)
																					{
																						Console.WriteLine("Method not found @24D67D8");
																						Console.WriteLine("Unmanaged memory load: [523B950]");
																						object tooltip11 = (IntPtr)0;
																						obj11..ctor(obj12, images11.graphicsInfoImage, tooltip11);
																						this.graphicsInfoContent = obj11;
																						Console.WriteLine("Method not found @24D64EC");
																						Images images12 = this.images;
																						if (this.images != 0)
																						{
																							Console.WriteLine("Method not found @24D67D8");
																							Console.WriteLine("Unmanaged memory load: [523B990]");
																							object tooltip12 = (IntPtr)0;
																							obj11..ctor(obj12, images12.backImage, tooltip12);
																							this.backContent = obj11;
																							Console.WriteLine("Method not found @24D64EC");
																							Images images13 = this.images;
																							if (this.images != 0)
																							{
																								Console.WriteLine("Method not found @24D67D8");
																								Console.WriteLine("Unmanaged memory load: [523B920]");
																								object tooltip13 = (IntPtr)0;
																								obj11..ctor(obj12, images13.logImage, tooltip13);
																								this.logContent = obj11;
																								Console.WriteLine("Method not found @24D64EC");
																								Images images14 = this.images;
																								if (this.images != 0)
																								{
																									Console.WriteLine("Method not found @24D67D8");
																									Console.WriteLine("Unmanaged memory load: [523BA40]");
																									object tooltip14 = (IntPtr)0;
																									obj11..ctor(obj12, images14.warningImage, tooltip14);
																									this.warningContent = obj11;
																									Console.WriteLine("Method not found @24D64EC");
																									Images images15 = this.images;
																									if (this.images != 0)
																									{
																										Console.WriteLine("Method not found @24D67D8");
																										Console.WriteLine("Unmanaged memory load: [523BA50]");
																										object tooltip15 = (IntPtr)0;
																										obj11..ctor(obj12, images15.errorImage, tooltip15);
																										this.errorContent = obj11;
																										Console.WriteLine("Method not found @24D64EC");
																										Console.WriteLine("Unmanaged memory load: [523B9C8]");
																										object key = (IntPtr)0;
																										int @int = PlayerPrefs.GetInt(key, obj11);
																										Console.WriteLine("Unmanaged memory load: [523B928]");
																										object key2 = (IntPtr)0;
																										Reporter.ReportView reportView;
																										this.currentView = reportView;
																										int int2 = PlayerPrefs.GetInt(key2);
																										Console.WriteLine("Unmanaged memory load: [523BA18]");
																										object key3 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.show = ((IntPtr)0 != 0);
																										int int3 = PlayerPrefs.GetInt(key3);
																										Console.WriteLine("Unmanaged memory load: [523B908]");
																										object key4 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.collapse = ((IntPtr)0 != 0);
																										int int4 = PlayerPrefs.GetInt(key4);
																										Console.WriteLine("Unmanaged memory load: [523BA00]");
																										object key5 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.clearOnNewSceneLoaded = ((IntPtr)0 != 0);
																										int int5 = PlayerPrefs.GetInt(key5);
																										Console.WriteLine("Unmanaged memory load: [523BA58]");
																										object key6 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showTime = ((IntPtr)0 != 0);
																										int int6 = PlayerPrefs.GetInt(key6);
																										Console.WriteLine("Unmanaged memory load: [523BA48]");
																										object key7 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showScene = ((IntPtr)0 != 0);
																										int int7 = PlayerPrefs.GetInt(key7);
																										Console.WriteLine("Unmanaged memory load: [523B9B8]");
																										object key8 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showMemory = ((IntPtr)0 != 0);
																										int int8 = PlayerPrefs.GetInt(key8);
																										Console.WriteLine("Unmanaged memory load: [523B988]");
																										object key9 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showFps = ((IntPtr)0 != 0);
																										int int9 = PlayerPrefs.GetInt(key9);
																										Console.WriteLine("Unmanaged memory load: [523B980]");
																										object key10 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showGraph = ((IntPtr)0 != 0);
																										int int10 = PlayerPrefs.GetInt(key10, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B9E8]");
																										object key11 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showLog = ((IntPtr)0 != 0);
																										int int11 = PlayerPrefs.GetInt(key11, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523BA20]");
																										object key12 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showWarning = ((IntPtr)0 != 0);
																										int int12 = PlayerPrefs.GetInt(key12, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523BA30]");
																										object key13 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showError = ((IntPtr)0 != 0);
																										string @string = PlayerPrefs.GetString(key13);
																										this.filterText = @string;
																										Console.WriteLine("Method not found @24D64EC");
																										Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [523BA60]");
																										object key14 = (IntPtr)0;
																										float defaultValue;
																										float @float = PlayerPrefs.GetFloat(key14, defaultValue);
																										Console.WriteLine("Unmanaged memory load: [523B910]");
																										object key15 = (IntPtr)0;
																										Vector2 vector;
																										this.size = vector;
																										int int13 = PlayerPrefs.GetInt(key15, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B938]");
																										object key16 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showClearOnNewSceneLoadedButton = ((IntPtr)0 != 0);
																										int int14 = PlayerPrefs.GetInt(key16, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B9A0]");
																										object key17 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showTimeButton = ((IntPtr)0 != 0);
																										int int15 = PlayerPrefs.GetInt(key17, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B9B0]");
																										object key18 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showSceneButton = ((IntPtr)0 != 0);
																										int int16 = PlayerPrefs.GetInt(key18, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523BA68]");
																										object key19 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showMemButton = ((IntPtr)0 != 0);
																										int int17 = PlayerPrefs.GetInt(key19, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B9D8]");
																										object key20 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showFpsButton = ((IntPtr)0 != 0);
																										int int18 = PlayerPrefs.GetInt(key20, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B968]");
																										object key21 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showSearchText = ((IntPtr)0 != 0);
																										int int19 = PlayerPrefs.GetInt(key21, flag ? 1 : 0);
																										Console.WriteLine("Unmanaged memory load: [523B958]");
																										object key22 = (IntPtr)0;
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v255 @ X8_v16+E4]");
																										this.showCopyButton = ((IntPtr)0 != 0);
																										int int20 = PlayerPrefs.GetInt(key22, flag ? 1 : 0);
																										Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
																										Console.WriteLine("Unmanaged memory load: [v294 @ X0_v142+E4]");
																										this.showSaveButton = ((IntPtr)0 != 0);
																										this.initializeStyle();
																										this.Initialized = (1L != 0L);
																										if (!(~this.show))
																										{
																											this.doShow();
																										}
																										string text8 = SystemInfo.deviceModel;
																										if (text8 != 0)
																										{
																											Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
																											this.deviceModel = text8;
																											Console.WriteLine("Method not found @24D64EC");
																											DeviceType deviceType = SystemInfo.deviceType;
																											object obj20 = ~0L;
																											Console.WriteLine("Unmanaged memory load: [523B8E8]");
																											object value = (IntPtr)0;
																											Enum @enum = (flag ? 1L : 0L) + 0L;
																											flag.m_value = (value != null);
																											string text9 = @enum.ToString();
																											this.deviceType = text9;
																											Console.WriteLine("Method not found @24D64EC");
																											text10 = SystemInfo.deviceName;
																											if (text10 != 0)
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
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
		}
		Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
		this.deviceName = text10;
		Console.WriteLine("Method not found @24D64EC");
		int num = SystemInfo.graphicsMemorySize;
		int num2 = (int)((flag ? 1L : 0L) + 24L);
		string text11 = num2.ToString();
		this.graphicsMemorySize = text11;
		Console.WriteLine("Method not found @24D64EC");
		int num3 = SystemInfo.maxTextureSize;
		int num4 = (int)((flag ? 1L : 0L) + 24L);
		string text12 = num4.ToString();
		this.maxTextureSize = text12;
		Console.WriteLine("Method not found @24D64EC");
		int num5 = SystemInfo.systemMemorySize;
		int num6 = (int)((flag ? 1L : 0L) + 24L);
		string text13 = num6.ToString();
		this.systemMemorySize = text13;
		Console.WriteLine("Method not found @24D64EC");
		return;
		Block_33:
		Console.WriteLine("Unmanaged memory load: [523B018]");
		object obj21 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BA10]");
		object message = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v42 @ X0_v117+E4]");
		bool flag6 = (IntPtr)0 == 0;
		if (flag6)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Debug.LogWarning(message);
		GameObject gameObject3 = base.gameObject;
		Console.WriteLine("Unmanaged memory load: [v123 @ X8_v6+E4]");
		bool flag7 = (IntPtr)0 == 0;
		if (flag7)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		UnityEngine.Object.DestroyImmediate(gameObject3, flag);
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00029268 File Offset: 0x00027468
	private void initializeStyle()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BAC0]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		float num2;
		GUIStyle horizontalScrollbarThumb3;
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			Console.WriteLine("Method not found @24D67D8");
			obj..ctor();
			this.nonStyle = obj;
			Console.WriteLine("Method not found @24D64EC");
			if (this.nonStyle != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523BAD0]");
				object obj2 = (IntPtr)0;
				this.nonStyle.clipping = obj;
				Console.WriteLine("Method not found @24D67D8");
				int num;
				int top;
				int bottom;
				obj2..ctor(obj, num, top, bottom);
				if (this.nonStyle != 0)
				{
					this.nonStyle.border = obj2;
					if (this.nonStyle != 0)
					{
						GUIStyleState normal = this.nonStyle.normal;
						if (normal != 0)
						{
							normal.background = num;
							if (this.nonStyle != 0)
							{
								Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
								Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
								Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
								this.nonStyle.fontSize = num;
								if (this.nonStyle != 0)
								{
									this.nonStyle.alignment = (TextAnchor)num;
									Console.WriteLine("Method not found @24D67D8");
									obj..ctor();
									this.lowerLeftFontStyle = obj;
									Console.WriteLine("Method not found @24D64EC");
									if (this.lowerLeftFontStyle != 0)
									{
										this.lowerLeftFontStyle.clipping = obj;
										Console.WriteLine("Method not found @24D67D8");
										obj2..ctor(obj, num, top, bottom);
										if (this.lowerLeftFontStyle != 0)
										{
											this.lowerLeftFontStyle.border = obj2;
											if (this.lowerLeftFontStyle != 0)
											{
												GUIStyleState normal2 = this.lowerLeftFontStyle.normal;
												if (normal2 != 0)
												{
													normal2.background = num;
													if (this.lowerLeftFontStyle != 0)
													{
														Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
														Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
														this.lowerLeftFontStyle.fontSize = num;
														if (this.lowerLeftFontStyle != 0)
														{
															this.lowerLeftFontStyle.fontStyle = (FontStyle)num;
															if (this.lowerLeftFontStyle != 0)
															{
																this.lowerLeftFontStyle.alignment = (TextAnchor)num;
																Console.WriteLine("Method not found @24D67D8");
																obj..ctor();
																this.barStyle = obj;
																Console.WriteLine("Method not found @24D64EC");
																Console.WriteLine("Method not found @24D67D8");
																obj2..ctor(obj, num, top, bottom);
																if (this.barStyle != 0)
																{
																	this.barStyle.border = obj2;
																	if (this.barStyle != 0)
																	{
																		GUIStyleState normal3 = this.barStyle.normal;
																		Images images = this.images;
																		if (this.images != 0 && normal3 != 0)
																		{
																			normal3.background = images.barImage;
																			if (this.barStyle != 0)
																			{
																				GUIStyleState active = this.barStyle.active;
																				Images images2 = this.images;
																				if (this.images != 0 && active != 0)
																				{
																					active.background = images2.button_activeImage;
																					if (this.barStyle != 0)
																					{
																						this.barStyle.alignment = images2.button_activeImage;
																						Console.WriteLine("Method not found @24D67D8");
																						obj2..ctor(images2.button_activeImage, num, top, bottom);
																						if (this.barStyle != 0)
																						{
																							this.barStyle.margin = obj2;
																							if (this.barStyle != 0)
																							{
																								this.barStyle.clipping = obj2;
																								if (this.barStyle != 0)
																								{
																									Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																									Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																									Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																									this.barStyle.fontSize = obj2;
																									Console.WriteLine("Method not found @24D67D8");
																									obj..ctor();
																									this.buttonActiveStyle = obj;
																									Console.WriteLine("Method not found @24D64EC");
																									Console.WriteLine("Method not found @24D67D8");
																									obj2..ctor(obj, num, top, bottom);
																									if (this.buttonActiveStyle != 0)
																									{
																										this.buttonActiveStyle.border = obj2;
																										if (this.buttonActiveStyle != 0)
																										{
																											GUIStyleState normal4 = this.buttonActiveStyle.normal;
																											Images images3 = this.images;
																											if (this.images != 0 && normal4 != 0)
																											{
																												normal4.background = images3.button_activeImage;
																												if (this.buttonActiveStyle != 0)
																												{
																													this.buttonActiveStyle.alignment = images3.button_activeImage;
																													Console.WriteLine("Method not found @24D67D8");
																													obj2..ctor(images3.button_activeImage, num, top, bottom);
																													if (this.buttonActiveStyle != 0)
																													{
																														this.buttonActiveStyle.margin = obj2;
																														if (this.buttonActiveStyle != 0)
																														{
																															Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																															Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																															Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																															this.buttonActiveStyle.fontSize = obj2;
																															Console.WriteLine("Method not found @24D67D8");
																															obj..ctor();
																															this.backStyle = obj;
																															Console.WriteLine("Method not found @24D64EC");
																															if (this.backStyle != 0)
																															{
																																GUIStyleState normal5 = this.backStyle.normal;
																																Images images4 = this.images;
																																if (this.images != 0 && normal5 != 0)
																																{
																																	normal5.background = images4.even_logImage;
																																	if (this.backStyle != 0)
																																	{
																																		this.backStyle.clipping = images4.even_logImage;
																																		if (this.backStyle != 0)
																																		{
																																			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																			this.backStyle.fontSize = images4.even_logImage;
																																			Console.WriteLine("Method not found @24D67D8");
																																			obj..ctor();
																																			this.evenLogStyle = obj;
																																			Console.WriteLine("Method not found @24D64EC");
																																			if (this.evenLogStyle != 0)
																																			{
																																				GUIStyleState normal6 = this.evenLogStyle.normal;
																																				Images images5 = this.images;
																																				if (this.images != 0 && normal6 != 0)
																																				{
																																					normal6.background = images5.even_logImage;
																																					if (this.evenLogStyle != 0)
																																					{
																																						this.evenLogStyle.fixedHeight = num2;
																																						if (this.evenLogStyle != 0)
																																						{
																																							this.evenLogStyle.clipping = (TextClipping)num;
																																							if (this.evenLogStyle != 0)
																																							{
																																								this.evenLogStyle.alignment = (TextAnchor)num;
																																								if (this.evenLogStyle != 0)
																																								{
																																									this.evenLogStyle.imagePosition = (ImagePosition)num;
																																									if (this.evenLogStyle != 0)
																																									{
																																										Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																										Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																										Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																										this.evenLogStyle.fontSize = num;
																																										Console.WriteLine("Method not found @24D67D8");
																																										obj..ctor();
																																										this.oddLogStyle = obj;
																																										Console.WriteLine("Method not found @24D64EC");
																																										if (this.oddLogStyle != 0)
																																										{
																																											GUIStyleState normal7 = this.oddLogStyle.normal;
																																											Images images6 = this.images;
																																											if (this.images != 0 && normal7 != 0)
																																											{
																																												normal7.background = images6.odd_logImage;
																																												if (this.oddLogStyle != 0)
																																												{
																																													this.oddLogStyle.fixedHeight = num2;
																																													if (this.oddLogStyle != 0)
																																													{
																																														this.oddLogStyle.clipping = (TextClipping)num;
																																														if (this.oddLogStyle != 0)
																																														{
																																															this.oddLogStyle.alignment = (TextAnchor)num;
																																															if (this.oddLogStyle != 0)
																																															{
																																																this.oddLogStyle.imagePosition = (ImagePosition)num;
																																																if (this.oddLogStyle != 0)
																																																{
																																																	Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																																	Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																																	Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																																	this.oddLogStyle.fontSize = num;
																																																	Console.WriteLine("Method not found @24D67D8");
																																																	obj..ctor();
																																																	this.logButtonStyle = obj;
																																																	Console.WriteLine("Method not found @24D64EC");
																																																	if (this.logButtonStyle != 0)
																																																	{
																																																		this.logButtonStyle.fixedHeight = num2;
																																																		if (this.logButtonStyle != 0)
																																																		{
																																																			this.logButtonStyle.clipping = (TextClipping)num;
																																																			if (this.logButtonStyle != 0)
																																																			{
																																																				this.logButtonStyle.alignment = (TextAnchor)num;
																																																				if (this.logButtonStyle != 0)
																																																				{
																																																					Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																																					Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																																					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																																					this.logButtonStyle.fontSize = num;
																																																					Console.WriteLine("Method not found @24D67D8");
																																																					obj2..ctor(num, num, top, bottom);
																																																					if (this.logButtonStyle != 0)
																																																					{
																																																						this.logButtonStyle.padding = obj2;
																																																						Console.WriteLine("Method not found @24D67D8");
																																																						obj..ctor();
																																																						this.selectedLogStyle = obj;
																																																						Console.WriteLine("Method not found @24D64EC");
																																																						if (this.selectedLogStyle != 0)
																																																						{
																																																							GUIStyleState normal8 = this.selectedLogStyle.normal;
																																																							Images images7 = this.images;
																																																							if (this.images != 0 && normal8 != 0)
																																																							{
																																																								normal8.background = images7.selectedImage;
																																																								if (this.selectedLogStyle != 0)
																																																								{
																																																									this.selectedLogStyle.fixedHeight = num2;
																																																									if (this.selectedLogStyle != 0)
																																																									{
																																																										this.selectedLogStyle.clipping = (TextClipping)num;
																																																										if (this.selectedLogStyle != 0)
																																																										{
																																																											this.selectedLogStyle.alignment = (TextAnchor)num;
																																																											if (this.selectedLogStyle != 0)
																																																											{
																																																												GUIStyleState normal9 = this.selectedLogStyle.normal;
																																																												if (normal9 != 0)
																																																												{
																																																													normal9.textColor = num;
																																																													if (this.selectedLogStyle != 0)
																																																													{
																																																														Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																																														Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																																														Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																																														this.selectedLogStyle.fontSize = num;
																																																														Console.WriteLine("Method not found @24D67D8");
																																																														obj..ctor();
																																																														this.selectedLogFontStyle = obj;
																																																														Console.WriteLine("Method not found @24D64EC");
																																																														if (this.selectedLogFontStyle != 0)
																																																														{
																																																															GUIStyleState normal10 = this.selectedLogFontStyle.normal;
																																																															Images images8 = this.images;
																																																															if (this.images != 0 && normal10 != 0)
																																																															{
																																																																normal10.background = images8.selectedImage;
																																																																if (this.selectedLogFontStyle != 0)
																																																																{
																																																																	this.selectedLogFontStyle.fixedHeight = num2;
																																																																	if (this.selectedLogFontStyle != 0)
																																																																	{
																																																																		this.selectedLogFontStyle.clipping = (TextClipping)num;
																																																																		if (this.selectedLogFontStyle != 0)
																																																																		{
																																																																			this.selectedLogFontStyle.alignment = (TextAnchor)num;
																																																																			if (this.selectedLogFontStyle != 0)
																																																																			{
																																																																				GUIStyleState normal11 = this.selectedLogFontStyle.normal;
																																																																				if (normal11 != 0)
																																																																				{
																																																																					normal11.textColor = num;
																																																																					if (this.selectedLogFontStyle != 0)
																																																																					{
																																																																						Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																																																						Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																																																						Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																																																						this.selectedLogFontStyle.fontSize = num;
																																																																						Console.WriteLine("Method not found @24D67D8");
																																																																						obj2..ctor(num, num, top, bottom);
																																																																						if (this.selectedLogFontStyle != 0)
																																																																						{
																																																																							this.selectedLogFontStyle.padding = obj2;
																																																																							Console.WriteLine("Method not found @24D67D8");
																																																																							obj..ctor();
																																																																							this.stackLabelStyle = obj;
																																																																							Console.WriteLine("Method not found @24D64EC");
																																																																							if (this.stackLabelStyle != 0)
																																																																							{
																																																																								this.stackLabelStyle.wordWrap = (obj != null);
																																																																								if (this.stackLabelStyle != 0)
																																																																								{
																																																																									Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																																																									Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																																																									Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																																																									this.stackLabelStyle.fontSize = obj;
																																																																									Console.WriteLine("Method not found @24D67D8");
																																																																									obj2..ctor(obj, num, top, bottom);
																																																																									if (this.stackLabelStyle != 0)
																																																																									{
																																																																										this.stackLabelStyle.padding = obj2;
																																																																										Console.WriteLine("Method not found @24D67D8");
																																																																										obj..ctor();
																																																																										this.scrollerStyle = obj;
																																																																										Console.WriteLine("Method not found @24D64EC");
																																																																										if (this.scrollerStyle != 0)
																																																																										{
																																																																											GUIStyleState normal12 = this.scrollerStyle.normal;
																																																																											Images images9 = this.images;
																																																																											if (this.images != 0 && normal12 != 0)
																																																																											{
																																																																												normal12.background = images9.barImage;
																																																																												Console.WriteLine("Method not found @24D67D8");
																																																																												obj..ctor();
																																																																												this.searchStyle = obj;
																																																																												Console.WriteLine("Method not found @24D64EC");
																																																																												if (this.searchStyle != 0)
																																																																												{
																																																																													this.searchStyle.clipping = obj;
																																																																													if (this.searchStyle != 0)
																																																																													{
																																																																														this.searchStyle.alignment = obj;
																																																																														if (this.searchStyle != 0)
																																																																														{
																																																																															Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
																																																																															Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
																																																																															Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
																																																																															this.searchStyle.fontSize = obj;
																																																																															if (this.searchStyle != 0)
																																																																															{
																																																																																this.searchStyle.wordWrap = (obj != null);
																																																																																Console.WriteLine("Method not found @24D67D8");
																																																																																obj..ctor();
																																																																																this.sliderBackStyle = obj;
																																																																																Console.WriteLine("Method not found @24D64EC");
																																																																																if (this.sliderBackStyle != 0)
																																																																																{
																																																																																	GUIStyleState normal13 = this.sliderBackStyle.normal;
																																																																																	Images images10 = this.images;
																																																																																	if (this.images != 0 && normal13 != 0)
																																																																																	{
																																																																																		normal13.background = images10.barImage;
																																																																																		if (this.sliderBackStyle != 0)
																																																																																		{
																																																																																			this.sliderBackStyle.fixedHeight = num2;
																																																																																			Console.WriteLine("Method not found @24D67D8");
																																																																																			obj2..ctor(num, num, top, bottom);
																																																																																			if (this.sliderBackStyle != 0)
																																																																																			{
																																																																																				this.sliderBackStyle.border = obj2;
																																																																																				Console.WriteLine("Method not found @24D67D8");
																																																																																				obj..ctor();
																																																																																				this.sliderThumbStyle = obj;
																																																																																				Console.WriteLine("Method not found @24D64EC");
																																																																																				if (this.sliderThumbStyle != 0)
																																																																																				{
																																																																																					GUIStyleState normal14 = this.sliderThumbStyle.normal;
																																																																																					Images images11 = this.images;
																																																																																					if (this.images != 0 && normal14 != 0)
																																																																																					{
																																																																																						normal14.background = images11.selectedImage;
																																																																																						if (this.sliderThumbStyle != 0)
																																																																																						{
																																																																																							this.sliderThumbStyle.fixedWidth = num2;
																																																																																							Images images12 = this.images;
																																																																																							if (this.images != 0)
																																																																																							{
																																																																																								Console.WriteLine("Unmanaged memory load: [523ADE0]");
																																																																																								object obj3 = (IntPtr)0;
																																																																																								Console.WriteLine("Unmanaged memory load: [v1201 @ X0_v135+E4]");
																																																																																								bool flag2 = (IntPtr)0 == 0;
																																																																																								if (flag2)
																																																																																								{
																																																																																									Console.WriteLine("Method not found @24D66BC");
																																																																																								}
																																																																																								Console.WriteLine("Method not found @29B33F4");
																																																																																								this.toolbarScrollerSkin = images12.reporterScrollerSkin;
																																																																																								Console.WriteLine("Method not found @24D64EC");
																																																																																								if (this.toolbarScrollerSkin != 0)
																																																																																								{
																																																																																									GUIStyle verticalScrollbar = this.toolbarScrollerSkin.verticalScrollbar;
																																																																																									if (verticalScrollbar != 0)
																																																																																									{
																																																																																										Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																										verticalScrollbar.fixedWidth = num2;
																																																																																										if (this.toolbarScrollerSkin != 0)
																																																																																										{
																																																																																											GUIStyle horizontalScrollbar = this.toolbarScrollerSkin.horizontalScrollbar;
																																																																																											if (horizontalScrollbar != 0)
																																																																																											{
																																																																																												Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																												horizontalScrollbar.fixedHeight = num2;
																																																																																												if (this.toolbarScrollerSkin != 0)
																																																																																												{
																																																																																													GUIStyle verticalScrollbarThumb = this.toolbarScrollerSkin.verticalScrollbarThumb;
																																																																																													if (verticalScrollbarThumb != 0)
																																																																																													{
																																																																																														Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																														verticalScrollbarThumb.fixedWidth = num2;
																																																																																														if (this.toolbarScrollerSkin != 0)
																																																																																														{
																																																																																															GUIStyle horizontalScrollbarThumb = this.toolbarScrollerSkin.horizontalScrollbarThumb;
																																																																																															if (horizontalScrollbarThumb != 0)
																																																																																															{
																																																																																																Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																																horizontalScrollbarThumb.fixedHeight = num2;
																																																																																																Console.WriteLine("Method not found @29B33F4");
																																																																																																this.logScrollerSkin = images12.reporterScrollerSkin;
																																																																																																Console.WriteLine("Method not found @24D64EC");
																																																																																																if (this.logScrollerSkin != 0)
																																																																																																{
																																																																																																	GUIStyle verticalScrollbar2 = this.logScrollerSkin.verticalScrollbar;
																																																																																																	if (verticalScrollbar2 != 0)
																																																																																																	{
																																																																																																		verticalScrollbar2.fixedWidth = num2;
																																																																																																		if (this.logScrollerSkin != 0)
																																																																																																		{
																																																																																																			GUIStyle horizontalScrollbar2 = this.logScrollerSkin.horizontalScrollbar;
																																																																																																			if (horizontalScrollbar2 != 0)
																																																																																																			{
																																																																																																				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																																				horizontalScrollbar2.fixedHeight = num2;
																																																																																																				if (this.logScrollerSkin != 0)
																																																																																																				{
																																																																																																					GUIStyle verticalScrollbarThumb2 = this.logScrollerSkin.verticalScrollbarThumb;
																																																																																																					if (verticalScrollbarThumb2 != 0)
																																																																																																					{
																																																																																																						verticalScrollbarThumb2.fixedWidth = num2;
																																																																																																						if (this.logScrollerSkin != 0)
																																																																																																						{
																																																																																																							GUIStyle horizontalScrollbarThumb2 = this.logScrollerSkin.horizontalScrollbarThumb;
																																																																																																							if (horizontalScrollbarThumb2 != 0)
																																																																																																							{
																																																																																																								Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																																								horizontalScrollbarThumb2.fixedHeight = num2;
																																																																																																								Console.WriteLine("Method not found @29B33F4");
																																																																																																								object obj4 = this + 512L;
																																																																																																								this.graphScrollerSkin = images12.reporterScrollerSkin;
																																																																																																								Console.WriteLine("Method not found @24D64EC");
																																																																																																								if (this.graphScrollerSkin != 0)
																																																																																																								{
																																																																																																									GUIStyle verticalScrollbar3 = this.graphScrollerSkin.verticalScrollbar;
																																																																																																									if (verticalScrollbar3 != 0)
																																																																																																									{
																																																																																																										Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																																										verticalScrollbar3.fixedWidth = num2;
																																																																																																										if (obj4 != 0)
																																																																																																										{
																																																																																																											GUIStyle horizontalScrollbar3 = obj4.horizontalScrollbar;
																																																																																																											if (horizontalScrollbar3 != 0)
																																																																																																											{
																																																																																																												horizontalScrollbar3.fixedHeight = num2;
																																																																																																												if (this.graphScrollerSkin != 0)
																																																																																																												{
																																																																																																													GUIStyle verticalScrollbarThumb3 = this.graphScrollerSkin.verticalScrollbarThumb;
																																																																																																													if (verticalScrollbarThumb3 != 0)
																																																																																																													{
																																																																																																														Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
																																																																																																														verticalScrollbarThumb3.fixedWidth = num2;
																																																																																																														if (obj4 != 0)
																																																																																																														{
																																																																																																															horizontalScrollbarThumb3 = obj4.horizontalScrollbarThumb;
																																																																																																															if (horizontalScrollbarThumb3 != 0)
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
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		horizontalScrollbarThumb3.fixedHeight = num2;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0002AFA0 File Offset: 0x000291A0
	private void Start()
	{
		object obj2;
		object obj = obj2 - 48L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B7A0]");
		object obj3 = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523BAE8]");
		object methodName = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v25 @ X0_v6+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = obj + 8L;
		string text = dateTime.ToString();
		this.logDate = text;
		Console.WriteLine("Method not found @24D64EC");
		Coroutine coroutine = base.StartCoroutine(methodName);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0002B0E8 File Offset: 0x000292E8
	private void clear()
	{
		Reporter.Log log;
		int count;
		log.count = count;
		string condition;
		log.condition = condition;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			List<Reporter.Log> list = this.logs;
			if (this.logs != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v21 @ X8_v1 (System.Collections.Generic.List`1<Reporter+Log>)+1C]");
				object obj = (IntPtr)0 + 1;
				List<Reporter.Log> list2 = this.collapsedLogs;
				if (this.collapsedLogs != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v36 @ X8_v3 (System.Collections.Generic.List`1<Reporter+Log>)+1C]");
					object obj2 = (IntPtr)0 + 1;
					List<Reporter.Log> list3 = this.currentLog;
					if (this.currentLog != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v37 @ X8_v4 (System.Collections.Generic.List`1<Reporter+Log>)+1C]");
						object obj3 = (IntPtr)0 + 1;
						if (this.logsDic != 0)
						{
							this.logsDic.Clear();
							object obj4 = this + 784L;
							this.selectedLog = log;
							Console.WriteLine("Method not found @24D64EC");
							List<Reporter.Sample> list4 = this.samples;
							this.logsMemUsage = log;
							this.numOfLogs = log;
							this.numOfCollapsedLogsWarning = log;
							this.numOfLogsError = log;
							if (this.samples != 0)
							{
								break;
							}
						}
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Unmanaged memory load: [523BA90]");
		object obj5 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v38 @ X8_v7 (System.Collections.Generic.List`1<Reporter+Sample>)+1C]");
		object obj6 = (IntPtr)0 + 1;
		Console.WriteLine("Unmanaged memory load: [v103 @ X0_v13+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		GC.Collect();
		Console.WriteLine("Method not found @24D64EC");
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0002B3BC File Offset: 0x000295BC
	private void calculateCurrentLog()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [5592176]");
		bool flag2 = (IntPtr)0 != 0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			flag2 = (1L != 0L);
		}
		bool flag3 = string.IsNullOrEmpty(this.filterText);
		object obj;
		bool flag4 = obj == 0;
		object obj2 = !flag4;
		string text;
		if (obj2 == null)
		{
			Console.WriteLine("Unmanaged memory load: [523B0F8]");
			object obj3 = (IntPtr)0;
			text = obj3;
			goto IL_44C;
		}
		bool flag5 = this.filterText == 0;
		object obj5;
		object obj4 = obj5;
		object obj7;
		object obj6 = obj7;
		object obj9;
		object obj8 = obj9;
		object obj11;
		object obj10 = obj11;
		object obj13;
		object obj12 = obj13;
		string text3;
		string text2 = text3;
		List<Reporter.Log> list2;
		List<Reporter.Log> list = list2;
		object obj14 = obj2;
		bool flag6 = flag2;
		if (!flag5)
		{
			string text4 = this.filterText.ToLower();
			text = text4;
			goto IL_44C;
		}
		IL_2F5:
		Console.WriteLine("Method not found @24D67E8");
		object obj15 = obj4;
		object obj16 = obj6;
		object obj17 = obj8;
		object obj18 = obj10;
		object obj19 = obj12;
		string text5 = text2;
		List<Reporter.Log> list3 = list;
		object obj20 = obj14;
		bool flag7 = flag6;
		IL_34C:
		if (this.selectedLog != 0)
		{
			bool flag8 = this.currentLog == 0;
			obj4 = obj15;
			obj6 = obj16;
			obj8 = obj17;
			obj10 = obj18;
			obj12 = obj19;
			text2 = text5;
			list = list3;
			obj14 = obj20;
			flag6 = flag7;
			if (flag8)
			{
				goto IL_2F5;
			}
			int num = this.currentLog.IndexOf(this.selectedLog);
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj22;
			object obj21 = (IntPtr)0 * obj22;
		}
		return;
		IL_44C:
		List<Reporter.Log> list4 = this.currentLog;
		bool flag9 = this.currentLog == 0;
		obj4 = obj5;
		obj6 = obj7;
		obj8 = obj9;
		obj10 = obj11;
		obj12 = obj13;
		text2 = text;
		list = this.currentLog;
		obj14 = obj2;
		flag6 = flag2;
		if (flag9)
		{
			goto IL_2F5;
		}
		Console.WriteLine("Unmanaged memory load: [v60 @ X8_v6 (System.Collections.Generic.List`1<Reporter+Log>)+1C]");
		object obj23 = (IntPtr)0 + 1;
		Console.WriteLine("Unmanaged memory load: [v60 @ X8_v6 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
		object obj24 = (IntPtr)0 - 1;
		if (!(~this.collapse))
		{
			List<Reporter.Log> list5 = this.collapsedLogs;
			bool flag10 = this.collapsedLogs == 0;
			obj4 = obj5;
			Console.WriteLine("Unmanaged memory load: [523BAF8]");
			obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BB08]");
			obj8 = (IntPtr)0;
			obj10 = obj23;
			Console.WriteLine("Unmanaged memory load: [v60 @ X8_v6 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
			obj12 = (IntPtr)0;
			text2 = text;
			list = this.currentLog;
			obj14 = obj24;
			flag6 = this.collapse;
			if (!flag10)
			{
				object obj26;
				object obj25 = obj26;
				Console.WriteLine("Unmanaged memory load: [v88 @ X0_v28 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
				object obj27 = obj25 - (IntPtr)0;
				obj15 = obj26;
				Console.WriteLine("Unmanaged memory load: [523BAF8]");
				obj16 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523BB08]");
				obj17 = (IntPtr)0;
				obj18 = obj23;
				Console.WriteLine("Unmanaged memory load: [v60 @ X8_v6 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
				obj19 = (IntPtr)0;
				text5 = text;
				list3 = this.currentLog;
				obj20 = obj27;
				Console.WriteLine("Unmanaged memory load: [v88 @ X0_v28 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
				flag7 = ((IntPtr)0 != 0);
				goto IL_34C;
			}
			goto IL_2F5;
		}
		else
		{
			List<Reporter.Log> list6 = this.logs;
			bool flag11 = this.logs == 0;
			obj4 = obj5;
			Console.WriteLine("Unmanaged memory load: [523BAF8]");
			obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BB08]");
			obj8 = (IntPtr)0;
			obj10 = obj23;
			Console.WriteLine("Unmanaged memory load: [v60 @ X8_v6 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
			obj12 = (IntPtr)0;
			text2 = text;
			list = this.currentLog;
			obj14 = obj24;
			flag6 = this.collapse;
			if (!flag11)
			{
				object obj26;
				object obj28 = obj26;
				Console.WriteLine("Unmanaged memory load: [v89 @ X0_v29 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
				object obj29 = obj28 - (IntPtr)0;
				obj15 = obj26;
				Console.WriteLine("Unmanaged memory load: [523BAF8]");
				obj16 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [523BB08]");
				obj17 = (IntPtr)0;
				obj18 = obj23;
				Console.WriteLine("Unmanaged memory load: [v60 @ X8_v6 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
				obj19 = (IntPtr)0;
				text5 = text;
				list3 = this.currentLog;
				obj20 = obj29;
				Console.WriteLine("Unmanaged memory load: [v89 @ X0_v29 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
				flag7 = ((IntPtr)0 != 0);
				goto IL_34C;
			}
			goto IL_2F5;
		}
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0002B990 File Offset: 0x00029B90
	private void DrawInfo()
	{
		object obj;
		GUIStyle guistyle = obj - 128L;
		IntPtr ptr;
		guistyle.m_Ptr = ptr;
		GUIStyleState hover;
		guistyle.m_Hover = hover;
		GUIStyleState active;
		guistyle.m_Active = active;
		GUIStyleState focused;
		guistyle.m_Focused = focused;
		GUIStyleState onNormal;
		guistyle.m_OnNormal = onNormal;
		GUIStyleState onHover;
		guistyle.m_OnHover = onHover;
		GUIStyleState onActive;
		guistyle.m_OnActive = onActive;
		GUIStyleState onFocused;
		guistyle.m_OnFocused = onFocused;
		RectOffset border;
		guistyle.m_Border = border;
		RectOffset padding;
		guistyle.m_Padding = padding;
		RectOffset margin;
		guistyle.m_Margin = margin;
		RectOffset overflow;
		guistyle.m_Overflow = overflow;
		string name;
		guistyle.m_Name = name;
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
			guistyle.m_Normal = guistyle;
			GUILayout.BeginArea(this.backStyle, guistyle);
			Vector2 drag = this.getDrag();
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523BB28]");
			object obj2 = (IntPtr)0;
			this.oldInfoDrag = this.screenRect;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+260]");
			IntPtr intPtr = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BB18]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v61 @ X0_v37+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			GUI.skin = this.toolbarScrollerSkin;
			Console.WriteLine("Unmanaged memory load: [v79 @ X20_v5+38]");
			bool flag2 = (IntPtr)0 == 0;
			object obj4 = !flag2;
			Console.WriteLine("Unmanaged memory load: [v79 @ X20_v5+38]");
			object obj5 = (IntPtr)0;
			if (obj4 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v79 @ X20_v5+38]");
				obj5 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v93 @ X8_v3+10]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v93 @ X8_v3+10]");
			bool flag3 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag3)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v98 @ X0_v41+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v79 @ X20_v5+38]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v112 @ X8_v5+10]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v112 @ X8_v5+10]");
			bool flag5 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag5)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v114 @ X0_v42+B8]");
			object obj9 = (IntPtr)0;
			Vector2 vector = GUILayout.BeginScrollView(obj9, guistyle);
			this.infoScrollPosition = this.infoScrollPosition;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+3CC]");
			IntPtr intPtr2 = (IntPtr)0;
			float num;
			GUILayout.Space(num);
			Console.WriteLine("Unmanaged memory load: [v144 @ X20_v6+38]");
			bool flag6 = (IntPtr)0 == 0;
			object obj10 = !flag6;
			Console.WriteLine("Unmanaged memory load: [v144 @ X20_v6+38]");
			object obj11 = (IntPtr)0;
			if (obj10 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v144 @ X20_v6+38]");
				obj11 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v154 @ X8_v10+10]");
			object obj12 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v154 @ X8_v10+10]");
			bool flag7 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag7)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v159 @ X0_v48+E4]");
			bool flag8 = (IntPtr)0 == 0;
			if (flag8)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v144 @ X20_v6+38]");
			object obj13 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v172 @ X8_v12+10]");
			object obj14 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v172 @ X8_v12+10]");
			bool flag9 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523BB20]");
			object obj15 = (IntPtr)0;
			if (!flag9)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v175 @ X0_v49+B8]");
			object options = (IntPtr)0;
			GUILayout.BeginHorizontal(options);
			GUILayout.Space(num);
			Console.WriteLine("Method not found @24D662C");
			GUILayoutOption guilayoutOption = GUILayout.Width(num);
			if (obj15 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v192 @ X0_v52+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					GUILayoutOption guilayoutOption2 = GUILayout.Height(num);
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				}
				Console.WriteLine("Method not found @24D67F0");
			}
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0002BFFC File Offset: 0x0002A1FC
	private void drawInfo_enableDisableToolBarButtons()
	{
		object obj2;
		object obj = obj2 - 128L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BB18]");
		object obj3 = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v35 @ X20_v2+38]");
			bool flag2 = (IntPtr)0 == 0;
			object obj4 = !flag2;
			Console.WriteLine("Unmanaged memory load: [v35 @ X20_v2+38]");
			object obj5 = (IntPtr)0;
			if (obj4 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v35 @ X20_v2+38]");
				obj5 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v46 @ X8_v3+10]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v46 @ X8_v3+10]");
			bool flag3 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag3)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v51 @ X0_v16+E4]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v35 @ X20_v2+38]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v65 @ X8_v5+10]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v65 @ X8_v5+10]");
			bool flag5 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523BB20]");
			object obj9 = (IntPtr)0;
			if (!flag5)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v68 @ X0_v17+B8]");
			object options = (IntPtr)0;
			GUILayout.BeginHorizontal(options);
			float num;
			GUILayout.Space(num);
			Console.WriteLine("Method not found @24D662C");
			GUILayoutOption guilayoutOption = GUILayout.Height(num);
			if (obj9 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v89 @ X0_v20 (UnityEngine.GUILayoutOption[])+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523BB90]");
					object text = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
					GUILayout.Label(text, this.nonStyle, obj9);
					GUILayout.Space(num);
					GUILayout.FlexibleSpace();
					GUILayout.EndHorizontal();
					Console.WriteLine("Unmanaged memory load: [v183 @ X20_v4+38]");
					bool flag6 = (IntPtr)0 == 0;
					object obj10 = !flag6;
					Console.WriteLine("Unmanaged memory load: [v183 @ X20_v4+38]");
					object obj11 = (IntPtr)0;
					if (obj10 == null)
					{
						Console.WriteLine("Method not found @250F9B4");
						Console.WriteLine("Unmanaged memory load: [v183 @ X20_v4+38]");
						obj11 = (IntPtr)0;
					}
					Console.WriteLine("Unmanaged memory load: [v191 @ X8_v10+10]");
					object obj12 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v191 @ X8_v10+10]");
					bool flag7 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag7)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v196 @ X0_v30+E4]");
					bool flag8 = (IntPtr)0 == 0;
					if (flag8)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [v183 @ X20_v4+38]");
					object obj13 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v206 @ X8_v12+10]");
					object obj14 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v206 @ X8_v12+10]");
					bool flag9 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag9)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v208 @ X0_v31+B8]");
					object options2 = (IntPtr)0;
					GUILayout.BeginHorizontal(options2);
					GUILayout.Space(num);
					Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
					Console.WriteLine("Method not found @24D662C");
					GUILayoutOption guilayoutOption2 = GUILayout.Width(num);
					if (obj9 == 0)
					{
						goto IL_489;
					}
					Console.WriteLine("Unmanaged memory load: [v225 @ X0_v34+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Method not found @24D64EC");
						GUILayoutOption guilayoutOption3 = GUILayout.Height(num);
						Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
					}
				}
				Console.WriteLine("Method not found @24D67F0");
			}
			IL_489:
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0002C568 File Offset: 0x0002A768
	private void DrawReport()
	{
		GUIStyle guistyle;
		IntPtr ptr;
		guistyle.m_Ptr = ptr;
		GUIStyleState normal;
		guistyle.m_Normal = normal;
		GUIStyleState hover;
		guistyle.m_Hover = hover;
		GUIStyleState active;
		guistyle.m_Active = active;
		GUIStyleState focused;
		guistyle.m_Focused = focused;
		GUIStyleState onNormal;
		guistyle.m_OnNormal = onNormal;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BB98]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			object obj2 = this + 604L;
			Console.WriteLine("Unmanaged memory load: [523BB18]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v27 @ X0_v12+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			int width = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			int height = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			GUILayout.BeginArea(this.backStyle, guistyle);
			Console.WriteLine("Unmanaged memory load: [v61 @ X20_v4+38]");
			bool flag3 = (IntPtr)0 == 0;
			object obj4 = !flag3;
			Console.WriteLine("Unmanaged memory load: [v61 @ X20_v4+38]");
			object obj5 = (IntPtr)0;
			if (obj4 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v61 @ X20_v4+38]");
				obj5 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v69 @ X8_v3+10]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v69 @ X8_v3+10]");
			bool flag4 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag4)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v74 @ X0_v20+E4]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v61 @ X20_v4+38]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v84 @ X8_v5+10]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v84 @ X8_v5+10]");
			bool flag6 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag6)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v86 @ X0_v21+B8]");
			object options = (IntPtr)0;
			GUILayout.BeginVertical(options);
			GUILayout.FlexibleSpace();
			Console.WriteLine("Unmanaged memory load: [v100 @ X20_v5+38]");
			bool flag7 = (IntPtr)0 == 0;
			object obj9 = !flag7;
			Console.WriteLine("Unmanaged memory load: [v100 @ X20_v5+38]");
			object obj10 = (IntPtr)0;
			if (obj9 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v100 @ X20_v5+38]");
				obj10 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v108 @ X8_v10+10]");
			object obj11 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v108 @ X8_v10+10]");
			bool flag8 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag8)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v113 @ X0_v26+E4]");
			bool flag9 = (IntPtr)0 == 0;
			if (flag9)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v100 @ X20_v5+38]");
			object obj12 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v123 @ X8_v12+10]");
			object obj13 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v123 @ X8_v12+10]");
			bool flag10 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523BB20]");
			object obj14 = (IntPtr)0;
			if (!flag10)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v126 @ X0_v27+B8]");
			object options2 = (IntPtr)0;
			GUILayout.BeginHorizontal(options2);
			GUILayout.FlexibleSpace();
			Console.WriteLine("Method not found @24D662C");
			float num;
			GUILayoutOption guilayoutOption = GUILayout.Height(num);
			if (obj14 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v141 @ X0_v30 (UnityEngine.GUILayoutOption[])+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523BBA0]");
					object text = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
					GUILayout.Label(text, this.nonStyle, obj14);
					GUILayout.FlexibleSpace();
					GUILayout.EndHorizontal();
					Console.WriteLine("Unmanaged memory load: [v246 @ X20_v7+38]");
					bool flag11 = (IntPtr)0 == 0;
					object obj15 = !flag11;
					Console.WriteLine("Unmanaged memory load: [v246 @ X20_v7+38]");
					object obj16 = (IntPtr)0;
					if (obj15 == null)
					{
						Console.WriteLine("Method not found @250F9B4");
						Console.WriteLine("Unmanaged memory load: [v246 @ X20_v7+38]");
						obj16 = (IntPtr)0;
					}
					Console.WriteLine("Unmanaged memory load: [v254 @ X8_v17+10]");
					object obj17 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v254 @ X8_v17+10]");
					bool flag12 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag12)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v259 @ X0_v39+E4]");
					bool flag13 = (IntPtr)0 == 0;
					if (flag13)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [v246 @ X20_v7+38]");
					object obj18 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v268 @ X8_v19+10]");
					object obj19 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v268 @ X8_v19+10]");
					bool flag14 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag14)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v270 @ X0_v40+B8]");
					object options3 = (IntPtr)0;
					GUILayout.BeginHorizontal(options3);
					Console.WriteLine("Method not found @24D662C");
					GUILayoutOption guilayoutOption2 = GUILayout.Height(num);
					if (obj14 == 0)
					{
						goto IL_801;
					}
					Console.WriteLine("Unmanaged memory load: [v279 @ X0_v42 (UnityEngine.GUILayoutOption[])+18]");
					if ((IntPtr)0 != 0)
					{
						Console.WriteLine("Unmanaged memory load: [523BBA8]");
						object text2 = (IntPtr)0;
						Console.WriteLine("Method not found @24D64EC");
						GUILayout.Label(text2, this.nonStyle, obj14);
						GUILayout.EndHorizontal();
						Console.WriteLine("Unmanaged memory load: [v301 @ X20_v9+38]");
						bool flag15 = (IntPtr)0 == 0;
						object obj20 = !flag15;
						Console.WriteLine("Unmanaged memory load: [v301 @ X20_v9+38]");
						object obj21 = (IntPtr)0;
						if (obj20 == null)
						{
							Console.WriteLine("Method not found @250F9B4");
							Console.WriteLine("Unmanaged memory load: [v301 @ X20_v9+38]");
							obj21 = (IntPtr)0;
						}
						Console.WriteLine("Unmanaged memory load: [v309 @ X8_v24+10]");
						object obj22 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v309 @ X8_v24+10]");
						bool flag16 = (IntPtr)0 == 0;
						Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
						if (!flag16)
						{
							Console.WriteLine("Method not found @250F958");
						}
						Console.WriteLine("Unmanaged memory load: [v314 @ X0_v50+E4]");
						bool flag17 = (IntPtr)0 == 0;
						if (flag17)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						Console.WriteLine("Unmanaged memory load: [v301 @ X20_v9+38]");
						object obj23 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v323 @ X8_v26+10]");
						object obj24 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v323 @ X8_v26+10]");
						bool flag18 = (IntPtr)0 == 0;
						Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
						if (!flag18)
						{
							Console.WriteLine("Method not found @250F958");
						}
						Console.WriteLine("Unmanaged memory load: [v325 @ X0_v51+B8]");
						object options4 = (IntPtr)0;
						GUILayout.BeginHorizontal(options4);
						GUILayout.FlexibleSpace();
						Console.WriteLine("Method not found @24D662C");
						GUILayoutOption guilayoutOption3 = GUILayout.Width(num);
						if (obj14 == 0)
						{
							goto IL_801;
						}
						Console.WriteLine("Unmanaged memory load: [v336 @ X0_v54+18]");
						if ((IntPtr)0 != 0)
						{
							Console.WriteLine("Method not found @24D64EC");
							GUILayoutOption guilayoutOption4 = GUILayout.Height(num);
							Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
						}
					}
				}
				Console.WriteLine("Method not found @24D67F0");
			}
			IL_801:
			Console.WriteLine("Method not found @24D67E8");
		}
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0002CED4 File Offset: 0x0002B0D4
	private void drawToolBar()
	{
		object obj;
		Rect rect = obj - 144L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BB98]");
		object obj2 = (IntPtr)0;
		if (!flag)
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
		}
		for (;;)
		{
			object obj3 = this + 620L;
			Console.WriteLine("Unmanaged memory load: [523BB28]");
			object obj4 = (IntPtr)0;
			float width;
			rect.m_Width = width;
			Console.WriteLine("Unmanaged memory load: [v36 @ X0_v26+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			int width2 = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			float num = (float)((IntPtr)0);
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			float num2 = (float)((IntPtr)num + (IntPtr)0);
			Console.WriteLine("Unmanaged memory load: [v55 @ X0_v29+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [523BB18]");
			object obj5 = (IntPtr)0;
			GUI.skin = this.toolbarScrollerSkin;
			Vector2 drag = this.getDrag();
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			this.toolbarOldDrag = num2;
			GUILayout.BeginArea(rect);
			Console.WriteLine("Unmanaged memory load: [v96 @ X20_v4+38]");
			bool flag4 = (IntPtr)0 == 0;
			object obj6 = !flag4;
			Console.WriteLine("Unmanaged memory load: [v96 @ X20_v4+38]");
			object obj7 = (IntPtr)0;
			if (obj6 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v96 @ X20_v4+38]");
				obj7 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v110 @ X8_v3+10]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v110 @ X8_v3+10]");
			bool flag5 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag5)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v115 @ X0_v36+E4]");
			bool flag6 = (IntPtr)0 == 0;
			if (flag6)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v96 @ X20_v4+38]");
			object obj9 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v129 @ X8_v5+10]");
			object obj10 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v129 @ X8_v5+10]");
			bool flag7 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag7)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v131 @ X0_v37+B8]");
			object obj11 = (IntPtr)0;
			Vector2 vector = GUILayout.BeginScrollView(obj11, rect);
			this.toolbarScrollPosition = this.toolbarScrollPosition;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+308]");
			IntPtr intPtr = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v149 @ X21_v3+38]");
			bool flag8 = (IntPtr)0 == 0;
			object obj12 = !flag8;
			Console.WriteLine("Unmanaged memory load: [v149 @ X21_v3+38]");
			object obj13 = (IntPtr)0;
			if (obj12 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v149 @ X21_v3+38]");
				obj13 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v159 @ X8_v10+10]");
			object obj14 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v159 @ X8_v10+10]");
			bool flag9 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag9)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v164 @ X0_v42+E4]");
			bool flag10 = (IntPtr)0 == 0;
			if (flag10)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v149 @ X21_v3+38]");
			object obj15 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v174 @ X8_v12+10]");
			object obj16 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v174 @ X8_v12+10]");
			bool flag11 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523BB20]");
			object obj17 = (IntPtr)0;
			if (!flag11)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v177 @ X0_v43+B8]");
			object options = (IntPtr)0;
			GUILayout.BeginHorizontal(this.barStyle, options);
			Console.WriteLine("Method not found @24D662C");
			float num3;
			GUILayoutOption guilayoutOption = GUILayout.Width(num3);
			if (obj17 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v192 @ X0_v45+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					GUILayoutOption guilayoutOption2 = GUILayout.Height(num3);
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				}
				Console.WriteLine("Method not found @24D67F0");
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
		}
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0002D54C File Offset: 0x0002B74C
	private void DrawLogs()
	{
		object obj;
		GUIStyle guistyle = obj - 272L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BB28]");
		object obj2 = (IntPtr)0;
		if (!flag)
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
		}
		for (;;)
		{
			GUILayout.BeginArea(this.backStyle, guistyle);
			Console.WriteLine("Unmanaged memory load: [v53 @ X0_v25+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [523BB98]");
			object obj3 = (IntPtr)0;
			GUI.skin = this.logScrollerSkin;
			Vector2 drag = this.getDrag();
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523BB18]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v86 @ X20_v3+38]");
			bool flag3 = (IntPtr)0 == 0;
			object obj5 = !flag3;
			Console.WriteLine("Unmanaged memory load: [v86 @ X20_v3+38]");
			object obj6 = (IntPtr)0;
			if (obj5 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v86 @ X20_v3+38]");
				obj6 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v96 @ X8_v5+10]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v96 @ X8_v5+10]");
			bool flag4 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag4)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v101 @ X0_v31+E4]");
			bool flag5 = (IntPtr)0 == 0;
			if (flag5)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v86 @ X20_v3+38]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v115 @ X8_v7+10]");
			object obj9 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v115 @ X8_v7+10]");
			bool flag6 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag6)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v117 @ X0_v32+B8]");
			object obj10 = (IntPtr)0;
			Vector2 vector = GUILayout.BeginScrollView(obj10, guistyle);
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+280]");
			this.oldDrag = (float)((IntPtr)0);
			this.scrollPosition = this.scrollPosition;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+2F8]");
			IntPtr intPtr = (IntPtr)0;
			int height = Screen.height;
			List<Reporter.Log> list = this.currentLog;
			if (this.currentLog != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67F0");
		}
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v140 @ X8_v10 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
		IntPtr intPtr2 = (IntPtr)0;
		Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
		object obj11 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+284]");
		object obj12 = obj11 * (IntPtr)0;
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (UnityEngine.GUIStyle)+7C]");
		IntPtr intPtr3 = (IntPtr)0;
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
		object obj13 = (IntPtr)0 * obj12;
		Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		GUILayout.EndScrollView();
		GUILayout.EndArea();
		Console.WriteLine("Unmanaged memory load: [v254 @ X0_v40+E4]");
		bool flag7 = (IntPtr)0 == 0;
		if (flag7)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Rect rect;
		this.buttomRect = rect;
		int height2 = Screen.height;
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		object obj14 = obj13;
		Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
		object obj15 = obj14 - (IntPtr)0;
		int width = Screen.width;
		Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
		Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
		IntPtr intPtr4 = (IntPtr)0;
		if (!(~this.showGraph))
		{
			Console.WriteLine("Invalid instruction: 1669 Invalid \"Jump target not found in method: 0x25E8C24\"");
		}
		this.drawStack();
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0002DAFC File Offset: 0x0002BCFC
	private void drawGraph()
	{
		object obj;
		GUIStyle guistyle = obj - 144L;
		IntPtr ptr;
		guistyle.m_Ptr = ptr;
		GUIStyleState hover;
		guistyle.m_Hover = hover;
		GUIStyleState active;
		guistyle.m_Active = active;
		GUIStyleState focused;
		guistyle.m_Focused = focused;
		GUIStyleState onNormal;
		guistyle.m_OnNormal = onNormal;
		GUIStyleState onHover;
		guistyle.m_OnHover = onHover;
		GUIStyleState onActive;
		guistyle.m_OnActive = onActive;
		GUIStyleState onFocused;
		guistyle.m_OnFocused = onFocused;
		RectOffset border;
		guistyle.m_Border = border;
		RectOffset padding;
		guistyle.m_Padding = padding;
		RectOffset margin;
		guistyle.m_Margin = margin;
		RectOffset overflow;
		guistyle.m_Overflow = overflow;
		string name;
		guistyle.m_Name = name;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523BB98]");
		object obj2 = (IntPtr)0;
		if (!flag)
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
		}
		for (;;)
		{
			object obj3 = this + 652L;
			object obj4 = this + 668L;
			Console.WriteLine("Unmanaged memory load: [523BB28]");
			object obj5 = (IntPtr)0;
			int height = Screen.height;
			Console.WriteLine("Unmanaged memory load: [v47 @ X8_v1+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [v62 @ X0_v24+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			GUI.skin = this.graphScrollerSkin;
			Vector2 drag = this.getDrag();
			int height2 = Screen.height;
			Console.WriteLine("Unmanaged memory load: [559218D]");
			bool flag4 = (IntPtr)0 == 0;
			if (flag4)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			object obj6 = this + 1044L;
			Console.WriteLine("Unmanaged memory load: [523BB18]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			float num;
			this.oldDrag3 = num;
			GUILayout.BeginArea(this.backStyle, guistyle);
			Console.WriteLine("Unmanaged memory load: [v128 @ X20_v3+38]");
			bool flag5 = (IntPtr)0 == 0;
			object obj8 = !flag5;
			Console.WriteLine("Unmanaged memory load: [v128 @ X20_v3+38]");
			object obj9 = (IntPtr)0;
			if (obj8 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v128 @ X20_v3+38]");
				obj9 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v140 @ X8_v4+10]");
			object obj10 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v140 @ X8_v4+10]");
			bool flag6 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag6)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v145 @ X0_v36+E4]");
			bool flag7 = (IntPtr)0 == 0;
			if (flag7)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v128 @ X20_v3+38]");
			object obj11 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v155 @ X8_v6+10]");
			object obj12 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v155 @ X8_v6+10]");
			bool flag8 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag8)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v157 @ X0_v37+B8]");
			object obj13 = (IntPtr)0;
			Vector2 vector = GUILayout.BeginScrollView(obj13, guistyle);
			Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+410]");
			IntPtr intPtr = (IntPtr)0;
			this.graphScrollerPos = this.graphScrollerPos;
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [v47 @ X8_v1+E4]");
			this.startFrame = (int)((IntPtr)0);
			if (this.samples == 0)
			{
				goto IL_701;
			}
			Console.WriteLine("Unmanaged memory load: [523BB20]");
			object obj14 = (IntPtr)0;
			int width = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Method not found @24D662C");
			if (this.samples == 0)
			{
				goto IL_701;
			}
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			GUILayoutOption guilayoutOption = GUILayout.Width(obj3);
			if (obj14 == 0)
			{
				goto IL_701;
			}
			Console.WriteLine("Unmanaged memory load: [v235 @ X0_v42 (UnityEngine.GUILayoutOption[])+18]");
			if ((IntPtr)0 != 0)
			{
				Console.WriteLine("Unmanaged memory load: [523BBC0]");
				object text = (IntPtr)0;
				Console.WriteLine("Method not found @24D64EC");
				GUILayout.Label(text, obj14);
				GUILayout.EndScrollView();
				GUILayout.EndArea();
				Console.WriteLine("Unmanaged memory load: [DBE03A]");
				obj6 = (IntPtr)0;
				int width2 = Screen.width;
				Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				object obj15 = this + 700L;
				Console.WriteLine("Unmanaged memory load: [v322 @ X0_v51+E4]");
				bool flag9 = (IntPtr)0 == 0;
				if (flag9)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
				IntPtr intPtr2 = (IntPtr)0;
				GUILayout.BeginArea(guistyle);
				Console.WriteLine("Unmanaged memory load: [v336 @ X24_v1+38]");
				bool flag10 = (IntPtr)0 == 0;
				object obj16 = !flag10;
				Console.WriteLine("Unmanaged memory load: [v336 @ X24_v1+38]");
				object obj17 = (IntPtr)0;
				if (obj16 == null)
				{
					Console.WriteLine("Method not found @250F9B4");
					Console.WriteLine("Unmanaged memory load: [v336 @ X24_v1+38]");
					obj17 = (IntPtr)0;
				}
				Console.WriteLine("Unmanaged memory load: [v344 @ X8_v15+10]");
				object obj18 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v344 @ X8_v15+10]");
				bool flag11 = (IntPtr)0 == 0;
				Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
				if (!flag11)
				{
					Console.WriteLine("Method not found @250F958");
				}
				Console.WriteLine("Unmanaged memory load: [v349 @ X0_v55+E4]");
				bool flag12 = (IntPtr)0 == 0;
				if (flag12)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v336 @ X24_v1+38]");
				object obj19 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v358 @ X8_v17+10]");
				object obj20 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v358 @ X8_v17+10]");
				bool flag13 = (IntPtr)0 == 0;
				Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
				if (!flag13)
				{
					Console.WriteLine("Method not found @250F958");
				}
				Console.WriteLine("Unmanaged memory load: [v360 @ X0_v56+B8]");
				object options = (IntPtr)0;
				GUILayout.BeginHorizontal(options);
				Console.WriteLine("Method not found @24D662C");
				GUILayoutOption guilayoutOption2 = GUILayout.Width(obj3);
				if (obj14 == 0)
				{
					goto IL_701;
				}
				Console.WriteLine("Unmanaged memory load: [v369 @ X0_v58+18]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Method not found @24D64EC");
					GUILayoutOption guilayoutOption3 = GUILayout.Height(obj3);
					Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
				}
			}
			IL_710:
			Console.WriteLine("Method not found @24D67F0");
			continue;
			IL_701:
			Console.WriteLine("Method not found @24D67E8");
			goto IL_710;
		}
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
	private void drawStack()
	{
		GUIStyle guistyle;
		IntPtr ptr;
		guistyle.m_Ptr = ptr;
		GUIStyleState normal;
		guistyle.m_Normal = normal;
		GUIStyleState hover;
		guistyle.m_Hover = hover;
		GUIStyleState active;
		guistyle.m_Active = active;
		GUIStyleState focused;
		guistyle.m_Focused = focused;
		GUIStyleState onNormal;
		guistyle.m_OnNormal = onNormal;
		GUIStyleState onHover;
		guistyle.m_OnHover = onHover;
		GUIStyleState onActive;
		guistyle.m_OnActive = onActive;
		GUIStyleState onFocused;
		guistyle.m_OnFocused = onFocused;
		RectOffset border;
		guistyle.m_Border = border;
		RectOffset padding;
		guistyle.m_Padding = padding;
		RectOffset margin;
		guistyle.m_Margin = margin;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		while (this.selectedLog != 0)
		{
			Console.WriteLine("Unmanaged memory load: [523BB18]");
			object obj = (IntPtr)0;
			Vector2 drag = this.getDrag();
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			float num;
			this.oldDrag2 = num;
			GUILayout.BeginArea(this.backStyle, guistyle);
			Console.WriteLine("Unmanaged memory load: [v87 @ X20_v3+38]");
			bool flag = (IntPtr)0 == 0;
			object obj2 = !flag;
			Console.WriteLine("Unmanaged memory load: [v87 @ X20_v3+38]");
			object obj3 = (IntPtr)0;
			if (obj2 == null)
			{
				Console.WriteLine("Method not found @250F9B4");
				Console.WriteLine("Unmanaged memory load: [v87 @ X20_v3+38]");
				obj3 = (IntPtr)0;
			}
			Console.WriteLine("Unmanaged memory load: [v115 @ X8_v5+10]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v115 @ X8_v5+10]");
			bool flag2 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag2)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v120 @ X0_v18+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			Console.WriteLine("Unmanaged memory load: [v87 @ X20_v3+38]");
			object obj5 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v189 @ X8_v7+10]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v189 @ X8_v7+10]");
			bool flag4 = (IntPtr)0 == 0;
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			if (!flag4)
			{
				Console.WriteLine("Method not found @250F958");
			}
			Console.WriteLine("Unmanaged memory load: [v191 @ X0_v19+B8]");
			object obj7 = (IntPtr)0;
			Vector2 vector = GUILayout.BeginScrollView(obj7, guistyle);
			this.scrollPosition2 = this.scrollPosition2;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+300]");
			IntPtr intPtr = (IntPtr)0;
			if (this.selectedLog == 0)
			{
				goto IL_9DB;
			}
			if (this.samples != 0)
			{
				object obj8 = this.samples.get_Item(guistyle);
				Console.WriteLine("Unmanaged memory load: [v268 @ X21_v2+38]");
				bool flag5 = (IntPtr)0 == 0;
				object obj9 = !flag5;
				Console.WriteLine("Unmanaged memory load: [v268 @ X21_v2+38]");
				object obj10 = (IntPtr)0;
				if (obj9 == null)
				{
					Console.WriteLine("Method not found @250F9B4");
					Console.WriteLine("Unmanaged memory load: [v268 @ X21_v2+38]");
					obj10 = (IntPtr)0;
				}
				Console.WriteLine("Unmanaged memory load: [v278 @ X8_v13+10]");
				object obj11 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v278 @ X8_v13+10]");
				bool flag6 = (IntPtr)0 == 0;
				Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
				if (!flag6)
				{
					Console.WriteLine("Method not found @250F958");
				}
				Console.WriteLine("Unmanaged memory load: [v283 @ X0_v26+E4]");
				bool flag7 = (IntPtr)0 == 0;
				if (flag7)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v268 @ X21_v2+38]");
				object obj12 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v293 @ X8_v15+10]");
				object obj13 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v293 @ X8_v15+10]");
				bool flag8 = (IntPtr)0 == 0;
				Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
				if (!flag8)
				{
					Console.WriteLine("Method not found @250F958");
				}
				Console.WriteLine("Unmanaged memory load: [v295 @ X0_v27+B8]");
				object options = (IntPtr)0;
				GUILayout.BeginHorizontal(options);
				Reporter.Log log = this.selectedLog;
				if (this.selectedLog != 0)
				{
					Console.WriteLine("Unmanaged memory load: [v310 @ X23_v2+38]");
					bool flag9 = (IntPtr)0 == 0;
					object obj14 = !flag9;
					Console.WriteLine("Unmanaged memory load: [v310 @ X23_v2+38]");
					object obj15 = (IntPtr)0;
					if (obj14 == null)
					{
						Console.WriteLine("Method not found @250F9B4");
						Console.WriteLine("Unmanaged memory load: [v310 @ X23_v2+38]");
						obj15 = (IntPtr)0;
					}
					Console.WriteLine("Unmanaged memory load: [v358 @ X8_v20+10]");
					object obj16 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v358 @ X8_v20+10]");
					bool flag10 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag10)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v363 @ X0_v31+E4]");
					bool flag11 = (IntPtr)0 == 0;
					if (flag11)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [v310 @ X23_v2+38]");
					object obj17 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v373 @ X8_v22+10]");
					object obj18 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v373 @ X8_v22+10]");
					bool flag12 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag12)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v375 @ X0_v32+B8]");
					object options2 = (IntPtr)0;
					GUILayout.Label(log.condition, this.stackLabelStyle, options2);
					GUILayout.EndHorizontal();
					float num2;
					GUILayout.Space(num2);
					Console.WriteLine("Unmanaged memory load: [v329 @ X21_v4+38]");
					bool flag13 = (IntPtr)0 == 0;
					object obj19 = !flag13;
					Console.WriteLine("Unmanaged memory load: [v329 @ X21_v4+38]");
					object obj20 = (IntPtr)0;
					if (obj19 == null)
					{
						Console.WriteLine("Method not found @250F9B4");
						Console.WriteLine("Unmanaged memory load: [v329 @ X21_v4+38]");
						obj20 = (IntPtr)0;
					}
					Console.WriteLine("Unmanaged memory load: [v404 @ X8_v27+10]");
					object obj21 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v404 @ X8_v27+10]");
					bool flag14 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag14)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v409 @ X0_v38+E4]");
					bool flag15 = (IntPtr)0 == 0;
					if (flag15)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					Console.WriteLine("Unmanaged memory load: [v329 @ X21_v4+38]");
					object obj22 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v418 @ X8_v29+10]");
					object obj23 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v418 @ X8_v29+10]");
					bool flag16 = (IntPtr)0 == 0;
					Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
					if (!flag16)
					{
						Console.WriteLine("Method not found @250F958");
					}
					Console.WriteLine("Unmanaged memory load: [v420 @ X0_v39+B8]");
					object options3 = (IntPtr)0;
					GUILayout.BeginHorizontal(options3);
					Reporter.Log log2 = this.selectedLog;
					if (this.selectedLog != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v429 @ X23_v3+38]");
						bool flag17 = (IntPtr)0 == 0;
						object obj24 = !flag17;
						Console.WriteLine("Unmanaged memory load: [v429 @ X23_v3+38]");
						object obj25 = (IntPtr)0;
						if (obj24 == null)
						{
							Console.WriteLine("Method not found @250F9B4");
							Console.WriteLine("Unmanaged memory load: [v429 @ X23_v3+38]");
							obj25 = (IntPtr)0;
						}
						Console.WriteLine("Unmanaged memory load: [v441 @ X8_v34+10]");
						object obj26 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v441 @ X8_v34+10]");
						bool flag18 = (IntPtr)0 == 0;
						Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
						if (!flag18)
						{
							Console.WriteLine("Method not found @250F958");
						}
						Console.WriteLine("Unmanaged memory load: [v446 @ X0_v43+E4]");
						bool flag19 = (IntPtr)0 == 0;
						if (flag19)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						Console.WriteLine("Unmanaged memory load: [v429 @ X23_v3+38]");
						object obj27 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v456 @ X8_v36+10]");
						object obj28 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v456 @ X8_v36+10]");
						bool flag20 = (IntPtr)0 == 0;
						Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
						if (!flag20)
						{
							Console.WriteLine("Method not found @250F958");
						}
						Console.WriteLine("Unmanaged memory load: [v458 @ X0_v44+B8]");
						object options4 = (IntPtr)0;
						GUILayout.Label(log2.stacktrace, this.stackLabelStyle, options4);
						GUILayout.EndHorizontal();
						GUILayout.Space(num2);
						GUILayout.EndScrollView();
						GUILayout.EndArea();
						GUILayout.BeginArea(this.backStyle, guistyle);
						Console.WriteLine("Unmanaged memory load: [v491 @ X21_v6+38]");
						bool flag21 = (IntPtr)0 == 0;
						object obj29 = !flag21;
						Console.WriteLine("Unmanaged memory load: [v491 @ X21_v6+38]");
						object obj30 = (IntPtr)0;
						if (obj29 == null)
						{
							Console.WriteLine("Method not found @250F9B4");
							Console.WriteLine("Unmanaged memory load: [v491 @ X21_v6+38]");
							obj30 = (IntPtr)0;
						}
						Console.WriteLine("Unmanaged memory load: [v499 @ X8_v41+10]");
						object obj31 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v499 @ X8_v41+10]");
						bool flag22 = (IntPtr)0 == 0;
						Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
						if (!flag22)
						{
							Console.WriteLine("Method not found @250F958");
						}
						Console.WriteLine("Unmanaged memory load: [v504 @ X0_v53+E4]");
						bool flag23 = (IntPtr)0 == 0;
						if (flag23)
						{
							Console.WriteLine("Method not found @24D66BC");
						}
						Console.WriteLine("Unmanaged memory load: [v491 @ X21_v6+38]");
						object obj32 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v513 @ X8_v43+10]");
						object obj33 = (IntPtr)0;
						Console.WriteLine("Unmanaged memory load: [v513 @ X8_v43+10]");
						bool flag24 = (IntPtr)0 == 0;
						Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
						Console.WriteLine("Unmanaged memory load: [523BB20]");
						object obj34 = (IntPtr)0;
						if (!flag24)
						{
							Console.WriteLine("Method not found @250F958");
						}
						Console.WriteLine("Unmanaged memory load: [v516 @ X0_v54+B8]");
						object options5 = (IntPtr)0;
						GUILayout.BeginHorizontal(options5);
						Console.WriteLine("Method not found @24D662C");
						GUILayoutOption guilayoutOption = GUILayout.Width(num2);
						if (obj34 != 0)
						{
							Console.WriteLine("Unmanaged memory load: [v525 @ X0_v56+18]");
							if ((IntPtr)0 != 0)
							{
								Console.WriteLine("Method not found @24D64EC");
								GUILayoutOption guilayoutOption2 = GUILayout.Height(num2);
								Console.WriteLine("Not implemented instruction: Instruction LDUR not yet implemented.");
							}
							Console.WriteLine("Method not found @24D67F0");
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
				goto IL_9DB;
			}
			IL_9EA:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
			continue;
			IL_9DB:
			Console.WriteLine("Method not found @24D67E8");
			goto IL_9EA;
		}
		GUILayout.BeginArea(this.backStyle, guistyle);
		GUILayout.EndArea();
		GUILayout.BeginArea(this.backStyle, guistyle);
		GUILayout.EndArea();
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0002F038 File Offset: 0x0002D238
	public void OnGUIDraw()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		if (!(~this.show))
		{
			Console.WriteLine("Unmanaged memory load: [523BB98]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v26 @ X0_v5+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj2 = this + 604L;
			int width = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			int height = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Vector2 vector = this.getDownPos();
			Rect rect;
			this.logsRect = rect;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj4 = obj3 + (IntPtr)0;
			int width2 = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			int height2 = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			this.stackRectTopLeft = rect;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj5 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj6 = obj5 + (IntPtr)0;
			this.stackRect = rect;
			object obj7 = obj4 * 0.75;
			object obj8 = obj7 - obj6;
			int height3 = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			object obj9 = obj8 * 0.75;
			int height4 = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			object obj10 = obj9 * 0.75;
			int width3 = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			int height5 = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			this.detailRect = rect;
			object obj11 = obj10;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj12 = obj11 - (IntPtr)0;
			int height6 = Screen.height;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj13 = (double)((IntPtr)0) * 3.0;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj14 = (IntPtr)0 - obj13;
			int width4 = Screen.width;
			Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			object obj15 = (double)((IntPtr)0) * 3.0;
			Console.WriteLine("Unmanaged memory load: [this @ X0 (Reporter)+20C]");
			IntPtr intPtr = (IntPtr)0;
			this.drawToolBar();
			this.DrawLogs();
			return;
		}
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0002F360 File Offset: 0x0002D560
	private bool isGestureDone()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v35 @ X0_v17+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			RuntimePlatform platform = Application.platform;
			bool touches = Input.touches != null;
			if (touches)
			{
				List<Vector2> list = this.gestureDetector;
				if (this.gestureDetector != 0)
				{
					int num;
					this.gestureCount = num;
					Console.WriteLine("Unmanaged memory load: [v72 @ X8_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
					object obj2 = (IntPtr)0 + 1;
					if (this.gestureDetector != 0)
					{
					}
				}
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67F0");
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0002F554 File Offset: 0x0002D754
	private bool isDoubleClickDone()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v25 @ X0_v5+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			RuntimePlatform platform = Application.platform;
			bool touches = Input.touches != null;
			if (touches)
			{
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67F0");
		}
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0002F674 File Offset: 0x0002D874
	private Vector2 getDownPos()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v5+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			RuntimePlatform platform = Application.platform;
			Touch[] touches = Input.touches;
			if (touches != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67F0");
		}
		Console.WriteLine("Unmanaged memory load: [559212F]");
		bool flag3 = (IntPtr)0 == 0;
		object obj2 = !flag3;
		obj2;
		Console.WriteLine("Method not found @24D6540");
		Vector2 result;
		return result;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0002F7EC File Offset: 0x0002D9EC
	private Vector2 getDrag()
	{
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj = (IntPtr)0;
		if (!flag)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Unmanaged memory load: [v24 @ X0_v5+E4]");
			bool flag2 = (IntPtr)0 == 0;
			if (flag2)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			RuntimePlatform platform = Application.platform;
			Touch[] touches = Input.touches;
			if (touches != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @24D67F0");
		}
		Console.WriteLine("Unmanaged memory load: [559212F]");
		bool flag3 = (IntPtr)0 == 0;
		object obj2 = !flag3;
		obj2;
		Console.WriteLine("Method not found @24D6540");
		Vector2 result;
		return result;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0002F964 File Offset: 0x0002DB64
	private void calculateStartIndex()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		for (;;)
		{
			Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			this.startIndex = (int)2147483648L;
			if (this.currentLog != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
		this.startIndex = (int)2147483648L;
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0002FA44 File Offset: 0x0002DC44
	private void doShow()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		GameObject gameObject2;
		for (;;)
		{
			this.show = (1L != 0L);
			this.currentView = (Reporter.ReportView)1L;
			GameObject gameObject = base.gameObject;
			if (gameObject != 0)
			{
				Console.WriteLine("Method not found @292FD6C");
				gameObject2 = base.gameObject;
				if (gameObject2 != 0)
				{
					break;
				}
			}
			else
			{
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
		}
		Console.WriteLine("Unmanaged memory load: [523BAE0]");
		object methodName = (IntPtr)0;
		gameObject2.SendMessage(methodName);
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0002FB7C File Offset: 0x0002DD7C
	private void Update()
	{
		/*
An exception occurred when decompiling this method (0600023D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Reporter::Update()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_2A7:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67F0")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E0")); 	call:void(Console::WriteLine, ldstr:string("Method not found @214852C")); 	call:void(Console::WriteLine, ldstr:string("Method not found @25C617C")); 	call:void(Console::WriteLine, ldstr:string("Method not found @21483A0")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0002FF1C File Offset: 0x0002E11C
	private void CaptureLog(string condition, string stacktrace, LogType type)
	{
		this.AddLog(condition, stacktrace, type);
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0002FF3C File Offset: 0x0002E13C
	private void AddLog(string condition, string stacktrace, LogType type)
	{
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
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		object obj11;
		GameObject gameObject;
		for (;;)
		{
			if (this.cachedString == 0)
			{
				goto IL_980;
			}
			bool flag = this.cachedString.ContainsKey(condition);
			bool flag2 = this.cachedString == 0;
			object obj2;
			string condition2;
			object obj4;
			object obj6;
			if (flag2)
			{
				if (this.cachedString == 0)
				{
					goto IL_980;
				}
				object obj = this.cachedString.get_Item(condition);
				Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
				object obj3;
				obj2 = obj3;
				condition2 = obj;
			}
			else
			{
				if (this.cachedString == 0)
				{
					goto IL_980;
				}
				this.cachedString.Add(condition, condition);
				bool flag3 = obj4 == 0;
				bool flag4 = string.IsNullOrEmpty(condition);
				if (!flag3)
				{
					if (condition == 0)
					{
						goto IL_980;
					}
				}
				Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
				int num = IntPtr.Size;
				Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
				object obj3;
				object obj5 = obj3 + obj6;
				obj2 = obj5;
				condition2 = condition;
			}
			if (this.cachedString == 0)
			{
				goto IL_980;
			}
			bool flag5 = this.cachedString.ContainsKey(stacktrace);
			bool flag6 = this.cachedString == 0;
			object stacktrace2;
			object obj8;
			if (flag6)
			{
				if (this.cachedString == 0)
				{
					goto IL_980;
				}
				object obj7 = this.cachedString.get_Item(stacktrace);
				stacktrace2 = obj7;
				obj8 = obj2;
			}
			else
			{
				if (this.cachedString == 0)
				{
					goto IL_980;
				}
				this.cachedString.Add(stacktrace, stacktrace);
				bool flag7 = obj4 == 0;
				bool flag8 = string.IsNullOrEmpty(stacktrace);
				if (!flag7)
				{
					if (stacktrace == 0)
					{
						goto IL_980;
					}
				}
				Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
				object obj9 = obj2 + obj6;
				int num2 = IntPtr.Size;
				Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
				object obj10 = obj9 + obj6;
				stacktrace2 = stacktrace;
				obj8 = obj10;
			}
			Console.WriteLine("Unmanaged memory load: [523BC50]");
			obj11 = (IntPtr)0;
			this.addSample();
			Reporter.Log log = obj11;
			Console.WriteLine("Method not found @24D67D8");
			obj11..ctor();
			if (obj11 == 0)
			{
				goto IL_980;
			}
			Reporter._LogType logType;
			log.logType = logType;
			log.condition = condition2;
			Console.WriteLine("Method not found @24D64EC");
			log.stacktrace = stacktrace2;
			Console.WriteLine("Method not found @24D64EC");
			List<Reporter.Sample> list = this.samples;
			if (this.samples == 0)
			{
				goto IL_980;
			}
			Console.WriteLine("Unmanaged memory load: [v108 @ X8_v12 (System.Collections.Generic.List`1<Reporter+Sample>)+18]");
			int sampleId = (int)((IntPtr)0 - 1);
			log.sampleId = sampleId;
			float memoryUsage = obj11.GetMemoryUsage();
			object obj12 = obj8 + obj6;
			object obj13 = obj12 * 981467136L;
			object obj14 = obj13 * 981467136L;
			float num3 = this.logsMemUsage + obj14;
			this.logsMemUsage = num3;
			Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
			if (this.logsDic == 0)
			{
				goto IL_980;
			}
			Console.WriteLine("Unmanaged memory load: [523BC58]");
			object obj15 = (IntPtr)0;
			bool flag9 = obj15 == 0;
			Console.WriteLine("Method not found @3C4135C");
			object obj19;
			if (flag9)
			{
				if (this.logsDic == 0)
				{
					goto IL_980;
				}
				Console.WriteLine("Method not found @3C412A4");
				if (this.logsDic == 0)
				{
					goto IL_980;
				}
				object obj16 = this.logsDic.get_Item(stacktrace);
				if (obj16 == 0)
				{
					goto IL_980;
				}
				object obj17 = obj16 + 16L;
				object obj18 = obj17 + 1L;
				object obj20;
				obj19 = obj20;
			}
			else
			{
				List<object> list2 = this.collapsedLogs;
				if (this.collapsedLogs == 0)
				{
					goto IL_980;
				}
				Console.WriteLine("Unmanaged memory load: [v166 @ X0_v61 (System.Collections.Generic.List`1<System.Object>)+1C]");
				object obj21 = (IntPtr)0 + 1;
				Console.WriteLine("Unmanaged memory load: [v166 @ X0_v61 (System.Collections.Generic.List`1<System.Object>)+10]");
				if ((IntPtr)0 == 0)
				{
					goto IL_980;
				}
				Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
				this.collapsedLogs.AddWithResize(obj11);
				if (this.logsDic == 0)
				{
					goto IL_980;
				}
				Console.WriteLine("Method not found @3C412A4");
				if (this.logsDic == 0)
				{
					goto IL_980;
				}
				this.logsDic.set_Item(stacktrace, obj11);
				int num4 = (int)((long)this.numOfCollapsedLogsWarning + 1L);
				this.numOfCollapsedLogsWarning = num4;
				obj19 = 1L;
			}
			int num5 = (int)((long)this.numOfLogsWarning + 1L);
			this.numOfLogsWarning = num5;
			List<object> list3 = this.logs;
			if (this.logs == 0)
			{
				goto IL_980;
			}
			Console.WriteLine("Unmanaged memory load: [v168 @ X0_v64 (System.Collections.Generic.List`1<System.Object>)+1C]");
			object obj22 = (IntPtr)0 + 1;
			Console.WriteLine("Unmanaged memory load: [v168 @ X0_v64 (System.Collections.Generic.List`1<System.Object>)+10]");
			if ((IntPtr)0 == 0)
			{
				goto IL_980;
			}
			Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
			this.logs.AddWithResize(obj11);
			object obj23 = (this.collapse ? 1L : 0L) ^ 1L;
			object obj24 = obj19 | obj23;
			if (obj24 != 0)
			{
				if (log.logType == Reporter._LogType.Error)
				{
					bool flag10 = ~this.showError;
					if (flag10)
					{
						goto IL_B06;
					}
				}
				bool flag11 = obj4 == 0;
				bool flag12 = string.IsNullOrEmpty(this.filterText);
				if (!flag11)
				{
					if (log == 0)
					{
						goto IL_980;
					}
					string text = log.ToLower();
					if (this.filterText == 0)
					{
						goto IL_980;
					}
					string value = this.filterText.ToLower();
					if (text == 0)
					{
						goto IL_980;
					}
					bool flag13 = obj4 == 0;
					bool flag14 = text.Contains(value);
					if (!flag13)
					{
						goto IL_B06;
					}
				}
				List<object> list4 = this.currentLog;
				if (this.currentLog == 0)
				{
					goto IL_980;
				}
				Console.WriteLine("Unmanaged memory load: [v172 @ X0_v74 (System.Collections.Generic.List`1<System.Object>)+1C]");
				object obj25 = (IntPtr)0 + 1;
				Console.WriteLine("Unmanaged memory load: [v172 @ X0_v74 (System.Collections.Generic.List`1<System.Object>)+10]");
				if ((IntPtr)0 == 0)
				{
					goto IL_980;
				}
				Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
				this.currentLog.AddWithResize(obj11);
				this.calculateStartIndex();
				if (this.currentLog == 0)
				{
					goto IL_980;
				}
				int height = Screen.height;
				Console.WriteLine("Not implemented instruction: Instruction SCVTF not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FDIV not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCVTZS not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction FCMP not yet implemented.");
				Console.WriteLine("Not implemented instruction: Instruction CSEL not yet implemented.");
			}
			IL_B06:
			gameObject = base.gameObject;
			if (gameObject != 0)
			{
				break;
			}
			IL_98F:
			Console.WriteLine("Method not found @24D67E8");
			Console.WriteLine("Method not found @25C617C");
			Console.WriteLine("Method not found @21483A0");
			continue;
			IL_980:
			Console.WriteLine("Method not found @24D67E8");
			goto IL_98F;
		}
		Console.WriteLine("Unmanaged memory load: [523BC68]");
		object methodName = (IntPtr)0;
		gameObject.SendMessage(methodName, obj11);
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00030A78 File Offset: 0x0002EC78
	private void CaptureLogThread(string condition, string stacktrace, LogType type)
	{
		object obj2;
		object obj = obj2 - 96L;
		Console.WriteLine("Unmanaged memory load: [523BC50]");
		object obj3 = (IntPtr)0;
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Reporter.Log log = obj3;
		Console.WriteLine("Method not found @24D67D8");
		obj3..ctor();
		object obj7;
		if (obj3 != 0)
		{
			log.condition = condition;
			Console.WriteLine("Method not found @24D64EC");
			log.stacktrace = stacktrace;
			Console.WriteLine("Method not found @24D64EC");
			object obj4 = obj + 28L;
			obj = obj;
			object obj5 = obj + 40L;
			List<Reporter.Log> list = this.threadedLogs;
			ref bool lockTaken = obj + 28L;
			Monitor.Enter(this.threadedLogs, ref lockTaken);
			List<object> list2 = this.threadedLogs;
			if (this.threadedLogs != 0)
			{
				Console.WriteLine("Unmanaged memory load: [v63 @ X0_v11 (System.Collections.Generic.List`1<System.Object>)+1C]");
				object obj6 = (IntPtr)0 + 1;
				Console.WriteLine("Unmanaged memory load: [v63 @ X0_v11 (System.Collections.Generic.List`1<System.Object>)+10]");
				if ((IntPtr)0 != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
					this.threadedLogs.AddWithResize(obj3);
					obj7 = obj + 28L;
					goto IL_2AA;
				}
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		Console.WriteLine("Method not found @24D67E8");
		IL_236:
		Console.WriteLine("Method not found @24D67E0");
		Console.WriteLine("Method not found @214852C");
		Console.WriteLine("Method not found @25C617C");
		Console.WriteLine("Method not found @21483A0");
		IL_2AA:
		if (obj7 != 0)
		{
			Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1+10]");
			object obj8 = (IntPtr)0;
			Monitor.Exit(obj8);
		}
		bool flag = obj == 0;
		if (flag)
		{
			return;
		}
		goto IL_236;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00030D4C File Offset: 0x0002EF4C
	private void _OnLevelWasLoaded(Scene _null1, LoadSceneMode _null2)
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523B8D0]");
		object obj = (IntPtr)0;
		if (!(~this.clearOnNewSceneLoaded))
		{
			this.clear();
		}
		Console.WriteLine("Unmanaged memory load: [523BC80]");
		object str = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BC78]");
		object str2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B018]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v35 @ X0_v12+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Scene activeScene = SceneManager.GetActiveScene();
		object obj3;
		Scene scene = obj3 + 12L;
		string name = scene.name;
		this.currentScene = name;
		Console.WriteLine("Method not found @24D64EC");
		Scene activeScene2 = SceneManager.GetActiveScene();
		Scene scene2 = obj3 + 12L;
		string name2 = scene2.name;
		string message = str + name2 + str2;
		Console.WriteLine("Unmanaged memory load: [v79 @ X8_v2+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Debug.Log(message);
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00030F6C File Offset: 0x0002F16C
	private void OnApplicationQuit()
	{
		Console.WriteLine("Unmanaged memory load: [523B9C8]");
		object key = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B928]");
		object key2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BA18]");
		object key3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B908]");
		object key4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BA00]");
		object key5 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BA58]");
		object key6 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BA48]");
		object key7 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B9B8]");
		object key8 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B988]");
		object key9 = (IntPtr)0;
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
		}
		int value;
		PlayerPrefs.SetInt(key, value);
		PlayerPrefs.SetInt(key2, value);
		PlayerPrefs.SetInt(key3, value);
		PlayerPrefs.SetInt(key4, value);
		PlayerPrefs.SetInt(key5, value);
		PlayerPrefs.SetInt(key6, value);
		PlayerPrefs.SetInt(key7, value);
		PlayerPrefs.SetInt(key8, value);
		PlayerPrefs.SetInt(key9, value);
		Console.WriteLine("Unmanaged memory load: [523B980]");
		object key10 = (IntPtr)0;
		PlayerPrefs.SetInt(key10, value);
		Console.WriteLine("Unmanaged memory load: [523B9E8]");
		object key11 = (IntPtr)0;
		PlayerPrefs.SetInt(key11, value);
		Console.WriteLine("Unmanaged memory load: [523BA20]");
		object key12 = (IntPtr)0;
		PlayerPrefs.SetInt(key12, value);
		Console.WriteLine("Unmanaged memory load: [523BA30]");
		object key13 = (IntPtr)0;
		PlayerPrefs.SetString(key13, this.filterText);
		Console.WriteLine("Method not found @4F26144");
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00031288 File Offset: 0x0002F488
	private IEnumerator readInfo()
	{
		if (this != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Reporter.<readInfo>d__188 <readInfo>d__;
		for (;;)
		{
			Console.WriteLine("Method not found @24D67D8");
			int <>1__state;
			<readInfo>d__..ctor(<>1__state);
			if (<readInfo>d__ != 0)
			{
				break;
			}
			Console.WriteLine("Method not found @24D67E8");
		}
		<readInfo>d__.<>4__this = this;
		Console.WriteLine("Method not found @24D64EC");
		return <readInfo>d__;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00031340 File Offset: 0x0002F540
	private void SaveLogsToDevice()
	{
		object obj;
		object path = obj - 128L;
		bool flag = this == 0;
		Console.WriteLine("Unmanaged memory load: [523B130]");
		object obj2 = (IntPtr)0;
		if (!flag)
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
		}
		Console.WriteLine("Unmanaged memory load: [523BC08]");
		object str = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BBF0]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BC00]");
		object str2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B018]");
		object obj4 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v38 @ X0_v28+E4]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		string persistentDataPath = Application.persistentDataPath;
		string text = persistentDataPath + str;
		Console.WriteLine("Method not found @24D67D8");
		obj3..ctor();
		string message = str2 + text;
		Console.WriteLine("Unmanaged memory load: [v86 @ X8_v2+E4]");
		bool flag3 = (IntPtr)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Debug.Log(message);
		path = text;
		File.Delete(text);
		List<Reporter.Log> list = this.logs;
		bool flag4 = this.logs == 0;
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
		object obj18 = obj5;
		Console.WriteLine("Unmanaged memory load: [v38 @ X0_v28+E4]");
		object obj19 = (IntPtr)0;
		object obj20 = obj4;
		object obj25;
		object obj26;
		object obj27;
		object obj28;
		object obj29;
		object obj30;
		object obj31;
		object obj32;
		object obj33;
		if (!flag4)
		{
			object obj21 = ~0L;
			object obj23;
			object obj22 = obj23;
			Console.WriteLine("Unmanaged memory load: [v112 @ X8_v3 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
			object obj24 = obj22 - (IntPtr)0;
			obj25 = obj23;
			Console.WriteLine("Unmanaged memory load: [523BBD8]");
			obj26 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B7A8]");
			obj27 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BBF8]");
			obj28 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523BB08]");
			obj29 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B0E8]");
			obj30 = (IntPtr)0;
			obj31 = obj24;
			Console.WriteLine("Unmanaged memory load: [v112 @ X8_v3 (System.Collections.Generic.List`1<Reporter+Log>)+18]");
			obj32 = (IntPtr)0;
			obj33 = obj21;
			goto IL_2D4;
		}
		IL_27D:
		Console.WriteLine("Method not found @24D67E8");
		obj25 = obj6;
		obj26 = obj8;
		obj27 = obj10;
		obj28 = obj12;
		obj29 = obj14;
		obj30 = obj16;
		obj31 = obj18;
		obj32 = obj19;
		obj33 = obj20;
		IL_2D4:
		bool flag5 = obj3 == 0;
		obj6 = obj25;
		obj8 = obj26;
		obj10 = obj27;
		obj12 = obj28;
		obj14 = obj29;
		obj16 = obj30;
		obj18 = obj31;
		obj19 = obj32;
		obj20 = obj33;
		if (!flag5)
		{
			object[] contents = obj3.ToArray();
			File.WriteAllLines(path, contents);
			return;
		}
		goto IL_27D;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x000317B0 File Offset: 0x0002F9B0
	public Reporter()
	{
		Console.WriteLine("Unmanaged memory load: [523BC90]");
		object obj = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BCA8]");
		object obj2 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BCB8]");
		object obj3 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B0F8]");
		object userData = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523BB98]");
		object obj4 = (IntPtr)0;
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
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Method not found @24D67D8");
		obj..ctor();
		this.samples = obj;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Unmanaged memory load: [523BCD0]");
		object obj5 = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		obj5..ctor();
		this.logs = obj5;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		obj5..ctor();
		this.collapsedLogs = obj5;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		obj5..ctor();
		this.currentLog = obj5;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		Console.WriteLine("Method not found @3C413B8");
		this.logsDic = obj2;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Method not found @24D67D8");
		obj3..ctor();
		this.cachedString = obj3;
		Console.WriteLine("Method not found @24D64EC");
		this.UserData = userData;
		Console.WriteLine("Not implemented instruction: Instruction STURH not yet implemented.");
		object obj7;
		object obj6 = obj7 | 72340172838076673L;
		Console.WriteLine("Not implemented instruction: Instruction STURB not yet implemented.");
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Not implemented instruction: Instruction MOVI not yet implemented.");
		Console.WriteLine("Not implemented instruction: Instruction MOVK not yet implemented.");
		this.errorContent = 1101004800L;
		this.buttonActiveStyle = userData;
		GUIContent guicontent;
		this.warningContent = guicontent;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Unmanaged memory load: [v150 @ X0_v42+E4]");
		bool flag = (IntPtr)0 == 0;
		if (flag)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Unmanaged memory load: [559218E]");
		bool flag2 = (IntPtr)0 == 0;
		if (flag2)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		object obj8 = this + 604L;
		Console.WriteLine("Unmanaged memory load: [v167 @ X0_v46+E4]");
		object obj9;
		if ((IntPtr)0 != 0)
		{
			obj9 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj9 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v175 @ X0_v48+B8]");
		object obj10 = (IntPtr)0;
		bool flag3 = obj9 == 0;
		if (flag3)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v189 @ X0_v51+E4]");
		object obj11;
		if ((IntPtr)0 != 0)
		{
			obj11 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj11 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v201 @ X0_v53+B8]");
		object obj12 = (IntPtr)0;
		bool flag4 = obj11 == 0;
		if (flag4)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v215 @ X0_v56+E4]");
		object obj13;
		if ((IntPtr)0 != 0)
		{
			obj13 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj13 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v227 @ X0_v58+B8]");
		object obj14 = (IntPtr)0;
		bool flag5 = obj13 == 0;
		if (flag5)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v241 @ X0_v61+E4]");
		object obj15;
		if ((IntPtr)0 != 0)
		{
			obj15 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj15 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v253 @ X0_v63+B8]");
		object obj16 = (IntPtr)0;
		bool flag6 = obj15 == 0;
		if (flag6)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v267 @ X0_v66+E4]");
		object obj17;
		if ((IntPtr)0 != 0)
		{
			obj17 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj17 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v279 @ X0_v68+B8]");
		object obj18 = (IntPtr)0;
		bool flag7 = obj17 == 0;
		if (flag7)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v293 @ X0_v71+E4]");
		object obj19;
		if ((IntPtr)0 != 0)
		{
			obj19 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj19 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v305 @ X0_v73+B8]");
		object obj20 = (IntPtr)0;
		bool flag8 = obj19 == 0;
		if (flag8)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v319 @ X0_v76+E4]");
		object obj21;
		if ((IntPtr)0 != 0)
		{
			obj21 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj21 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v331 @ X0_v78+B8]");
		object obj22 = (IntPtr)0;
		bool flag9 = obj21 == 0;
		if (flag9)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v345 @ X0_v81+E4]");
		object obj23;
		if ((IntPtr)0 != 0)
		{
			obj23 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj23 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v357 @ X0_v83+B8]");
		object obj24 = (IntPtr)0;
		bool flag10 = obj23 == 0;
		if (flag10)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v371 @ X0_v86+E4]");
		object obj25;
		if ((IntPtr)0 != 0)
		{
			obj25 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj25 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v383 @ X0_v88+B8]");
		object obj26 = (IntPtr)0;
		bool flag11 = obj25 == 0;
		if (flag11)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v397 @ X0_v91+E4]");
		object obj27;
		if ((IntPtr)0 != 0)
		{
			obj27 = 1L;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj27 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v409 @ X0_v93+B8]");
		object obj28 = (IntPtr)0;
		bool flag12 = obj27 == 0;
		if (flag12)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v423 @ X0_v96+E4]");
		object obj30;
		object obj29;
		if ((IntPtr)0 != 0)
		{
			obj29 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj29 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v436 @ X0_v98+B8]");
		object obj31 = (IntPtr)0;
		if (obj29 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v452 @ X0_v101+E4]");
		object obj32;
		if ((IntPtr)0 != 0)
		{
			obj32 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj32 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v464 @ X0_v103+B8]");
		object obj33 = (IntPtr)0;
		if (obj32 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v480 @ X0_v106+E4]");
		object obj34;
		if ((IntPtr)0 != 0)
		{
			obj34 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj34 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v492 @ X0_v108+B8]");
		object obj35 = (IntPtr)0;
		if (obj34 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v508 @ X0_v111+E4]");
		object obj36;
		if ((IntPtr)0 != 0)
		{
			obj36 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj36 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v520 @ X0_v113+B8]");
		object obj37 = (IntPtr)0;
		if (obj36 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v536 @ X0_v116+E4]");
		object obj38;
		if ((IntPtr)0 != 0)
		{
			obj38 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj38 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v548 @ X0_v118+B8]");
		object obj39 = (IntPtr)0;
		if (obj38 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v564 @ X0_v121+E4]");
		object obj40;
		if ((IntPtr)0 != 0)
		{
			obj40 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj40 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v576 @ X0_v123+B8]");
		object obj41 = (IntPtr)0;
		if (obj40 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [v592 @ X0_v126+E4]");
		object obj42;
		if ((IntPtr)0 != 0)
		{
			obj42 = obj30;
		}
		else
		{
			Console.WriteLine("Method not found @24D66BC");
			Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [559218E]");
			obj42 = (IntPtr)0;
		}
		Console.WriteLine("Unmanaged memory load: [v604 @ X0_v128+B8]");
		object obj43 = (IntPtr)0;
		if (obj42 != 0)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523B8F0]");
		object obj44 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [523B6F0]");
		object obj45 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v620 @ X0_v131+E4]");
		bool flag13 = (IntPtr)0 == 0;
		if (flag13)
		{
			Console.WriteLine("Method not found @24D66BC");
		}
		Console.WriteLine("Unmanaged memory load: [v637 @ X0_v133+B8]");
		object obj46 = (IntPtr)0;
		Console.WriteLine("Method not found @24D67D8");
		obj44..ctor();
		this.tempContent = obj44;
		Console.WriteLine("Method not found @24D64EC");
		this.graphSize = 4f;
		Console.WriteLine("Method not found @24D67D8");
		obj45..ctor();
		this.gestureDetector = obj45;
		Console.WriteLine("Method not found @24D64EC");
		Console.WriteLine("Unmanaged memory load: [559212F]");
		bool flag14 = (IntPtr)0 == 0;
		if (flag14)
		{
			Console.WriteLine("Method not found @24D6540");
		}
		Console.WriteLine("Unmanaged memory load: [523B1A0]");
		object obj47 = (IntPtr)0;
		Console.WriteLine("Unmanaged memory load: [v680 @ X8_v6+B8]");
		object obj48 = (IntPtr)0;
		this.lastClickTime = -1f;
		Console.WriteLine("Unmanaged memory load: [523BCD0]");
		object obj49 = (IntPtr)0;
		this.gestureSum = obj48;
		this.firstTime = (1L != 0L);
		Console.WriteLine("Method not found @24D67D8");
		obj49..ctor();
		this.threadedLogs = obj49;
		Console.WriteLine("Method not found @24D64EC");
		base..ctor();
	}

	// Token: 0x04000255 RID: 597
	private List<Reporter.Sample> samples;

	// Token: 0x04000256 RID: 598
	private List<Reporter.Log> logs;

	// Token: 0x04000257 RID: 599
	private List<Reporter.Log> collapsedLogs;

	// Token: 0x04000258 RID: 600
	private List<Reporter.Log> currentLog;

	// Token: 0x04000259 RID: 601
	private MultiKeyDictionary<string, string, Reporter.Log> logsDic;

	// Token: 0x0400025A RID: 602
	private Dictionary<string, string> cachedString;

	// Token: 0x0400025B RID: 603
	public bool show;

	// Token: 0x0400025C RID: 604
	private bool collapse;

	// Token: 0x0400025D RID: 605
	private bool clearOnNewSceneLoaded;

	// Token: 0x0400025E RID: 606
	private bool showTime;

	// Token: 0x0400025F RID: 607
	private bool showScene;

	// Token: 0x04000260 RID: 608
	private bool showMemory;

	// Token: 0x04000261 RID: 609
	private bool showFps;

	// Token: 0x04000262 RID: 610
	private bool showGraph;

	// Token: 0x04000263 RID: 611
	private bool showLog;

	// Token: 0x04000264 RID: 612
	private bool showWarning;

	// Token: 0x04000265 RID: 613
	private bool showError;

	// Token: 0x04000266 RID: 614
	private int numOfLogs;

	// Token: 0x04000267 RID: 615
	private int numOfLogsWarning;

	// Token: 0x04000268 RID: 616
	private int numOfLogsError;

	// Token: 0x04000269 RID: 617
	private int numOfCollapsedLogs;

	// Token: 0x0400026A RID: 618
	private int numOfCollapsedLogsWarning;

	// Token: 0x0400026B RID: 619
	private int numOfCollapsedLogsError;

	// Token: 0x0400026C RID: 620
	private bool showClearOnNewSceneLoadedButton;

	// Token: 0x0400026D RID: 621
	private bool showTimeButton;

	// Token: 0x0400026E RID: 622
	private bool showSceneButton;

	// Token: 0x0400026F RID: 623
	private bool showMemButton;

	// Token: 0x04000270 RID: 624
	private bool showFpsButton;

	// Token: 0x04000271 RID: 625
	private bool showSearchText;

	// Token: 0x04000272 RID: 626
	private bool showCopyButton;

	// Token: 0x04000273 RID: 627
	private bool showSaveButton;

	// Token: 0x04000274 RID: 628
	private string buildDate;

	// Token: 0x04000275 RID: 629
	private string logDate;

	// Token: 0x04000276 RID: 630
	private float logsMemUsage;

	// Token: 0x04000277 RID: 631
	private float graphMemUsage;

	// Token: 0x04000278 RID: 632
	private float gcTotalMemory;

	// Token: 0x04000279 RID: 633
	public string UserData;

	// Token: 0x0400027A RID: 634
	public float fps;

	// Token: 0x0400027B RID: 635
	public string fpsText;

	// Token: 0x0400027C RID: 636
	private Reporter.ReportView currentView;

	// Token: 0x0400027D RID: 637
	private static bool created;

	// Token: 0x0400027E RID: 638
	public Images images;

	// Token: 0x0400027F RID: 639
	private GUIContent clearContent;

	// Token: 0x04000280 RID: 640
	private GUIContent collapseContent;

	// Token: 0x04000281 RID: 641
	private GUIContent clearOnNewSceneContent;

	// Token: 0x04000282 RID: 642
	private GUIContent showTimeContent;

	// Token: 0x04000283 RID: 643
	private GUIContent showSceneContent;

	// Token: 0x04000284 RID: 644
	private GUIContent userContent;

	// Token: 0x04000285 RID: 645
	private GUIContent showMemoryContent;

	// Token: 0x04000286 RID: 646
	private GUIContent softwareContent;

	// Token: 0x04000287 RID: 647
	private GUIContent dateContent;

	// Token: 0x04000288 RID: 648
	private GUIContent showFpsContent;

	// Token: 0x04000289 RID: 649
	private GUIContent infoContent;

	// Token: 0x0400028A RID: 650
	private GUIContent saveLogsContent;

	// Token: 0x0400028B RID: 651
	private GUIContent searchContent;

	// Token: 0x0400028C RID: 652
	private GUIContent copyContent;

	// Token: 0x0400028D RID: 653
	private GUIContent closeContent;

	// Token: 0x0400028E RID: 654
	private GUIContent buildFromContent;

	// Token: 0x0400028F RID: 655
	private GUIContent systemInfoContent;

	// Token: 0x04000290 RID: 656
	private GUIContent graphicsInfoContent;

	// Token: 0x04000291 RID: 657
	private GUIContent backContent;

	// Token: 0x04000292 RID: 658
	private GUIContent logContent;

	// Token: 0x04000293 RID: 659
	private GUIContent warningContent;

	// Token: 0x04000294 RID: 660
	private GUIContent errorContent;

	// Token: 0x04000295 RID: 661
	private GUIStyle barStyle;

	// Token: 0x04000296 RID: 662
	private GUIStyle buttonActiveStyle;

	// Token: 0x04000297 RID: 663
	private GUIStyle nonStyle;

	// Token: 0x04000298 RID: 664
	private GUIStyle lowerLeftFontStyle;

	// Token: 0x04000299 RID: 665
	private GUIStyle backStyle;

	// Token: 0x0400029A RID: 666
	private GUIStyle evenLogStyle;

	// Token: 0x0400029B RID: 667
	private GUIStyle oddLogStyle;

	// Token: 0x0400029C RID: 668
	private GUIStyle logButtonStyle;

	// Token: 0x0400029D RID: 669
	private GUIStyle selectedLogStyle;

	// Token: 0x0400029E RID: 670
	private GUIStyle selectedLogFontStyle;

	// Token: 0x0400029F RID: 671
	private GUIStyle stackLabelStyle;

	// Token: 0x040002A0 RID: 672
	private GUIStyle scrollerStyle;

	// Token: 0x040002A1 RID: 673
	private GUIStyle searchStyle;

	// Token: 0x040002A2 RID: 674
	private GUIStyle sliderBackStyle;

	// Token: 0x040002A3 RID: 675
	private GUIStyle sliderThumbStyle;

	// Token: 0x040002A4 RID: 676
	private GUISkin toolbarScrollerSkin;

	// Token: 0x040002A5 RID: 677
	private GUISkin logScrollerSkin;

	// Token: 0x040002A6 RID: 678
	private GUISkin graphScrollerSkin;

	// Token: 0x040002A7 RID: 679
	public Vector2 size;

	// Token: 0x040002A8 RID: 680
	public float maxSize;

	// Token: 0x040002A9 RID: 681
	public int numOfCircleToShow;

	// Token: 0x040002AA RID: 682
	private static string[] scenes;

	// Token: 0x040002AB RID: 683
	private string currentScene;

	// Token: 0x040002AC RID: 684
	private string filterText;

	// Token: 0x040002AD RID: 685
	private string deviceModel;

	// Token: 0x040002AE RID: 686
	private string deviceType;

	// Token: 0x040002AF RID: 687
	private string deviceName;

	// Token: 0x040002B0 RID: 688
	private string graphicsMemorySize;

	// Token: 0x040002B1 RID: 689
	private string maxTextureSize;

	// Token: 0x040002B2 RID: 690
	private string systemMemorySize;

	// Token: 0x040002B3 RID: 691
	public bool Initialized;

	// Token: 0x040002B4 RID: 692
	private Rect screenRect;

	// Token: 0x040002B5 RID: 693
	private Rect toolBarRect;

	// Token: 0x040002B6 RID: 694
	private Rect logsRect;

	// Token: 0x040002B7 RID: 695
	private Rect stackRect;

	// Token: 0x040002B8 RID: 696
	private Rect graphRect;

	// Token: 0x040002B9 RID: 697
	private Rect graphMinRect;

	// Token: 0x040002BA RID: 698
	private Rect graphMaxRect;

	// Token: 0x040002BB RID: 699
	private Rect buttomRect;

	// Token: 0x040002BC RID: 700
	private Vector2 stackRectTopLeft;

	// Token: 0x040002BD RID: 701
	private Rect detailRect;

	// Token: 0x040002BE RID: 702
	private Vector2 scrollPosition;

	// Token: 0x040002BF RID: 703
	private Vector2 scrollPosition2;

	// Token: 0x040002C0 RID: 704
	private Vector2 toolbarScrollPosition;

	// Token: 0x040002C1 RID: 705
	private Reporter.Log selectedLog;

	// Token: 0x040002C2 RID: 706
	private float toolbarOldDrag;

	// Token: 0x040002C3 RID: 707
	private float oldDrag;

	// Token: 0x040002C4 RID: 708
	private float oldDrag2;

	// Token: 0x040002C5 RID: 709
	private float oldDrag3;

	// Token: 0x040002C6 RID: 710
	private int startIndex;

	// Token: 0x040002C7 RID: 711
	private Rect countRect;

	// Token: 0x040002C8 RID: 712
	private Rect timeRect;

	// Token: 0x040002C9 RID: 713
	private Rect timeLabelRect;

	// Token: 0x040002CA RID: 714
	private Rect sceneRect;

	// Token: 0x040002CB RID: 715
	private Rect sceneLabelRect;

	// Token: 0x040002CC RID: 716
	private Rect memoryRect;

	// Token: 0x040002CD RID: 717
	private Rect memoryLabelRect;

	// Token: 0x040002CE RID: 718
	private Rect fpsRect;

	// Token: 0x040002CF RID: 719
	private Rect fpsLabelRect;

	// Token: 0x040002D0 RID: 720
	private GUIContent tempContent;

	// Token: 0x040002D1 RID: 721
	private Vector2 infoScrollPosition;

	// Token: 0x040002D2 RID: 722
	private Vector2 oldInfoDrag;

	// Token: 0x040002D3 RID: 723
	private Rect tempRect;

	// Token: 0x040002D4 RID: 724
	private float graphSize;

	// Token: 0x040002D5 RID: 725
	private int startFrame;

	// Token: 0x040002D6 RID: 726
	private int currentFrame;

	// Token: 0x040002D7 RID: 727
	private Vector3 tempVector1;

	// Token: 0x040002D8 RID: 728
	private Vector3 tempVector2;

	// Token: 0x040002D9 RID: 729
	private Vector2 graphScrollerPos;

	// Token: 0x040002DA RID: 730
	private float maxFpsValue;

	// Token: 0x040002DB RID: 731
	private float minFpsValue;

	// Token: 0x040002DC RID: 732
	private float maxMemoryValue;

	// Token: 0x040002DD RID: 733
	private float minMemoryValue;

	// Token: 0x040002DE RID: 734
	private List<Vector2> gestureDetector;

	// Token: 0x040002DF RID: 735
	private Vector2 gestureSum;

	// Token: 0x040002E0 RID: 736
	private float gestureLength;

	// Token: 0x040002E1 RID: 737
	private int gestureCount;

	// Token: 0x040002E2 RID: 738
	private float lastClickTime;

	// Token: 0x040002E3 RID: 739
	private Vector2 startPos;

	// Token: 0x040002E4 RID: 740
	private Vector2 downPos;

	// Token: 0x040002E5 RID: 741
	private Vector2 mousePosition;

	// Token: 0x040002E6 RID: 742
	private int frames;

	// Token: 0x040002E7 RID: 743
	private bool firstTime;

	// Token: 0x040002E8 RID: 744
	private float lastUpdate;

	// Token: 0x040002E9 RID: 745
	private const int requiredFrames = 10;

	// Token: 0x040002EA RID: 746
	private const float updateInterval = 0.25f;

	// Token: 0x040002EB RID: 747
	private List<Reporter.Log> threadedLogs;

	// Token: 0x0200008F RID: 143
	public enum _LogType
	{
		// Token: 0x04000430 RID: 1072
		Assert = 1,
		// Token: 0x04000431 RID: 1073
		Error = 0,
		// Token: 0x04000432 RID: 1074
		Exception = 4,
		// Token: 0x04000433 RID: 1075
		Log = 3,
		// Token: 0x04000434 RID: 1076
		Warning = 2
	}

	// Token: 0x02000090 RID: 144
	public class Sample
	{
		// Token: 0x06000397 RID: 919 RVA: 0x00044608 File Offset: 0x00042808
		public static float MemSize()
		{
			float result;
			return result;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0004461C File Offset: 0x0004281C
		public string GetSceneName()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [523BCD8]");
			return (IntPtr)0;
		}

		// Token: 0x04000435 RID: 1077
		public float time;

		// Token: 0x04000436 RID: 1078
		public byte loadedScene;

		// Token: 0x04000437 RID: 1079
		public float memory;

		// Token: 0x04000438 RID: 1080
		public float fps;

		// Token: 0x04000439 RID: 1081
		public string fpsText;
	}

	// Token: 0x02000091 RID: 145
	public class Log
	{
		// Token: 0x0600039A RID: 922 RVA: 0x000446BC File Offset: 0x000428BC
		public Reporter.Log CreateCopy()
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Reporter.Log log;
			for (;;)
			{
				log = base.MemberwiseClone();
				if (log == 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D6B68");
			}
			return log;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00044754 File Offset: 0x00042954
		public float GetMemoryUsage()
		{
			/*
An exception occurred when decompiling this method (0600039B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Reporter/Log::GetMemoryUsage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_52:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1815
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1783
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0400043A RID: 1082
		public int count = (int)1L;

		// Token: 0x0400043B RID: 1083
		public Reporter._LogType logType;

		// Token: 0x0400043C RID: 1084
		public string condition;

		// Token: 0x0400043D RID: 1085
		public string stacktrace;

		// Token: 0x0400043E RID: 1086
		public int sampleId;
	}

	// Token: 0x02000092 RID: 146
	private enum ReportView
	{
		// Token: 0x04000440 RID: 1088
		None,
		// Token: 0x04000441 RID: 1089
		Logs,
		// Token: 0x04000442 RID: 1090
		Info,
		// Token: 0x04000443 RID: 1091
		Snapshot
	}

	// Token: 0x02000093 RID: 147
	private enum DetailView
	{
		// Token: 0x04000445 RID: 1093
		None,
		// Token: 0x04000446 RID: 1094
		StackTrace,
		// Token: 0x04000447 RID: 1095
		Graph
	}

	// Token: 0x02000094 RID: 148
	private sealed class <readInfo>d__188 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600039D RID: 925 RVA: 0x000447E0 File Offset: 0x000429E0
		public <readInfo>d__188(int <>1__state)
		{
			int num;
			this.<>1__state = num;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000040D1 File Offset: 0x000022D1
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0004480C File Offset: 0x00042A0C
		bool IEnumerator.MoveNext()
		{
			bool flag = this == 0;
			Reporter.<readInfo>d__188 <readInfo>d__ = this;
			if (!flag)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Reporter.<readInfo>d__188 <readInfo>d__2;
				<readInfo>d__ = <readInfo>d__2;
			}
			bool result;
			while (this.<>1__state == 0)
			{
				Console.WriteLine("Unmanaged memory load: [523BCF0]");
				object obj = (IntPtr)0;
				int num = (int)(~(int)0L);
				this.<>1__state = num;
				if (obj != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523BCF8]");
					object value = (IntPtr)0;
					int num2 = obj.IndexOf(value);
					object obj2;
					bool flag2 = obj2 == 0;
					bool flag3 = obj.Contains(value);
					string uri = obj;
					if (!flag2)
					{
						Console.WriteLine("Unmanaged memory load: [523BCE8]");
						object str = (IntPtr)0;
						string text = str + obj;
						uri = text;
					}
					UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
					this.<www>5__2 = unityWebRequest;
					Console.WriteLine("Method not found @24D64EC");
					if (this != 0)
					{
						UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = base.SendWebRequest();
						this.<>2__current = unityWebRequestAsyncOperation;
						Console.WriteLine("Method not found @24D64EC");
						bool flag4;
						result = flag4;
						IL_1E0:
						Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
						return result;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			result = (<readInfo>d__ != null);
			goto IL_1E0;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00044A6C File Offset: 0x00042C6C
		object IEnumerator<object>.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00044A80 File Offset: 0x00042C80
		void IEnumerator.Reset()
		{
			/*
An exception occurred when decompiling this method (060003A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Reporter/<readInfo>d__188::System.Collections.IEnumerator.Reset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	Block_0:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67D8")); 	call:void(Console::WriteLine, ldstr:string("Unmanaged memory load: [523B230]")); 	call:void(NotSupportedException::.ctor, conv.i:native int[exp:NotSupportedException](ldc.i4:int32[exp:native int](0))); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D6554")); 	call:void(Console::WriteLine, ldstr:string("Method not found @24D66AC")); 	call:void(Console::WriteLine, ldstr:string("Warning: 'this' local not found (operand: X0)")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00044AE4 File Offset: 0x00042CE4
		object IEnumerator.Current
		{
			get
			{
				return this.<>2__current;
			}
		}

		// Token: 0x04000448 RID: 1096
		private int <>1__state;

		// Token: 0x04000449 RID: 1097
		private object <>2__current;

		// Token: 0x0400044A RID: 1098
		public Reporter <>4__this;

		// Token: 0x0400044B RID: 1099
		private UnityWebRequest <www>5__2;
	}
}
