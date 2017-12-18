using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
