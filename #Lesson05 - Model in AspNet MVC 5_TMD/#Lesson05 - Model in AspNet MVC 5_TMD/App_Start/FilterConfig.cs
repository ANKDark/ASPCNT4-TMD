using System.Web;
using System.Web.Mvc;

namespace _Lesson05___Model_in_AspNet_MVC_5_TMD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
