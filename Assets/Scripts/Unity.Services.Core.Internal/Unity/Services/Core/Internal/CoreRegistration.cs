namespace Unity.Services.Core.Internal
{
	public readonly struct CoreRegistration
	{
		private readonly IPackageRegistry m_Registry;

		private readonly int m_PackageHash;

		internal CoreRegistration(IPackageRegistry registry, int packageHash)
		{
			m_Registry = null;
			m_PackageHash = 0;
		}

		public CoreRegistration DependsOn<T>()
		{
			return default(CoreRegistration);
		}

		public CoreRegistration OptionallyDependsOn<T>()
		{
			return default(CoreRegistration);
		}

		public CoreRegistration ProvidesComponent<T>()
		{
			return default(CoreRegistration);
		}
	}
}
