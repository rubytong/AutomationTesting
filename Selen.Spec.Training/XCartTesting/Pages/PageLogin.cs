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
    public partial class PageLogin : CommonPage
    {
        public void Login(string username, string password)
        {
            TxtEmail.SendKeys(username);
            TxtPassword.SendKeys(password);
            BtnSubmit.Click();

            //Close dialog if any
            CloseDialog();
        }

    }
}
