using Core.Selen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCartTesting.Common;

namespace XCartTesting.Pages
{
    public partial class CommonPage
    {
        public void CloseDialog()
        {
            CloseDialogButton.WaitForControlExists(Constants.WaitMediumTime);
            if (CloseDialogButton.Displayed)
            {
                System.Console.WriteLine("abc");
                CloseDialogButton.Click();
            }
        }
    }
}
