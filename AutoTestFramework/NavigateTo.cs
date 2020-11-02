using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage testPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            testPage.LoginForm.Click();
        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage testPage = new TestCasesPage();
            UsernameFieldLogInFormPage usernamePage = new UsernameFieldLogInFormPage();

            menu.TestCases.Click();
            testPage.UsernameFieldInLoginForm.Click();
            usernamePage.LoginForm.Click();

        }
    }
}
