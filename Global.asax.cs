using System.Web.Http;
using WebAPISandbox.App_Start;

namespace WebAPISandbox
{
	public class Global : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}