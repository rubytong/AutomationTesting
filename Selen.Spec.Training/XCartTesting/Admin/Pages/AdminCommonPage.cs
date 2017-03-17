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
            if (CloseDialogButton.WaitForControlVisible(Constants.WaitLongTime*2))
            {
                CloseDialogButton.Click();
            }
        }
    }
}
