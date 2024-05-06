using System.Web;
using System.Web.Mvc;

namespace Single_sign_on_with_azureAsp.netMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
