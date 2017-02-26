using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace XCartTesting.Common
{
    public static class Constants
    {

        public static string driversPath = ConfigurationManager.AppSettings["driversPath"];
        public static string urlAdmin = ConfigurationManager.AppSettings["urlAdmin"];
        public static string browser = ConfigurationManager.AppSettings["browser"];
    }
}
