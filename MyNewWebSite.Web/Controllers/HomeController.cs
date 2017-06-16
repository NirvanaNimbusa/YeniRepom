using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyNewWebSite.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyNewWebSiteControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}