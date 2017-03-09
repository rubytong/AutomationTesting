using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selen.Controls
{
    public class Span:BaseControl
    {
        public Span() : base() { }
        public Span(By by):base(by){ }
        public Span(string xPath) : base(xPath) { }
    }
}
