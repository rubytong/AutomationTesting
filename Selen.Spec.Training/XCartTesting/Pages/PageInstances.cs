using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCartTesting.Pages
{
    public class PageInstances
    {
        #region Fields
        private LoginPage loginPage;
        private CommonPage commonPage;
        #endregion

        #region Properties
        public LoginPage LoginPage
        {
            get
            {
                if(this.loginPage==null) { this.loginPage = new LoginPage(); }
                return this.loginPage;
            }
        }

        public CommonPage CommonPage
        {
            get
            {
                if (this.commonPage == null) this.commonPage = new CommonPage();
                return this.commonPage;
            }
        }

        #endregion
    }
}
