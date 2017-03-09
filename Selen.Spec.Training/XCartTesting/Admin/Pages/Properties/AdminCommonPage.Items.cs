using Core.Selen;
using OpenQA.Selenium;
using Core.Selen.Controls;

namespace XCartTesting.Admin.Pages
{
	public partial class AdminCommonPage
	{
		private Button closeDialogButton;
		private Hyperlink leftMenuItemHyperlink;
		private Hyperlink leftSubMenuItemHyperlink;

		public Button CloseDialogButton
		{
			get
			{
				if (closeDialogButton==null)
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
		public Hyperlink LeftMenuItemHyperlink
		{
			get
			{
				if (leftMenuItemHyperlink==null)
				{
					leftMenuItemHyperlink = new Hyperlink("//.[@id='leftMenu']//a[.='{0}']");
				}
				return leftMenuItemHyperlink;
			}
			set
			{
				leftMenuItemHyperlink = value;
			}
		}
		public Hyperlink LeftSubMenuItemHyperlink
		{
			get
			{
				if (leftSubMenuItemHyperlink==null)
				{
					leftSubMenuItemHyperlink = new Hyperlink("//div[@id='leftMenu']//a[.='{0}']/../following-sibling::div[1]//a[.='{1}']");
				}
				return leftSubMenuItemHyperlink;
			}
			set
			{
				leftSubMenuItemHyperlink = value;
			}
		}
	}
}