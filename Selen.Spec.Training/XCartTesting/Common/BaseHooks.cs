using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Core.Selen;
using XCartTesting.Common;
using System.Diagnostics;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System.Threading;

namespace XCartTesting.Hooks
{
    [Binding]
    public sealed class BaseHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser.DriversPath = Constants.DriversPath;
            Browser.Name =Constants.Browser;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Current.Close();
            Browser.Current.Quit();
            Browser.Current.Dispose();
            Browser.Current = null;

            //Process[] pro = Process.GetProcessesByName("WerFault");
            //foreach (var p in pro) p.Kill();
            //Browser.Current.Dispose();
        }

        [BeforeScenario("saucelabs")]
        public void BeforeScenarioSauceLabs()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, Environment.GetEnvironmentVariable("browserName"));
            capabilities.SetCapability(CapabilityType.Version, Environment.GetEnvironmentVariable("version"));
            capabilities.SetCapability(CapabilityType.Platform, Environment.GetEnvironmentVariable("platformOs"));
            capabilities.SetCapability("username", Environment.GetEnvironmentVariable("SAUCE_USERNAME"));
            capabilities.SetCapability("accessKey", Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY"));
            capabilities.SetCapability("name", ScenarioContext.Current.ScenarioInfo.Title);

            RemoteWebDriver webDriver = new RemoteWebDriver(new Uri("https://ondemand.saucelabs.com:443/wd/hub"), capabilities, TimeSpan.FromSeconds(600));
            //webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            ScenarioContext.Current["driver"] = webDriver;
        }

        [AfterScenario("saucelabs")]
        public void AfterScenarioSauceLabs()
        {
            IWebDriver driver = (IWebDriver)ScenarioContext.Current["driver"];
            bool passed = ScenarioContext.Current.TestError == null;
            ((IJavaScriptExecutor)driver).ExecuteScript("sauce:job-result=" + (passed ? "passed" : "failed"));
            driver.Quit();
        }
    }
}
