using System.Web;
using System.Web.Mvc;

namespace NICConf_GreenButton
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
