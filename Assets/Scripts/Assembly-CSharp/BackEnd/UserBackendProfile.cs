using System;
using System.Collections.Generic;
using PlayFab.ClientModels;

namespace BackEnd
{
	// Token: 0x0200007A RID: 122
	[Serializable]
	public class UserBackendProfile
	{
		// Token: 0x040003D7 RID: 983
		public bool newlyCreated;

		// Token: 0x040003D8 RID: 984
		public string displayName;

		// Token: 0x040003D9 RID: 985
		public string playFabId;

		// Token: 0x040003DA RID: 986
		public bool isBanned;

		// Token: 0x040003DB RID: 987
		public Dictionary<string, UserDataRecord> data;
	}
}
