using System;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	internal class GooglePlayStoreExtendedService : StoreService, IGooglePlayStoreExtendedService, IStoreServiceExtension
	{
		private Action? m_InitializationConnectionListener;

		private readonly IGooglePlayStoreSetObfuscatedIdUseCase m_GooglePlayStoreSetObfuscatedIdUseCase;

		private readonly IGooglePlayStoreConnectionUseCase m_GooglePlayStoreConnectionUseCase;

		[Preserve]
		internal GooglePlayStoreExtendedService(IGooglePlayStoreSetObfuscatedIdUseCase googlePlayStoreSetObfuscatedIdUseCase, IGooglePlayStoreConnectionUseCase googlePlayStoreConnectionUseCase, IStoreConnectUseCase connectUseCase)
			: base(null)
		{
		}

		public void SetInitializeConnectionFailureListener(Action? listener)
		{
		}

		public void NotifyInitializationConnectionFailed()
		{
		}

		public void SetObfuscatedAccountId(string accountId)
		{
		}

		public void SetObfuscatedProfileId(string profileId)
		{
		}

		public void EndConnection()
		{
		}
	}
}
