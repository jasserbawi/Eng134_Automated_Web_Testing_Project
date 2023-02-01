using System.Configuration; 
namespace SL_TestAutomationFramework
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string WomensPage = ConfigurationManager.AppSettings["womens_page"];
        public static readonly string WomensTops = ConfigurationManager.AppSettings["womens_tops"];
        public static readonly string WomensBottoms = ConfigurationManager.AppSettings["womens_bottoms"];

        public static readonly string MensPage = ConfigurationManager.AppSettings["mens_page"];
        public static readonly string MensTops = ConfigurationManager.AppSettings["mens_tops"];
        public static readonly string MensBottoms = ConfigurationManager.AppSettings["mens_bottoms"];

        public static readonly string Checkout = ConfigurationManager.AppSettings["checkout"];
        public static readonly string Basket = ConfigurationManager.AppSettings["basket"];
    }
}

