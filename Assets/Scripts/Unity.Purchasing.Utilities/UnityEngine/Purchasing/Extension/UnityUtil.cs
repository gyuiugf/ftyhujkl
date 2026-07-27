using System;
using System.Collections;
using System.Collections.Generic;
using Purchasing.Utilities;
using Uniject;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Extension
{
	internal class UnityUtil : IUtil
	{
		private IThreadUtils m_ThreadUtils;

		private IMonoBehaviourUtil m_MonoBehaviourUtils;

		private static readonly List<RuntimePlatform> s_PcControlledPlatforms;

		private readonly List<Action<bool>> pauseListeners;

		internal const string ObsoleteUpgradeToIAPV5Message = "This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5";

		public DateTime currentTime => default(DateTime);

		public string persistentDataPath => null;

		public string deviceUniqueIdentifier => null;

		public string unityVersion => null;

		public string cloudProjectId => null;

		public string userId => null;

		public string gameVersion => null;

		public ulong sessionId => 0uL;

		public RuntimePlatform platform => default(RuntimePlatform);

		public bool isEditor => false;

		public string deviceModel => null;

		public string deviceName => null;

		public DeviceType deviceType => default(DeviceType);

		public string operatingSystem => null;

		public int screenWidth => 0;

		public int screenHeight => 0;

		public float screenDpi => 0f;

		public string screenOrientation => null;

		[Preserve]
		public UnityUtil(IThreadUtils threadUtils, IMonoBehaviourUtil monoBehaviorUtil)
		{
		}

		public T[] GetAnyComponentsOfType<T>() where T : class
		{
			return null;
		}

		object IUtil.InitiateCoroutine(IEnumerator start)
		{
			return null;
		}

		void IUtil.InitiateCoroutine(IEnumerator start, int delay)
		{
		}

		public void RunOnMainThread(Action runnable)
		{
		}

		public object GetWaitForSeconds(int seconds)
		{
			return null;
		}

		public static bool PcPlatform()
		{
			return false;
		}

		public void AddPauseListener(Action<bool> runnable)
		{
		}

		public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant)
		{
			return false;
		}
	}
}
