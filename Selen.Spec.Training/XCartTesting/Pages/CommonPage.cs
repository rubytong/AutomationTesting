using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCartTesting.Pages
{
    public partial class CommonPage
    {
        public void CloseDialog()
        {
            if (BtnCloseDialog.Displayed) BtnCloseDialog.Click();
        }
    }
}
