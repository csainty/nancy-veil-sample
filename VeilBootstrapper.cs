using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Veil;
using Veil.SuperSimple;

namespace NancyVeil
{
    public class VeilBootstrapper : DefaultNancyBootstrapper
	{
		static VeilBootstrapper() {
			VeilStaticConfiguration.RegisterParser(new SuperSimpleParserRegistration());
		}

		protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines) {
			base.ApplicationStartup(container, pipelines);

			this.RegisterRequestContainerModules(container, new [] {
				new ModuleRegistration(typeof(HomeModule))
			});
		}
	}
}
