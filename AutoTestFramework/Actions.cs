using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitalizeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }
        public static void FillInLoginForm(string username, string Password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.Username.SendKeys(username);
            lsPost.Password.SendKeys(Password);
            lsPost.RepeatPassword.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}
