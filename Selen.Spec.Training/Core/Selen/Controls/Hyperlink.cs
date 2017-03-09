using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selen.Controls
{
    public class Hyperlink:BaseControl
    {
        public Hyperlink() : base() { }
        public Hyperlink(By by):base(by){ }
        public Hyperlink(string xPath) : base(xPath) { }
    }
}
