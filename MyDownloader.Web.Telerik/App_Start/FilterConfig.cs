using System.Web;
using System.Web.Mvc;

namespace MyDownloader.Web.Telerik
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
