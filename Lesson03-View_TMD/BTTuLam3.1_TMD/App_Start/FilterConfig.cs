using System.Web;
using System.Web.Mvc;

namespace BTTuLam3._1_TMD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
