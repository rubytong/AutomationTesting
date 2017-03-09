using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selen.Controls
{
    public class Table:BaseControl
    {
        public Table() : base() { }
        public Table(By by):base(by){ }
        public Table(string xPath) : base(xPath) { }
    }
}
