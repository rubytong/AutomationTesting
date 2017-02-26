using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCartTesting.Pages
{
    public class PageMapping
    {
        #region Fields
        private PageLogin pageLogin;
        #endregion

        #region Properties
        public PageLogin PageLogin
        {
            get
            {
                if (this.pageLogin == null) this.pageLogin = new PageLogin();
                return this.pageLogin;
            }
        }
        #endregion
    }
}
