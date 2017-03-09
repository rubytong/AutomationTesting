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
            RunningSettings.WaitTime = Constants.WaitMediumTime * 2;
            if (CloseDialogButton.Displayed)
            {
                CloseDialogButton.Click();
            }
            RunningSettings.WaitTime = RunningSettings.DefaultTimeOut;
        }
    }
}
