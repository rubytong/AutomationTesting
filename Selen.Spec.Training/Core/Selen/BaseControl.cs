using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.Selen
{
    public class BaseControl
    {
        protected By by;
        protected IWebElement element;
        public BaseControl() { }

        public BaseControl(By by)
        {
            this.by = by;
            element = Browser.Current.FindElement(by);
        }

        public virtual void Clear()
        {
            element.Clear();
        }

        public virtual void Click()
        {
            element.Click();
        }

        public virtual bool Displayed
        {
            get { return element.Displayed; }
        }

        public virtual bool Enabled
        {
            get { return element.Enabled; }
        }

        public virtual string GetAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }

        public virtual string GetCssValue(string propertyName)
        {
            return element.GetCssValue(propertyName);
        }

        public virtual System.Drawing.Point Location
        {
            get { return element.Location; }
        }

        public virtual bool Selected
        {
            get { return element.Selected; }
        }

        public virtual void SendKeys(string text)
        {
            element.SendKeys(text);
        }

        public virtual System.Drawing.Size Size
        {
            get { return element.Size; }
        }

        public virtual void Submit()
        {
            element.Submit();
        }

        public virtual string TagName
        {
            get { return element.TagName; }
        }

        public virtual string Text
        {
            get { return element.Text; }
        }

        public virtual IWebElement FindElement(By by)
        {
            return element.FindElement(by);
        }

        public virtual System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return element.FindElements(by);
        }
    }
}
