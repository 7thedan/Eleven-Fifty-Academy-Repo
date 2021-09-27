using System.Web;
using System.Web.Mvc;

namespace NBAFantasy._2021_21.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
