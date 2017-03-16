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
        //public static int WaitShortTime { get { return int.Parse(ConfigurationManager.AppSettings["waitShortTime"]); } }
        //public static int WaitMediumTime { get { return int.Parse(ConfigurationManager.AppSettings["waitMediumTime"]); } }
        //public static int WaitLongTime { get { return int.Parse(ConfigurationManager.AppSettings["waitLongTime"]); } }
        //public static string DriversPath { get { return ConfigurationManager.AppSettings["driversPath"]; } }
        //public static string UrlAdmin { get { return ConfigurationManager.AppSettings["urlAdmin"]; } }
        //public static string Browser { get { return ConfigurationManager.AppSettings["browser"]; } }

        public static int WaitShortTime { get { return 10; } }
        public static int WaitMediumTime { get { return 20; } }
        public static int WaitLongTime { get { return 30; } }
        public static string DriversPath { get { return @".\..\..\..\drivers"; } }
        public static string UrlAdmin { get { return "http://qa.sitevisit.fve.ad.5ssl.com"; } }
        public static string Browser { get { return "Chrome"; } }
    }
}
