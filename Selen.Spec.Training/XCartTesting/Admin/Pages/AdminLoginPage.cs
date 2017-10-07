namespace XCartTesting.Admin.Pages
{
    public partial class AdminLoginPage
    {
        public void Login(string username, string password)
        {
            EmailTextbox.SendKeys(username);
            PasswordTextbox.SendKeys(password);
            SubmitButton.Click();
        }

    }
}
