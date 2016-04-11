using System.Web;
using System.Web.Mvc;

namespace QualityWeek_CodingContest_AshutoshS2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
