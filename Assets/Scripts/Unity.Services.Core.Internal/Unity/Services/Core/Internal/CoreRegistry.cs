using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	public sealed class CoreRegistry
	{
		public static CoreRegistry Instance { get; internal set; }

		public string InstanceId { get; }

		internal ServicesType Type { get; private set; }

		internal InitializationOptions Options { get; set; }

		[NotNull]
		internal IPackageRegistry PackageRegistry { get; private set; }

		[NotNull]
		internal IComponentRegistry ComponentRegistry { get; private set; }

		[NotNull]
		internal IServiceRegistry ServiceRegistry { get; private set; }

		internal CoreRegistry()
		{
		}

		internal CoreRegistry(IPackageRegistry packageRegistry, ServicesType type = ServicesType.Default, string instanceId = null)
		{
		}

		public CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package)
		{
			return default(CoreRegistration);
		}

		public void RegisterServiceComponent<TComponent>([NotNull] TComponent component)
		{
		}

		public TComponent GetServiceComponent<TComponent>()
		{
			return default(TComponent);
		}

		public bool TryGetServiceComponent<TComponent>(out TComponent component)
		{
			component = default(TComponent);
			return false;
		}

		public void RegisterService<T>([NotNull] T service)
		{
		}

		public T GetService<T>()
		{
			return default(T);
		}

		internal void LockComponentRegistration()
		{
		}

		internal void LockServiceRegistration()
		{
		}
	}
}
