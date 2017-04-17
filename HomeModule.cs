using Nancy;

namespace NancyVeil
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get("/", x => {
				return this.View["home.vsshtml", new {
					Message = "from Veil"
				}];
			});
		}
	}
}
