using System.Web;
using System.Web.Mvc;

namespace Dev11_Net45_Mvc4_WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}