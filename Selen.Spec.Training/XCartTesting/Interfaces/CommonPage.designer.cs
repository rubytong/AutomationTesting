using Core.Selen;
using OpenQA.Selenium;
using Core.Selen.Controls;

namespace XCartTesting.Pages
{
	public partial class CommonPage
	{
		private Button btnCloseDialog;

		public Button BtnCloseDialog
		{
			get
			{
				if(btnCloseDialog==null)
				{
					btnCloseDialog = new Button(By.CssSelector("button.ui-dialog-titlebar-close"));
				}
				return btnCloseDialog;
			}
			set
			{
				btnCloseDialog = value;
			}
		}
	}
}