using System.Collections.Generic;
using UnityEngine.XR;

namespace UnityEngine.Rendering.Universal
{
	internal static class PlatformAutoDetect
	{
		private static List<XRDisplaySubsystem> displaySubsystemList;

		internal static bool isRunningOnPowerVRGPU;

		internal static bool isXRMobile { get; private set; }

		internal static bool isShaderAPIMobileDefined { get; private set; }

		internal static bool isSwitch { get; private set; }

		internal static bool isSwitch2 { get; private set; }

		internal static void Initialize()
		{
		}

		private static bool IsRunningXRMobile()
		{
			return false;
		}

		internal static ShEvalMode ShAutoDetect(ShEvalMode mode)
		{
			return default(ShEvalMode);
		}
	}
}
