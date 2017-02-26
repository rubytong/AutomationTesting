using Core.Selen;
using OpenQA.Selenium;
using Core.Selen.Controls;

namespace XCartTesting.Pages
{
	public partial class PageLogin
	{
		private Textbox txtEmail;
		private Textbox txtPassword;
		private Button btnSubmit;

		public Textbox TxtEmail
		{
			get
			{
				if(txtEmail==null)
				{
					txtEmail = new Textbox(By.Name("login"));
				}
				return txtEmail;
			}
			set
			{
				txtEmail = value;
			}
		}
		public Textbox TxtPassword
		{
			get
			{
				if(txtPassword==null)
				{
					txtPassword = new Textbox(By.Name("password"));
				}
				return txtPassword;
			}
			set
			{
				txtPassword = value;
			}
		}
		public Button BtnSubmit
		{
			get
			{
				if(btnSubmit==null)
				{
					btnSubmit = new Button(By.CssSelector("button.submit"));
				}
				return btnSubmit;
			}
			set
			{
				btnSubmit = value;
			}
		}
	}
}