using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Core.Selen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XCartTesting.Admin.Pages;
using XCartTesting.Common;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Core.Selen.Controls;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace XCartTesting.Admin.StepDefinitions
{
    [Binding]
    public sealed class CommonSteps : PageManager
    {
        #region Given
        #endregion

        #region When
        [When("I go to the (.*) url")]
        [Given("I have gone to the (.*) url")]
        public void GoToUrl(string url)
        {
            Browser.Current.Navigate().GoToUrl(url);
        }

        [When("I click (.*button|.*link) on (.*) page")]
        public void Click(string control, string page)
        {

        }

        [When("I login with username (.*) and password (.*)")]
        public void Login(string username, string password)
        {
            AdminLoginPage.Login(username, password);

            //Close dialog if any
            AdminCommonPage.CloseDialog();
        }

        [When("I open (.*) menu item")]
        public void SelectMenuItem(string name)
        {
            Hyperlink menuItemLink = new Hyperlink(string.Format(AdminCommonPage.LeftMenuItemHyperlink.XPath, name));
            menuItemLink.Click();
        }

        [When("I select (.*) under (.*) menu item")]
        public void SelectLinkUnderMenuItem(string subItem, string menuItem)
        {
            Hyperlink link = new Hyperlink(string.Format(AdminCommonPage.LeftSubMenuItemHyperlink.XPath, menuItem, subItem));
            link.ClickAndWait(Constants.WaitMediumTime);
        }

        #endregion

        #region Then
        [Then("The (.*) page should be displayed")]
        public void VerifyTitlePage(string title)
        {
            Assert.AreEqual<string>(title, Browser.Current.Title, "The title page is incorrect.");
        }

        [Then("(.*) menu item should be displayed in the left menu")]
        public void VerifyMenuItemsInTheLeftMenu(string name)
        {
            Hyperlink menuItemLink = new Hyperlink(string.Format(AdminCommonPage.LeftMenuItemHyperlink.XPath, name));
            Assert.IsTrue(menuItemLink.Displayed, $"{name} menu item isn't displayed in the left menu.");
        }

        [Then("(.*) items are displayed under (.*) menu item")]
        public void VerifySubItemListUnderMenuItem(string subItems, string menuItem)
        {
            var subItemsList = Regex.Split(subItems, ", ").ToList();
            var items = subItemsList.Where(x => !(new Hyperlink(string.Format(AdminCommonPage.LeftSubMenuItemHyperlink.XPath, menuItem, x)).Displayed)).ToList();

            Assert.IsTrue(items.Count() == 0, $"These items {items} aren't displayed under {menuItem} menu item.");
        }

        [Then("The title page label should display (.*)")]
        public void VerifyPageDisplayed(string name)
        {
            string text = AdminCommonPage.PageTitleSpan.Text;
            Assert.AreEqual<string>(name, AdminCommonPage.PageTitleSpan.Text);
        }
        #endregion

    }
}
