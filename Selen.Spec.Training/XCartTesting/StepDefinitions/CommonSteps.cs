using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Core.Selen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XCartTesting.Pages;
using XCartTesting.Common;

namespace XCartTesting.StepDefinitions
{
    [Binding]
    public sealed class CommonSteps : PageMapping
    {
        #region Given
        #endregion

        #region When
        [When("I go to the (.*) url")]
        [Given("I have gone to the (.*) url")]
        public void GoToUrl(string url)
        {
            Browser.DriversPath = Constants.driversPath;
            Browser.Name = Constants.browser;
            Browser.Current.Navigate().GoToUrl(url);
        }

        [When("I click (.*button|.*link) on (.*) page")]
        public void Click(string control, string page)
        {
           
        }

        [When("I login with username (.*) and password (.*)")]
        public void Login(string username, string password)
        {
            PageLogin.Login(username, password);
        }
        #endregion

        #region Then
        [Then("The (.*) page should be displayed")]
        public void VerifyTitlePage(string title)
        {
            Assert.AreEqual<string>(title, Browser.Current.Title, "The title page is incorrect.");
        }
        #endregion

    }
}
