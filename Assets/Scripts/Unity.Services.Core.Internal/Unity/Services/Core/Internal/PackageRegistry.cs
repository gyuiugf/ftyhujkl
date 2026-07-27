using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class PackageRegistry : IPackageRegistry
	{
		public DependencyTree Tree { get; set; }

		public PackageRegistry([CanBeNull] DependencyTree tree)
		{
		}

		public CoreRegistration RegisterPackage<TPackage>(TPackage package)
		{
			return default(CoreRegistration);
		}

		public void RegisterDependency<TComponent>(int packageTypeHash)
		{
		}

		public void RegisterOptionalDependency<TComponent>(int packageTypeHash)
		{
		}

		public void RegisterProvision<TComponent>(int packageTypeHash)
		{
		}

		private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash)
		{
		}
	}
}
