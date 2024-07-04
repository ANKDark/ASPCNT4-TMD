using System.Web;
using System.Web.Mvc;

namespace TmdLesson11Db_2210900014
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
