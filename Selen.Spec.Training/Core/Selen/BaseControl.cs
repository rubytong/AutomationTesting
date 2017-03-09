using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.Selen
{
    public class BaseControl
    {
        private By by;
        public string XPath { get; set; }
        private IWebElement element;

        protected IWebElement Element
        {
            get
            {
                if (this.by != null)
                    this.element = Browser.Wait(RunningSettings.WaitTime).Until(ExpectedConditions.ElementExists(by));
                return this.element;
            }
            set { this.element = value; }
        }
        public BaseControl() { }

        public BaseControl(By by)
        {
            this.by = by;
        }

        public BaseControl(string xPath)
        {
            this.by = By.XPath(xPath);
            this.XPath = xPath;
        }

        public virtual void Clear()
        {
            Element.Clear();
        }

        public virtual void Click()
        {
            Element = Browser.Wait(RunningSettings.WaitTime).Until(ExpectedConditions.ElementToBeClickable(by));
            Element.Click();

        }

        public void WaitForControlExists(int timeoutInSeconds=10)
        {
            try
            {
                Browser.Wait(timeoutInSeconds).Until(ExpectedConditions.ElementExists(by));
            }
            catch
            { }
        }
        public bool Exists
        {
            get
            {
                try
                {
                    if (by != null)
                    {
                        WaitForControlExists();
                        int count = Browser.Current.FindElements(by).Count;
                        return count > 0 ? true : false;
                    }
                    return element != null ? true : false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(String.Format("The {0} control doesn't exist in {1} with {2}", by, Browser.Current.Title, ex.Message));
                    return false;
                }
            }
        }

        public virtual bool Displayed
        {
            get
            {
                return Exists ? Element.Displayed : false;
            }
        }

        public virtual bool Enabled
        {
            get { return Element.Enabled; }
        }

        public virtual string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public virtual string GetCssValue(string propertyName)
        {
            return Element.GetCssValue(propertyName);
        }

        public virtual System.Drawing.Point Location
        {
            get { return Element.Location; }
        }

        public virtual bool Selected
        {
            get {return Element.Selected; }
        }

        public virtual void SendKeys(string text)
        {
            Element.SendKeys(text);
        }

        public virtual System.Drawing.Size Size
        {
            get { return Element.Size; }
        }

        public virtual void Submit()
        {
            Element.Submit();
        }

        public virtual string TagName
        {
            get { return Element.TagName; }
        }

        public virtual string Text
        {
            get { return Element.Text; }
        }

        public virtual IWebElement FindElement(By by)
        {
            return Element.FindElement(by);
        }

        public virtual System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Element.FindElements(by);
        }
    }
}
