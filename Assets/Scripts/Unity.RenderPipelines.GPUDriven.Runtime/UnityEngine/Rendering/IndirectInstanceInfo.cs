namespace UnityEngine.Rendering
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "./Library/PackageCache/com.unity.render-pipelines.core@33b0f6d355dd/Runtime/GPUDriven/InstanceOcclusionCuller.cs", needAccessors = false)]
	internal struct IndirectInstanceInfo
	{
		public int drawOffsetAndSplitMask;

		public int instanceIndexAndCrossFade;
	}
}
