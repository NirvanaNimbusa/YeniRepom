using Abp.Web.Mvc.Views;

namespace MyNewWebSite.Web.Views
{
    public abstract class MyNewWebSiteWebViewPageBase : MyNewWebSiteWebViewPageBase<dynamic>
    {

    }

    public abstract class MyNewWebSiteWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyNewWebSiteWebViewPageBase()
        {
            LocalizationSourceName = MyNewWebSiteConsts.LocalizationSourceName;
        }
    }
}