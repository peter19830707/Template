using System.Web;
using System.Web.Mvc;
using Template.Practice.Filter;

namespace Template.Practice
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CommonExceptionFilter());
        }
    }
}
