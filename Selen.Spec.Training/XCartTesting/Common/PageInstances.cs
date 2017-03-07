using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCartTesting.Admin.Pages;

namespace XCartTesting.Common
{
    public class PageInstances
    {
        #region Fields
        private AdminLoginPage adminLoginPage;
        private AdminCommonPage adminCommonPage;
        #endregion

        #region Properties
        public AdminLoginPage AdminLoginPage
        {
            get
            {
                if(this.adminLoginPage==null) { this.adminLoginPage = new AdminLoginPage(); }
                return this.adminLoginPage;
            }
        }

        public AdminCommonPage AdminCommonPage
        {
            get
            {
                if (this.adminCommonPage == null) this.adminCommonPage = new AdminCommonPage();
                return this.adminCommonPage;
            }
        }

        #endregion
    }
}
