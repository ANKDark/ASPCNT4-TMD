using System.Web;
using System.Web.Mvc;

namespace TmdK22CNT4Lesson10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
