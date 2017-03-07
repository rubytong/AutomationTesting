using Core.Selen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCartTesting.Common;

namespace XCartTesting.Admin.Pages
{
    public partial class AdminCommonPage
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
