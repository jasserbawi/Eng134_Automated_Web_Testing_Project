using System.Configuration; 
namespace SL_TestAutomationFramework
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string WomensPage = ConfigurationManager.AppSettings["womens_page"];
    }
}

