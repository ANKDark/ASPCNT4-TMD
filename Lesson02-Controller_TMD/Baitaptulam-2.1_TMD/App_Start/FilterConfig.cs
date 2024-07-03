using System.Web;
using System.Web.Mvc;

namespace Baitaptulam_2._1_TMD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
