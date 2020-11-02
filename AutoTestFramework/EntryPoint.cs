using AutoTestFramework.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTestFramework
{
    public class EntryPoint
    {
        IAlert alert;
        static void Main()
        {
            
        }

        [SetUp]
        public void Initalize()
        {
            Actions.InitalizeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillInLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.Credentials.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();

            Thread.Sleep(5000);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
