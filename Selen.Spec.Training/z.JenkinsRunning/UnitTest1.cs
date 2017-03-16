using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace z.JenkinsRunning
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://www.google.com/");
                IWebElement searchTextbox = driver.FindElement(By.Name("q"));
                searchTextbox.SendKeys("ruby");
                searchTextbox.Submit();
                

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.Title.StartsWith("ruby", StringComparison.InvariantCultureIgnoreCase));

                Console.WriteLine("Page title is: " + driver.Title);
                
            }
        }
    }
}
