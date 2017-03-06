using Core.Selen;
using OpenQA.Selenium;
using Core.Selen.Controls;

namespace XCartTesting.Pages
{
	public partial class LoginPage
	{
		private Textbox emailTextbox;
		private Textbox passwordTextbox;
		private Button submitButton;

		public Textbox EmailTextbox
		{
			get
			{
				if(emailTextbox==null)
				{
					emailTextbox = new Textbox(By.Name("login"));
				}
				return emailTextbox;
			}
			set
			{
				emailTextbox = value;
			}
		}
		public Textbox PasswordTextbox
		{
			get
			{
				if(passwordTextbox==null)
				{
					passwordTextbox = new Textbox(By.Name("password"));
				}
				return passwordTextbox;
			}
			set
			{
				passwordTextbox = value;
			}
		}
		public Button SubmitButton
		{
			get
			{
				if(submitButton==null)
				{
					submitButton = new Button(By.XPath("//*[@id='login_form']//button"));
				}
				return submitButton;
			}
			set
			{
				submitButton = value;
			}
		}
	}
}