using System.Web;
using System.Web.Mvc;

namespace MVC_Practical_Dapper
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
