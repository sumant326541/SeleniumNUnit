using NUnit.Framework;
using SeleniumNUnit.Pages;

namespace SeleniumNUnit.Tests
{
    public class ApplyForMOHSTest : BaseTest
    {
        [Test]
        public void TestMOHS()
        {
            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            
            var loginPage = new LoginPage(driver);
            var homePage = new HomePage(driver);
            var mohsApplicationPage = new MOHSApplicationPage(driver);

            loginPage.NavigateToMOHS();
            homePage.NavigateToMOHSApplication();
            mohsApplicationPage.FillMOHSForm();
            string SuccessMessage = mohsApplicationPage.GetSuccessMessage();
            Assert.AreEqual("Thank you! Your response has been submitted.", SuccessMessage);
        }
    }
}
