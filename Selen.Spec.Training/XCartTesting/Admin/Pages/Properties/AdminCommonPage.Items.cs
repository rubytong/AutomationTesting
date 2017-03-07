using Core.Selen;
using OpenQA.Selenium;
using Core.Selen.Controls;

namespace XCartTesting.Admin.Pages
{
	public partial class AdminCommonPage
	{
		private Button closeDialogButton;

		public Button CloseDialogButton
		{
			get
			{
				if(closeDialogButton==null)
				{
					closeDialogButton = new Button(By.CssSelector("button.ui-dialog-titlebar-close"));
				}
				return closeDialogButton;
			}
			set
			{
				closeDialogButton = value;
			}
		}
	}
}