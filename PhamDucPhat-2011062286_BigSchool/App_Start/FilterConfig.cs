using System.Web;
using System.Web.Mvc;

namespace PhamDucPhat_2011062286_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
