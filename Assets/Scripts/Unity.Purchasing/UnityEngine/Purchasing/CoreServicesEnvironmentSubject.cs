using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	internal class CoreServicesEnvironmentSubject
	{
		private static CoreServicesEnvironmentSubject s_Instance;

		private const string k_DefaultLiveEnvironment = "production";

		private string m_LastKnownEnvironment;

		private readonly List<ICoreServicesEnvironmentObserver> m_Observers;

		internal static CoreServicesEnvironmentSubject Instance()
		{
			return null;
		}

		public void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver)
		{
		}

		internal void UpdateCurrentEnvironment(string currentEnvironment)
		{
		}

		private void NotifyObservers()
		{
		}

		internal bool IsDefaultLiveEnvironment(string environment)
		{
			return false;
		}
	}
}
