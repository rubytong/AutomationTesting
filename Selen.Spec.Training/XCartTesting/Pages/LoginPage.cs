using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Selen;
using OpenQA.Selenium;
using System.Xml;

namespace XCartTesting.Pages
{
    public partial class LoginPage
    {
        public void Login(string username, string password)
        {
            EmailTextbox.SendKeys(username);
            PasswordTextbox.SendKeys(password);
            SubmitButton.Click();
        }

    }
}
