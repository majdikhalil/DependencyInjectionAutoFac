using Autofac;
using IoCDemo.Core;
using IocDemo.iOS.Implementations;

namespace IocDemo.iOS
{
	public static class App
	{
		public static IContainer Container { get; set; }

		public static void Initialize()
		{
			var builder = new ContainerBuilder();

			builder.RegisterInstance(new ApplePlatform()).As<IPlatform>();
			builder.RegisterInstance(new AppleSettings()).As<ISettings>();
			builder.RegisterType<MainViewModel> ();

			App.Container = builder.Build ();
		}
	}
}