using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selen.Controls
{
    public class Button:BaseControl
    {
        public Button() : base() { }
        public Button(By by):base(by){ }
        public Button(string xPath) : base(xPath) { }
    }
}
