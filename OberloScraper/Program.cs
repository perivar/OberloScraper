using System;
using System.Configuration;

namespace OberloScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string userDataDir = ConfigurationManager.AppSettings["UserDataDir"];
            string oberloUsername = ConfigurationManager.AppSettings["OberloUsername"];
            string oberloPassword = ConfigurationManager.AppSettings["OberloPassword"];

            var oberloOrders = Oberlo.GetLatestOberloOrders(userDataDir, oberloUsername, oberloPassword);
        }
    }
}
