using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal interface IPackageRegistry
	{
		[CanBeNull]
		DependencyTree Tree { get; set; }

		CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package);

		void RegisterDependency<TComponent>(int packageTypeHash);

		void RegisterOptionalDependency<TComponent>(int packageTypeHash);

		void RegisterProvision<TComponent>(int packageTypeHash);
	}
}
