using System;
using System.Collections.Generic;
using System.Text;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.DataModels;
using PlayFab.EconomyModels;
using PlayFab.Internal;
using UnityEngine;

namespace BackEnd
{
	// Token: 0x02000079 RID: 121
	public class BackEndManager : MonoBehaviour
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0003E7F8 File Offset: 0x0003C9F8
		public static BackEndManager Instance
		{
			get
			{
				Console.WriteLine("Unmanaged memory load: [523B400]");
				object obj = (IntPtr)0;
				object obj2;
				if (obj2 == null)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Console.WriteLine("Unmanaged memory load: [v22 @ X8_v1+B8]");
				return (IntPtr)0;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0003E874 File Offset: 0x0003CA74
		// (set) Token: 0x06000300 RID: 768 RVA: 0x0003E884 File Offset: 0x0003CA84
		public bool ServiceActive
		{
			get
			{
				return this != null;
			}
			set
			{
				bool serviceActive;
				this._serviceActive = serviceActive;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0003E89C File Offset: 0x0003CA9C
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		public bool LogedIn
		{
			get
			{
				return this != null;
			}
			set
			{
				bool logedIn;
				this._logedIn = logedIn;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0003E8D4 File Offset: 0x0003CAD4
		public bool dataReturned
		{
			get
			{
				return this != null;
			}
			set
			{
				bool dataReturned;
				this._dataReturned = dataReturned;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0003E8EC File Offset: 0x0003CAEC
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0003E8FC File Offset: 0x0003CAFC
		public bool Updating
		{
			get
			{
				return this != null;
			}
			set
			{
				bool updating;
				this._updating = updating;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0003E914 File Offset: 0x0003CB14
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0003E928 File Offset: 0x0003CB28
		public PlayFabAuthenticationContext Authcontext
		{
			get
			{
				return this._authcontext;
			}
			set
			{
				this._authcontext = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0003E94C File Offset: 0x0003CB4C
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0003E95C File Offset: 0x0003CB5C
		public bool PlayerAccountNewlyCreated
		{
			get
			{
				return this != null;
			}
			set
			{
				bool playerAccountNewlyCreated;
				this._playerAccountNewlyCreated = playerAccountNewlyCreated;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0003E974 File Offset: 0x0003CB74
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0003E988 File Offset: 0x0003CB88
		public string PlayerPlayFabID
		{
			get
			{
				return this._playerPlayFabID;
			}
			set
			{
				this._playerPlayFabID = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0003E9AC File Offset: 0x0003CBAC
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		public string PlayerTitleDisplayName
		{
			get
			{
				return this._playerTitleDisplayName;
			}
			set
			{
				this._playerTitleDisplayName = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0003E9F8 File Offset: 0x0003CBF8
		public string PlayerMasterID
		{
			get
			{
				return this._playerMasterID;
			}
			set
			{
				this._playerMasterID = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0003EA30 File Offset: 0x0003CC30
		public string EntityID
		{
			get
			{
				return this._entityID;
			}
			set
			{
				this._entityID = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0003EA54 File Offset: 0x0003CC54
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0003EA68 File Offset: 0x0003CC68
		public string EntityType
		{
			get
			{
				return this._entityType;
			}
			set
			{
				this._entityType = value;
				Console.WriteLine("Method not found @24D64EC");
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0003EA8C File Offset: 0x0003CC8C
		private void Awake()
		{
			UnityEngine.Object @object;
			IntPtr cachedPtr;
			@object.m_CachedPtr = cachedPtr;
			Console.WriteLine("Unmanaged memory load: [523B400]");
			object obj = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523ADE0]");
			object obj2 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [v27 @ X8_v1+B8]");
			object x = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v29 @ X0_v6+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			bool flag2 = @object == 0;
			bool flag3 = x != @object;
			if (flag2)
			{
				Console.WriteLine("Unmanaged memory load: [v51 @ X8_v4+B8]");
				object x2 = (IntPtr)0;
				Console.WriteLine("Unmanaged memory load: [v53 @ X0_v10+E4]");
				bool flag4 = (IntPtr)0 == 0;
				if (flag4)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				bool flag5 = @object == 0;
				bool flag6 = x2 != this;
				if (flag5)
				{
					GameObject gameObject = base.gameObject;
					Console.WriteLine("Unmanaged memory load: [v124 @ X8_v6+E4]");
					bool flag7 = (IntPtr)0 == 0;
					if (flag7)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					UnityEngine.Object.Destroy(gameObject);
					return;
				}
			}
			Console.WriteLine("Unmanaged memory load: [v76 @ X8_v8+B8]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			GameObject gameObject2 = base.gameObject;
			Console.WriteLine("Unmanaged memory load: [v97 @ X8_v11+E4]");
			bool flag8 = (IntPtr)0 == 0;
			if (flag8)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000409A File Offset: 0x0000229A
		private void Start()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0003ED38 File Offset: 0x0003CF38
		public void Login(Action<LoginResult> onLoginSuccess, Action<PlayFabError> onLoginFailure)
		{
			object obj2;
			object obj = obj2 - 80L;
			Console.WriteLine("Unmanaged memory load: [523C3B0]");
			object obj3 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj4;
			LoginWithAndroidDeviceIDRequest loginWithAndroidDeviceIDRequest;
			string titleId;
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj3..ctor();
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C3C0]");
					obj4 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523C3D0]");
					object obj5 = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					loginWithAndroidDeviceIDRequest = obj4;
					Console.WriteLine("Method not found @24D67D8");
					obj4..ctor();
					Console.WriteLine("Unmanaged memory load: [v125 @ X0_v21+E4]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D66BC");
					}
					titleId = PlayFabSettings.TitleId;
					if (obj4 != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3B8]");
			object obj6 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C3D8]");
			object method = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj7 = (IntPtr)0;
			loginWithAndroidDeviceIDRequest.TitleId = titleId;
			Console.WriteLine("Method not found @24D64EC");
			bool? flag2 = obj + 12L;
			Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
			flag2 = new bool?(titleId != null);
			Console.WriteLine("Not implemented instruction: Instruction LDRH not yet implemented.");
			Console.WriteLine("Not implemented instruction: Instruction STRH not yet implemented.");
			string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
			loginWithAndroidDeviceIDRequest.AndroidDeviceId = deviceUniqueIdentifier;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj6..ctor(obj3, method);
			Console.WriteLine("Unmanaged memory load: [v164 @ X0_v30+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			PlayFabClientAPI.LoginWithAndroidDeviceID(obj4, obj6, onLoginFailure, obj, obj);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0003F050 File Offset: 0x0003D250
		public void DoCreateDraftItem(CreateDraftItemRequest request, Action<CreateDraftItemResponse> onCreateDraftItem, Action<PlayFabError> onCreateDraftItemError, bool publish = true)
		{
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			while (request == 0)
			{
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj = (IntPtr)0;
			object obj2;
			Dictionary<string, string> customTags = obj2 & 1L;
			PlayFabAuthenticationContext authcontext = this._authcontext;
			Console.WriteLine("Method not found @24D64EC");
			request.CustomTags = customTags;
			Console.WriteLine("Unmanaged memory load: [v46 @ X0_v6+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			PlayFabEconomyAPI.CreateDraftItem(request, onCreateDraftItem, onCreateDraftItemError, obj3, obj3);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0003F188 File Offset: 0x0003D388
		public void GetUserInfo(PlayFabAuthenticationContext authcontext, Action<GetAccountInfoResult> onAccountInfo, Action<PlayFabError> onAccountInfoError)
		{
			Console.WriteLine("Unmanaged memory load: [523C3E8]");
			object obj = (IntPtr)0;
			if (authcontext != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			PlayFabClientAPI.GetAccountInfo(obj, onAccountInfo, onAccountInfoError, obj3, obj3);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0003F2D0 File Offset: 0x0003D4D0
		public void GetUserInfo(string titleDisplayName, Action<GetAccountInfoResult> onAccountInfo, Action<PlayFabError> onAccountInfoError)
		{
			Console.WriteLine("Unmanaged memory load: [523C3E8]");
			object obj = (IntPtr)0;
			if (titleDisplayName != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			GetAccountInfoRequest getAccountInfoRequest;
			object obj2;
			for (;;)
			{
				getAccountInfoRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				bool flag = obj2 == 0;
				bool flag2 = string.IsNullOrEmpty(titleDisplayName);
				if (flag)
				{
					break;
				}
				if (obj != 0)
				{
					goto Block_3;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			return;
			Block_3:
			getAccountInfoRequest.TitleDisplayName = titleDisplayName;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v95 @ X0_v11+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			PlayFabClientAPI.GetAccountInfo(obj, onAccountInfo, onAccountInfoError, obj2, obj2);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0003F464 File Offset: 0x0003D664
		public void GetUserInfoByID(string playfabID, Action<GetAccountInfoResult> onAccountInfo, Action<PlayFabError> onAccountInfoError)
		{
			Console.WriteLine("Unmanaged memory load: [523C3E8]");
			object obj = (IntPtr)0;
			if (playfabID != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			GetAccountInfoRequest getAccountInfoRequest;
			object obj2;
			for (;;)
			{
				getAccountInfoRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				bool flag = obj2 == 0;
				bool flag2 = string.IsNullOrEmpty(playfabID);
				if (flag)
				{
					break;
				}
				if (obj != 0)
				{
					goto Block_3;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			return;
			Block_3:
			getAccountInfoRequest.PlayFabId = playfabID;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v95 @ X0_v11+E4]");
			bool flag3 = (IntPtr)0 == 0;
			if (flag3)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			PlayFabClientAPI.GetAccountInfo(obj, onAccountInfo, onAccountInfoError, obj2, obj2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0003F5F8 File Offset: 0x0003D7F8
		public void SetUserData(PlayFabAuthenticationContext authcontext, Dictionary<string, string> data, Action<UpdateUserDataResult> onUpdateUserData, Action<PlayFabError> onUpdateUserDataError)
		{
			object obj2;
			object obj = obj2 - 80L;
			Console.WriteLine("Unmanaged memory load: [523C3F0]");
			object obj3 = (IntPtr)0;
			if (authcontext != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			UpdateUserDataRequest updateUserDataRequest;
			for (;;)
			{
				updateUserDataRequest = obj3;
				Console.WriteLine("Method not found @24D67D8");
				obj3..ctor();
				if (obj3 != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			updateUserDataRequest.Data = data;
			Console.WriteLine("Method not found @24D64EC");
			Int32Enum? int32Enum = obj + 8L;
			int32Enum = new Int32Enum?(data);
			Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Object)+8]");
			IntPtr intPtr = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [v110 @ X0_v13+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			PlayFabClientAPI.UpdateUserData(obj3, onUpdateUserData, onUpdateUserDataError, obj, obj);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		public void GetUserData(string playFabId, Action<GetUserDataResult> onGetUserData, Action<PlayFabError> onGetUserDataError)
		{
			Console.WriteLine("Unmanaged memory load: [523C400]");
			object obj = (IntPtr)0;
			if (playFabId != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			GetUserDataRequest getUserDataRequest;
			for (;;)
			{
				getUserDataRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj2 = (IntPtr)0;
			getUserDataRequest.PlayFabId = playFabId;
			Console.WriteLine("Method not found @24D64EC");
			object obj3;
			getUserDataRequest.Keys = obj3;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v83 @ X0_v10+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			PlayFabClientAPI.GetUserData(obj, onGetUserData, onGetUserDataError, obj3, obj3);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0003F930 File Offset: 0x0003DB30
		public void SearchItems(SearchItemsRequest request, Action<SearchItemsResponse> onSearchItem, Action<PlayFabError> onSearchItemError)
		{
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj = (IntPtr)0;
			if (request != 0)
			{
				Console.WriteLine("Method not found @24D6540");
			}
			Console.WriteLine("Unmanaged memory load: [v32 @ X0_v4+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj2;
			PlayFabEconomyAPI.SearchItems(request, onSearchItem, onSearchItemError, obj2, obj2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0003FA10 File Offset: 0x0003DC10
		public void LoadFile(string fileName, Action<string> onGetFileData, Action<string> onGetFileDataError)
		{
			/*
An exception occurred when decompiling this method (0600031F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager::LoadFile(System.String,System.Action`1<System.String>,System.Action`1<System.String>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_F1:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0003FB18 File Offset: 0x0003DD18
		public void LoadFile(PlayFab.DataModels.EntityKey entityKey, string fileName, Action<string> onGetFileData, Action<string> onGetFileDataError)
		{
			Console.WriteLine("Unmanaged memory load: [523C410]");
			object obj = (IntPtr)0;
			if (entityKey != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			object obj2;
			GetFilesRequest getFilesRequest;
			for (;;)
			{
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C420]");
					obj2 = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					getFilesRequest = obj2;
					Console.WriteLine("Method not found @24D67D8");
					obj2..ctor();
					if (obj2 != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C418]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C430]");
			object method = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B3B0]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C438]");
			object method2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C428]");
			object obj5 = (IntPtr)0;
			getFilesRequest.Entity = entityKey;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor(obj, method);
			Console.WriteLine("Method not found @24D67D8");
			obj4..ctor(obj, method2);
			Console.WriteLine("Unmanaged memory load: [v154 @ X0_v25+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj6;
			PlayFabDataAPI.GetFiles(obj2, obj3, obj4, obj6, obj6);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0003FDB0 File Offset: 0x0003DFB0
		public void UploadFile(string fileName, string fileData, Action<string> onUploadFileData, Action<string> onUploadFileDataError)
		{
			Console.WriteLine("Unmanaged memory load: [523C440]");
			object obj = (IntPtr)0;
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
			}
			object obj2;
			object obj3;
			InitiateFileUploadsRequest initiateFileUploadsRequest;
			for (;;)
			{
				obj2 = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C450]");
					obj3 = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [523C408]");
					object obj4 = (IntPtr)0;
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					Console.WriteLine("Method not found @24D64EC");
					initiateFileUploadsRequest = obj3;
					Console.WriteLine("Method not found @24D67D8");
					obj3..ctor();
					Console.WriteLine("Method not found @24D67D8");
					obj4..ctor();
					Console.WriteLine("Method not found @24D64EC");
					if (obj2 != 0)
					{
						string entityID = this._entityID;
						Console.WriteLine("Method not found @24D64EC");
						if (obj2 != 0)
						{
							string entityType = this._entityType;
							Console.WriteLine("Method not found @24D64EC");
							if (obj3 != 0)
							{
								Console.WriteLine("Unmanaged memory load: [523BBF0]");
								object obj5 = (IntPtr)0;
								InitiateFileUploadsRequest initiateFileUploadsRequest2 = initiateFileUploadsRequest;
								Console.WriteLine("Unmanaged memory load: [v41 @ X0_v24 (System.Object)+18]");
								initiateFileUploadsRequest2.Entity = (IntPtr)0;
								Console.WriteLine("Method not found @24D64EC");
								Console.WriteLine("Method not found @24D67D8");
								obj5..ctor();
								Console.WriteLine("Method not found @24D64EC");
								if (obj2 != 0)
								{
									Console.WriteLine("Unmanaged memory load: [v80 @ X0_v39 (System.Collections.Generic.List`1<System.Object>)+1C]");
									object obj6 = (IntPtr)0 + 1;
									Console.WriteLine("Unmanaged memory load: [v80 @ X0_v39 (System.Collections.Generic.List`1<System.Object>)+10]");
									if ((IntPtr)0 != 0)
									{
										break;
									}
								}
							}
						}
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C448]");
			object obj7 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C458]");
			object method = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B3B0]");
			object obj8 = (IntPtr)0;
			Console.WriteLine("Not implemented instruction: Instruction LDRSW not yet implemented.");
			Console.WriteLine("Unmanaged memory load: [523C460]");
			object method2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C428]");
			object obj9 = (IntPtr)0;
			List<object> list = obj2;
			Console.WriteLine("Unmanaged memory load: [v41 @ X0_v24 (System.Object)+10]");
			list.AddWithResize((IntPtr)0);
			InitiateFileUploadsRequest initiateFileUploadsRequest3 = initiateFileUploadsRequest;
			Console.WriteLine("Unmanaged memory load: [v41 @ X0_v24 (System.Object)+20]");
			initiateFileUploadsRequest3.FileNames = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj7..ctor(obj, method);
			Console.WriteLine("Method not found @24D67D8");
			obj8..ctor(obj, method2);
			Console.WriteLine("Unmanaged memory load: [v255 @ X0_v43+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj10;
			PlayFabDataAPI.InitiateFileUploads(obj3, obj7, obj8, obj10, obj10);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0004022C File Offset: 0x0003E42C
		public void ReviewItem(string itemID, int rating, Action<ReviewItemResponse> onReviewItem, Action<PlayFabError> onReviewItemError)
		{
			Console.WriteLine("Unmanaged memory load: [523C468]");
			object obj = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			ReviewItemRequest reviewItemRequest;
			object obj2;
			Review review;
			for (;;)
			{
				reviewItemRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C470]");
					obj2 = (IntPtr)0;
					PlayFabAuthenticationContext authcontext = this._authcontext;
					Console.WriteLine("Method not found @24D64EC");
					reviewItemRequest.Id = itemID;
					Console.WriteLine("Method not found @24D64EC");
					review = obj2;
					Console.WriteLine("Method not found @24D67D8");
					obj2..ctor();
					if (obj2 != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj3 = (IntPtr)0;
			int rating2;
			review.Rating = rating2;
			reviewItemRequest.Review = obj2;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v114 @ X0_v14+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj4;
			PlayFabEconomyAPI.ReviewItem(obj, onReviewItem, onReviewItemError, obj4, obj4);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0004041C File Offset: 0x0003E61C
		public void GetItems(List<string> itemIDs, Action<GetItemsResponse> onGetItems, Action<PlayFabError> onGetItemsError)
		{
			Console.WriteLine("Unmanaged memory load: [523C478]");
			object obj = (IntPtr)0;
			if (itemIDs != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			GetItemsRequest getItemsRequest;
			for (;;)
			{
				getItemsRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj2 = (IntPtr)0;
			getItemsRequest.Ids = itemIDs;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			PlayFabEconomyAPI.GetItems(obj, onGetItems, onGetItemsError, obj3, obj3);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00040574 File Offset: 0x0003E774
		public void GetItem(string itemID, Action<GetItemResponse> onGetItem, Action<PlayFabError> onGetItemError)
		{
			Console.WriteLine("Unmanaged memory load: [523C480]");
			object obj = (IntPtr)0;
			if (itemID != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			GetItemRequest getItemRequest;
			for (;;)
			{
				getItemRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj2 = (IntPtr)0;
			getItemRequest.Id = itemID;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			PlayFabEconomyAPI.GetItem(obj, onGetItem, onGetItemError, obj3, obj3);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000406CC File Offset: 0x0003E8CC
		public void DeleteItem(string itemID, Action<DeleteItemResponse> onDeleteItem, Action<PlayFabError> onDeleteItemError)
		{
			Console.WriteLine("Unmanaged memory load: [523C488]");
			object obj = (IntPtr)0;
			if (itemID != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			DeleteItemRequest deleteItemRequest;
			for (;;)
			{
				deleteItemRequest = obj;
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj2 = (IntPtr)0;
			deleteItemRequest.Id = itemID;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj3;
			PlayFabEconomyAPI.DeleteItem(obj, onDeleteItem, onDeleteItemError, obj3, obj3);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00040824 File Offset: 0x0003EA24
		public void ReportItem(string itemID, string reason, ConcernCategory concernCategory, Action<ReportItemResponse> onReportItem, Action<PlayFabError> onReportItemError)
		{
			object obj2;
			object obj = obj2 - 96L;
			Console.WriteLine("Unmanaged memory load: [523C490]");
			object obj3 = (IntPtr)0;
			if (this != 0)
			{
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
				Console.WriteLine("Method not found @24D6540");
			}
			ReportItemRequest reportItemRequest;
			object obj4;
			PlayFab.EconomyModels.EntityKey entityKey;
			for (;;)
			{
				reportItemRequest = obj3;
				Console.WriteLine("Method not found @24D67D8");
				obj3..ctor();
				if (obj3 != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C498]");
					obj4 = (IntPtr)0;
					reportItemRequest.Id = itemID;
					Console.WriteLine("Method not found @24D64EC");
					entityKey = obj4;
					Console.WriteLine("Method not found @24D67D8");
					obj4..ctor();
					if (obj4 != 0)
					{
						break;
					}
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C3E0]");
			object obj5 = (IntPtr)0;
			entityKey.Id = this._entityID;
			Console.WriteLine("Method not found @24D64EC");
			entityKey.Type = this._entityType;
			Console.WriteLine("Method not found @24D64EC");
			reportItemRequest.Entity = obj4;
			Console.WriteLine("Method not found @24D64EC");
			Int32Enum? int32Enum = obj + 8L;
			int32Enum = new Int32Enum?(obj4);
			reportItemRequest.Reason = reason;
			Console.WriteLine("Unmanaged memory load: [v0 @ X31_v1 (System.Object)+8]");
			IntPtr intPtr = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Unmanaged memory load: [v147 @ X0_v19+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			PlayFabEconomyAPI.ReportItem(obj3, onReportItem, onReportItemError, obj, obj);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00040AA0 File Offset: 0x0003ECA0
		public void ClientGetTitleData(Action<GetTitleDataResult> onGetTitleDataResult = null, Action<PlayFabError> onGetTitleDataError = null)
		{
			Console.WriteLine("Unmanaged memory load: [523C4A8]");
			object obj = (IntPtr)0;
			if (this != 0)
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
				Console.WriteLine("Method not found @24D67D8");
				obj..ctor();
				if (obj != 0)
				{
					break;
				}
				Console.WriteLine("Method not found @24D67E8");
			}
			Console.WriteLine("Unmanaged memory load: [523C4B8]");
			object obj2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C4B0]");
			object obj3 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C4C0]");
			object method = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B3B0]");
			object obj4 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523C4C8]");
			object method2 = (IntPtr)0;
			Console.WriteLine("Unmanaged memory load: [523B3D0]");
			object obj5 = (IntPtr)0;
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D64EC");
			Console.WriteLine("Method not found @24D67D8");
			obj2..ctor();
			Console.WriteLine("Method not found @24D67D8");
			obj2..ctor();
			Console.WriteLine("Method not found @24D67D8");
			obj3..ctor(obj, method);
			Console.WriteLine("Method not found @24D67D8");
			obj4..ctor(obj, method2);
			Console.WriteLine("Unmanaged memory load: [v152 @ X0_v25+E4]");
			bool flag = (IntPtr)0 == 0;
			if (flag)
			{
				Console.WriteLine("Method not found @24D66BC");
			}
			object obj6;
			PlayFabClientAPI.GetTitleData(obj2, obj3, obj4, obj6, obj6);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000409C File Offset: 0x0000229C
		private void Update()
		{
		}

		// Token: 0x040003CB RID: 971
		private static BackEndManager _instance;

		// Token: 0x040003CC RID: 972
		private bool _serviceActive = 1L != 0L;

		// Token: 0x040003CD RID: 973
		private bool _logedIn;

		// Token: 0x040003CE RID: 974
		private bool _dataReturned;

		// Token: 0x040003CF RID: 975
		private bool _updating;

		// Token: 0x040003D0 RID: 976
		private PlayFabAuthenticationContext _authcontext;

		// Token: 0x040003D1 RID: 977
		private bool _playerAccountNewlyCreated;

		// Token: 0x040003D2 RID: 978
		private string _playerPlayFabID;

		// Token: 0x040003D3 RID: 979
		private string _playerTitleDisplayName;

		// Token: 0x040003D4 RID: 980
		private string _playerMasterID;

		// Token: 0x040003D5 RID: 981
		private string _entityID;

		// Token: 0x040003D6 RID: 982
		private string _entityType;

		// Token: 0x020000B3 RID: 179
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06000405 RID: 1029 RVA: 0x0004807C File Offset: 0x0004627C
			internal void <Login>b__0(LoginResult res)
			{
				Console.WriteLine("Unmanaged memory load: [523C4D0]");
				object obj = (IntPtr)0;
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				object obj3;
				object obj4;
				for (;;)
				{
					object obj2 = obj;
					Console.WriteLine("Method not found @24D67D8");
					obj..ctor();
					if (obj != 0)
					{
						Console.WriteLine("Method not found @24D64EC");
						Console.WriteLine("Method not found @24D64EC");
						BackEndManager backEndManager = this.<>4__this;
						if (this.<>4__this != 0)
						{
							backEndManager._logedIn = (1L != 0L);
							if (obj2 != 0)
							{
								BackEndManager backEndManager2 = backEndManager;
								Console.WriteLine("Unmanaged memory load: [v64 @ X8_v2+50]");
								backEndManager2._playerPlayFabID = (IntPtr)0;
								Console.WriteLine("Method not found @24D64EC");
								if (obj2 != 0)
								{
									Console.WriteLine("Unmanaged memory load: [523C4D8]");
									obj3 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [523C4E0]");
									object method = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [523B3B0]");
									obj4 = (IntPtr)0;
									Console.WriteLine("Unmanaged memory load: [523C4E8]");
									object method2 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									obj3..ctor(obj, method);
									Console.WriteLine("Method not found @24D67D8");
									obj4..ctor(obj, method2);
									if (this.<>4__this != 0)
									{
										break;
									}
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				BackEndManager backEndManager3 = obj4;
				Console.WriteLine("Unmanaged memory load: [v65 @ X8_v3+50]");
				backEndManager3.GetUserData((IntPtr)0, obj3, obj4);
			}

			// Token: 0x040004D0 RID: 1232
			public BackEndManager <>4__this;

			// Token: 0x040004D1 RID: 1233
			public Action<LoginResult> onLoginSuccess;
		}

		// Token: 0x020000B4 RID: 180
		private sealed class <>c__DisplayClass49_1
		{
			// Token: 0x06000407 RID: 1031 RVA: 0x00048304 File Offset: 0x00046504
			internal void <Login>b__1(GetUserDataResult resData)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				BackEndManager.<>c__DisplayClass49_0 cs$<>8__locals;
				Action<object> onGetTitleDataResult;
				Action<object> onGetTitleDataError;
				for (;;)
				{
					Console.WriteLine("Unmanaged memory load: [5592132]");
					bool flag = (IntPtr)0 == 0;
					if (flag)
					{
						Console.WriteLine("Method not found @24D6540");
					}
					Console.WriteLine("Unmanaged memory load: [523B408]");
					object obj = (IntPtr)0;
					Console.WriteLine("Unmanaged memory load: [v42 @ X8_v3+B8]");
					object obj2 = (IntPtr)0;
					if (obj2 != 0 && resData != 0)
					{
						Console.WriteLine("Unmanaged memory load: [v46 @ X8_v5+50]");
						if ((IntPtr)0 != 0)
						{
							Dictionary<string, UserDataRecord> data = resData.Data;
							Console.WriteLine("Method not found @24D64EC");
							cs$<>8__locals = this.CS$<>8__locals1;
							if (this.CS$<>8__locals1 != 0)
							{
								object obj3 = this + 32L;
								bool flag2 = obj3 == 0;
								object obj4 = !flag2;
								onGetTitleDataResult = obj3;
								if (obj4 == null)
								{
									Console.WriteLine("Unmanaged memory load: [523C4B0]");
									object obj5 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									Console.WriteLine("Unmanaged memory load: [523C4F0]");
									object method = (IntPtr)0;
									obj5..ctor(this, method);
									this.<>9__3 = obj5;
									Console.WriteLine("Method not found @24D64EC");
									onGetTitleDataResult = obj5;
								}
								object obj6 = this + 40L;
								bool flag3 = obj6 == 0;
								object obj7 = !flag3;
								onGetTitleDataError = obj6;
								if (obj7 == null)
								{
									Console.WriteLine("Unmanaged memory load: [523B3B0]");
									object obj8 = (IntPtr)0;
									Console.WriteLine("Method not found @24D67D8");
									Console.WriteLine("Unmanaged memory load: [523C4F8]");
									object method2 = (IntPtr)0;
									obj8..ctor(this, method2);
									this.<>9__4 = obj8;
									Console.WriteLine("Method not found @24D64EC");
									onGetTitleDataError = obj8;
								}
								if (cs$<>8__locals.<>4__this != 0)
								{
									break;
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				cs$<>8__locals.<>4__this.ClientGetTitleData(onGetTitleDataResult, onGetTitleDataError);
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00048638 File Offset: 0x00046838
			internal void <Login>b__3(GetTitleDataResult result)
			{
				/*
An exception occurred when decompiling this method (06000408)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager/<>c__DisplayClass49_1::<Login>b__3(PlayFab.ClientModels.GetTitleDataResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_6C:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x000486BC File Offset: 0x000468BC
			internal void <Login>b__4(PlayFabError error)
			{
				/*
An exception occurred when decompiling this method (06000409)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager/<>c__DisplayClass49_1::<Login>b__4(PlayFab.PlayFabError)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_6C:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00048740 File Offset: 0x00046940
			internal void <Login>b__2(PlayFabError resDataError)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				BackEndManager.<>c__DisplayClass49_0 cs$<>8__locals;
				Action<object> onGetTitleDataResult;
				Action<object> onGetTitleDataError;
				for (;;)
				{
					cs$<>8__locals = this.CS$<>8__locals1;
					if (this.CS$<>8__locals1 != 0)
					{
						object obj = this + 48L;
						bool flag = obj == 0;
						object obj2 = !flag;
						onGetTitleDataResult = obj;
						if (obj2 == null)
						{
							Console.WriteLine("Unmanaged memory load: [523C4B0]");
							object obj3 = (IntPtr)0;
							Console.WriteLine("Method not found @24D67D8");
							Console.WriteLine("Unmanaged memory load: [523C500]");
							object method = (IntPtr)0;
							obj3..ctor(this, method);
							this.<>9__5 = obj3;
							Console.WriteLine("Method not found @24D64EC");
							onGetTitleDataResult = obj3;
						}
						object obj4 = this + 56L;
						bool flag2 = obj4 == 0;
						object obj5 = !flag2;
						onGetTitleDataError = obj4;
						if (obj5 == null)
						{
							Console.WriteLine("Unmanaged memory load: [523B3B0]");
							object obj6 = (IntPtr)0;
							Console.WriteLine("Method not found @24D67D8");
							Console.WriteLine("Unmanaged memory load: [523C508]");
							object method2 = (IntPtr)0;
							obj6..ctor(this, method2);
							this.<>9__6 = obj6;
							Console.WriteLine("Method not found @24D64EC");
							onGetTitleDataError = obj6;
						}
						if (cs$<>8__locals.<>4__this != 0)
						{
							break;
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				cs$<>8__locals.<>4__this.ClientGetTitleData(onGetTitleDataResult, onGetTitleDataError);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00048978 File Offset: 0x00046B78
			internal void <Login>b__5(GetTitleDataResult result)
			{
				/*
An exception occurred when decompiling this method (0600040B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager/<>c__DisplayClass49_1::<Login>b__5(PlayFab.ClientModels.GetTitleDataResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_6C:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x000489FC File Offset: 0x00046BFC
			internal void <Login>b__6(PlayFabError error)
			{
				/*
An exception occurred when decompiling this method (0600040C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager/<>c__DisplayClass49_1::<Login>b__6(PlayFab.PlayFabError)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_6C:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x040004D2 RID: 1234
			public LoginResult res;

			// Token: 0x040004D3 RID: 1235
			public BackEndManager.<>c__DisplayClass49_0 CS$<>8__locals1;

			// Token: 0x040004D4 RID: 1236
			public Action<GetTitleDataResult> <>9__3;

			// Token: 0x040004D5 RID: 1237
			public Action<PlayFabError> <>9__4;

			// Token: 0x040004D6 RID: 1238
			public Action<GetTitleDataResult> <>9__5;

			// Token: 0x040004D7 RID: 1239
			public Action<PlayFabError> <>9__6;
		}

		// Token: 0x020000B5 RID: 181
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x0600040E RID: 1038 RVA: 0x00048A94 File Offset: 0x00046C94
			internal void <LoadFile>b__0(GetFilesResponse res)
			{
				/*
An exception occurred when decompiling this method (0600040E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager/<>c__DisplayClass58_0::<LoadFile>b__0(PlayFab.DataModels.GetFilesResponse)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_440:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); 	call:void(Console::WriteLine, ldstr:string("Method not found @214867C")); 	call:void(Console::WriteLine, ldstr:string("Method not found @25C617C")); 	call:void(Console::WriteLine, ldstr:string("Method not found @21483A0")); }; 
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1789
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 338
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00048FDC File Offset: 0x000471DC
			internal void <LoadFile>b__2(byte[] res)
			{
				Encoding utf = Encoding.UTF8;
				if (utf != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					Action<string> action = this.onGetFileData;
					if (this.onGetFileData != 0)
					{
						Console.WriteLine("Indirect call: 37 IndirectCall [v22 @ X8_v3 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
					}
				}
				else
				{
					Console.WriteLine("Method not found @24D67E8");
				}
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0004906C File Offset: 0x0004726C
			internal void <LoadFile>b__3(string resErr)
			{
				Action<string> action = this.onGetFileDataError;
				if (this.onGetFileDataError != 0)
				{
					Console.WriteLine("Indirect call: 10 IndirectCall [v0 @ X8_v1 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x000490B4 File Offset: 0x000472B4
			internal void <LoadFile>b__1(PlayFabError resErr)
			{
				Action<string> action = this.onGetFileDataError;
				if (this.onGetFileDataError != 0)
				{
					if (resErr != 0)
					{
						string text = resErr.GenerateErrorReport();
						Console.WriteLine("Indirect call: 23 IndirectCall [v3 @ X19_v1 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
					}
					else
					{
						Console.WriteLine("Method not found @24D67E8");
					}
				}
			}

			// Token: 0x040004D8 RID: 1240
			public string fileName;

			// Token: 0x040004D9 RID: 1241
			public Action<string> onGetFileData;

			// Token: 0x040004DA RID: 1242
			public Action<string> onGetFileDataError;

			// Token: 0x040004DB RID: 1243
			public Action<byte[]> <>9__2;

			// Token: 0x040004DC RID: 1244
			public Action<string> <>9__3;
		}

		// Token: 0x020000B6 RID: 182
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x06000413 RID: 1043 RVA: 0x0004914C File Offset: 0x0004734C
			internal void <UploadFile>b__0(InitiateFileUploadsResponse res)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				Encoding utf;
				for (;;)
				{
					utf = Encoding.UTF8;
					if (utf != 0)
					{
						Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
						if (res != 0 && res.UploadDetails != 0)
						{
							object obj = res.UploadDetails.get_Item(this.fileData);
							if (obj != 0)
							{
								break;
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				object obj2 = this + 88L;
				bool flag = obj2 == 0;
				object obj3 = !flag;
				Action<object> successCallback = obj2;
				if (obj3 == null)
				{
					Console.WriteLine("Unmanaged memory load: [523C510]");
					object obj4 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523C570]");
					object method = (IntPtr)0;
					obj4..ctor(this, method);
					this.<>9__2 = obj4;
					Console.WriteLine("Method not found @24D64EC");
					successCallback = obj4;
				}
				object obj5 = this + 96L;
				Console.WriteLine("Unmanaged memory load: [523C548]");
				object obj6 = (IntPtr)0;
				bool flag2 = obj5 == 0;
				object obj7 = !flag2;
				Action<object> errorCallback = obj5;
				if (obj7 == null)
				{
					Console.WriteLine("Unmanaged memory load: [523C518]");
					object obj8 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523C578]");
					object method2 = (IntPtr)0;
					obj8..ctor(this, method2);
					this.<>9__3 = obj8;
					Console.WriteLine("Method not found @24D64EC");
					errorCallback = obj8;
				}
				Console.WriteLine("Unmanaged memory load: [v171 @ X0_v25+E4]");
				bool flag3 = (IntPtr)0 == 0;
				if (flag3)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				Console.WriteLine("Unmanaged memory load: [v59 @ X0_v18 (System.Object)+18]");
				PlayFabHttp.SimplePutCall((IntPtr)0, utf, successCallback, errorCallback);
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00049460 File Offset: 0x00047660
			internal void <UploadFile>b__2(byte[] res)
			{
				bool flag = this == 0;
				Console.WriteLine("Unmanaged memory load: [523C580]");
				object obj = (IntPtr)0;
				if (!flag)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				FinalizeFileUploadsRequest finalizeFileUploadsRequest;
				for (;;)
				{
					finalizeFileUploadsRequest = obj;
					Console.WriteLine("Method not found @24D67D8");
					obj..ctor();
					if (obj != 0)
					{
						break;
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				finalizeFileUploadsRequest.Entity = this.entity;
				Console.WriteLine("Method not found @24D64EC");
				finalizeFileUploadsRequest.FileNames = this.fileNameList;
				Console.WriteLine("Method not found @24D64EC");
				object obj2 = this + 72L;
				bool flag2 = obj2 == 0;
				object obj3 = !flag2;
				Action<object> resultCallback = obj2;
				if (obj3 == null)
				{
					Console.WriteLine("Unmanaged memory load: [523C588]");
					object obj4 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523C590]");
					object method = (IntPtr)0;
					obj4..ctor(this, method);
					this.<>9__4 = obj4;
					Console.WriteLine("Method not found @24D64EC");
					resultCallback = obj4;
				}
				object obj5 = this + 80L;
				Console.WriteLine("Unmanaged memory load: [523C428]");
				object obj6 = (IntPtr)0;
				bool flag3 = obj5 == 0;
				object obj7 = !flag3;
				Action<object> errorCallback = obj5;
				if (obj7 == null)
				{
					Console.WriteLine("Unmanaged memory load: [523B3B0]");
					object obj8 = (IntPtr)0;
					Console.WriteLine("Method not found @24D67D8");
					Console.WriteLine("Unmanaged memory load: [523C598]");
					object method2 = (IntPtr)0;
					obj8..ctor(this, method2);
					this.<>9__5 = obj8;
					Console.WriteLine("Method not found @24D64EC");
					errorCallback = obj8;
				}
				Console.WriteLine("Unmanaged memory load: [v144 @ X0_v24+E4]");
				bool flag4 = (IntPtr)0 == 0;
				if (flag4)
				{
					Console.WriteLine("Method not found @24D66BC");
				}
				object obj9;
				PlayFabDataAPI.FinalizeFileUploads(obj, resultCallback, errorCallback, obj9, obj9);
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00049744 File Offset: 0x00047944
			internal void <UploadFile>b__4(FinalizeFileUploadsResponse res)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
				}
				Action<string> action = this.onUploadFileData;
				if (this.onUploadFileData != 0)
				{
					Console.WriteLine("Unmanaged memory load: [523C5A0]");
					object str = (IntPtr)0;
					string text = this.fileName + str;
					Console.WriteLine("Indirect call: 42 IndirectCall [v20 @ X20_v2 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x000497FC File Offset: 0x000479FC
			internal void <UploadFile>b__5(PlayFabError resErr)
			{
				Action<string> action = this.onUploadFileDataError;
				if (this.onUploadFileDataError != 0)
				{
					if (resErr != 0)
					{
						string text = resErr.GenerateErrorReport();
						Console.WriteLine("Indirect call: 23 IndirectCall [v3 @ X19_v1 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
					}
					else
					{
						Console.WriteLine("Method not found @24D67E8");
					}
				}
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00049880 File Offset: 0x00047A80
			internal void <UploadFile>b__3(string resErr)
			{
				Action<string> action = this.onUploadFileDataError;
				if (this.onUploadFileDataError != 0)
				{
					Console.WriteLine("Indirect call: 10 IndirectCall [v0 @ X8_v1 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x000498C8 File Offset: 0x00047AC8
			internal void <UploadFile>b__1(PlayFabError resErr)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				while (resErr == 0)
				{
					Console.WriteLine("Method not found @24D67E8");
				}
				Action<string> action = this.onUploadFileDataError;
				if (this.onUploadFileDataError != 0)
				{
					string text = resErr.GenerateErrorReport();
					Console.WriteLine("Indirect call: 179 IndirectCall [v36 @ X19_v3 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x000499E8 File Offset: 0x00047BE8
			internal void <UploadFile>b__6(AbortFileUploadsResponse res)
			{
				/*
An exception occurred when decompiling this method (06000419)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void BackEnd.BackEndManager/<>c__DisplayClass59_0::<UploadFile>b__6(PlayFab.DataModels.AbortFileUploadsResponse)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{; 	IL_43:; 	call:void(Console::WriteLine, ldstr:string("Method not found @24D67E8")); }; 
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

			// Token: 0x0600041A RID: 1050 RVA: 0x00049A48 File Offset: 0x00047C48
			internal void <UploadFile>b__7(PlayFabError resErr)
			{
				Action<string> action = this.onUploadFileDataError;
				if (this.onUploadFileDataError != 0)
				{
					if (resErr != 0)
					{
						string text = resErr.GenerateErrorReport();
						Console.WriteLine("Indirect call: 23 IndirectCall [v3 @ X19_v1 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
					}
					else
					{
						Console.WriteLine("Method not found @24D67E8");
					}
				}
			}

			// Token: 0x040004DD RID: 1245
			public string fileData;

			// Token: 0x040004DE RID: 1246
			public PlayFab.DataModels.EntityKey entity;

			// Token: 0x040004DF RID: 1247
			public List<string> fileNameList;

			// Token: 0x040004E0 RID: 1248
			public Action<string> onUploadFileData;

			// Token: 0x040004E1 RID: 1249
			public string fileName;

			// Token: 0x040004E2 RID: 1250
			public Action<string> onUploadFileDataError;

			// Token: 0x040004E3 RID: 1251
			public BackEndManager <>4__this;

			// Token: 0x040004E4 RID: 1252
			public Action<FinalizeFileUploadsResponse> <>9__4;

			// Token: 0x040004E5 RID: 1253
			public Action<PlayFabError> <>9__5;

			// Token: 0x040004E6 RID: 1254
			public Action<byte[]> <>9__2;

			// Token: 0x040004E7 RID: 1255
			public Action<string> <>9__3;

			// Token: 0x040004E8 RID: 1256
			public Action<AbortFileUploadsResponse> <>9__6;

			// Token: 0x040004E9 RID: 1257
			public Action<PlayFabError> <>9__7;
		}

		// Token: 0x020000B7 RID: 183
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600041C RID: 1052 RVA: 0x00049AE0 File Offset: 0x00047CE0
			internal void <ClientGetTitleData>b__0(GetTitleDataResult result)
			{
				if (this != 0)
				{
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
					Console.WriteLine("Method not found @24D6540");
				}
				BackEndManager backEndManager2;
				for (;;)
				{
					if (result != 0)
					{
						if (result.Data == 0)
						{
							return;
						}
						BackEndManager backEndManager = this.<>4__this;
						if (this.<>4__this != 0)
						{
							Console.WriteLine("Unmanaged memory load: [523C5C8]");
							object key = (IntPtr)0;
							Console.WriteLine("Unmanaged memory load: [523BC38]");
							object obj = (IntPtr)0;
							backEndManager._dataReturned = (1L != 0L);
							bool flag = obj == 0;
							bool flag2 = result.Data.ContainsKey(key);
							if (!flag)
							{
								goto IL_248;
							}
							if (result.Data != 0)
							{
								object s = result.Data.get_Item(key);
								object obj2;
								ref int result2 = obj2 + 12L;
								bool flag3 = obj2 == 0;
								bool flag4 = int.TryParse(s, out result2);
								if (!flag3)
								{
									goto IL_248;
								}
								backEndManager2 = this.<>4__this;
								if (this.<>4__this != 0)
								{
									break;
								}
							}
						}
					}
					Console.WriteLine("Method not found @24D67E8");
				}
				Console.WriteLine("Not implemented instruction: Instruction CSET not yet implemented.");
				BackEndManager backEndManager3 = backEndManager2;
				Console.WriteLine("Unmanaged memory load: [v0 @ X31+C]");
				backEndManager3._serviceActive = ((IntPtr)0 != 0);
				IL_248:
				if (this.onGetTitleDataResult != 0)
				{
					Console.WriteLine("Not implemented instruction: Instruction BLR not yet implemented.");
					return;
				}
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00049D54 File Offset: 0x00047F54
			internal void <ClientGetTitleData>b__1(PlayFabError error)
			{
				Action<PlayFabError> action = this.onGetTitleDataError;
				if (this.onGetTitleDataError != 0)
				{
					Console.WriteLine("Indirect call: 10 IndirectCall [v0 @ X8_v1 (System.Action`1<PlayFab.PlayFabError>)+18] (should have been resolved before IL gen)");
				}
			}

			// Token: 0x040004EA RID: 1258
			public BackEndManager <>4__this;

			// Token: 0x040004EB RID: 1259
			public Action<GetTitleDataResult> onGetTitleDataResult;

			// Token: 0x040004EC RID: 1260
			public Action<PlayFabError> onGetTitleDataError;
		}
	}
}
