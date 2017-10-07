using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace Core.Selen
{
    public class Driver
    {
        private static IWebDriver webDriver;
        public static string Name { get; set; }
        public static string DriversPath { get; set; }
        public static bool Grid { get; set; }
        public static string HubUrl { get; set; }
        private static readonly Lazy<IWebDriver> lazy = new Lazy<IWebDriver>(() => StartDriver());
        public static IWebDriver Current
        {
            get
            {
                return lazy.Value;  
            }
            set { webDriver = value; }
        }
        private static IWebDriver StartDriver()
        {
            string driversPath = Path.Combine(Directory.GetCurrentDirectory(), "Drivers");
            if (!Grid)
            {
                switch (Name)
                {
                    case "IE":
                        webDriver = new InternetExplorerDriver(driversPath);
                        break;
                    case "Edge":
                        webDriver = new EdgeDriver(driversPath);
                        break;
                    case "Chrome":
                        //handle unable to maximized chrome on some envs
                        //ChromeOptions chromeOptions = new ChromeOptions();
                        //chromeOptions.AddArguments("start-maximized");
                        //currentDriver = new ChromeDriver(driversPath,chromeOptions);
                        webDriver = new ChromeDriver(driversPath);
                        break;
                    case "Firefox":
                        System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", driversPath);
                        //handle crash dialog
                        //System.Environment.SetEnvironmentVariable("XRE_NO_WINDOWS_CRASH_DIALOG", "1");
                        webDriver = new FirefoxDriver();
                        break;
                    default:
                        throw new Exception($"{Driver.Name} is invalid. {nameof(Driver.Name)} only accepts IE, Edge, Chrome or Firefox.");
                }
            }
            else
            {
                DesiredCapabilities capability = new DesiredCapabilities();
                switch (Name)
                {
                    case "Edge":
                        capability = DesiredCapabilities.Edge();
                        capability.SetCapability(CapabilityType.BrowserName, "MicrosoftEdge");
                        capability.SetCapability(CapabilityType.Version, "38");
                        capability.SetCapability("platform", "WIN10");
                        //capability.SetCapability("initialBrowserUrl", "");
                        break;
                    case "IE":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browserName", "MicrosoftEdge");
                        capability.SetCapability("platform", "Win10");
                        //capability.SetCapability("initialBrowserUrl", "");
                        break;
                    case "Safari":
                        capability = DesiredCapabilities.Safari();
                        capability.SetCapability("browserName", "safari");
                        capability.SetCapability(CapabilityType.Version, "10");
                        capability.SetCapability("platform", "MAC");
                        //capability.SetCapability("initialBrowserUrl", "");
                        break;
                    case "Chrome":
                        capability = DesiredCapabilities.Chrome();
                        capability.SetCapability("browserName", "chrome");
                        //capability.SetCapability(CapabilityType.Version, "57");
                        capability.SetCapability("platform", "WIN10");
                        //capability.SetCapability("api_key", "api_key");
                        //capability.SetCapability("api_secret", "api_secret");

                        break;
                    case "Firefox":
                        capability = DesiredCapabilities.Firefox();
                        System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", driversPath);
                        capability.SetCapability("browserName", "firefox");
                        capability.SetCapability("platform", "WIN10");
                        break;
                    default:
                        Console.WriteLine("Browser name is null.");
                        break;
                }

                webDriver = new RemoteWebDriver(new Uri(HubUrl), capability);
                webDriver.Manage().Window.Maximize();
            }
            return webDriver;
        }

        public static WebDriverWait Wait(int seconds)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));
            wait.Timeout = TimeSpan.FromSeconds(seconds);
            wait.PollingInterval = TimeSpan.FromSeconds(seconds / 5);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

            return wait;
        }

        public string CurrentWindowHandle
        {
            get { throw new NotImplementedException(); }
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new NotImplementedException();
        }

        public string PageSource
        {
            get { throw new NotImplementedException(); }
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }

        public string Title
        {
            get { throw new NotImplementedException(); }
        }

        public string Url
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<string> WindowHandles
        {
            get { throw new NotImplementedException(); }
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
