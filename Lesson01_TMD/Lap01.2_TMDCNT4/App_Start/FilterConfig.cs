using System.Web;
using System.Web.Mvc;

namespace Lap01._2_TMDCNT4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
