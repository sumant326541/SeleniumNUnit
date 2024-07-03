using OpenQA.Selenium;

namespace SeleniumNUnit.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement ApplyToOurSchoolLink => driver.FindElement(By.XPath("(//a[contains(@href,'https://forms.zohopublic.com/miaplazahelp/form/MOHSInitialApplication/formperma/')])[1]"));

        public void NavigateToMOHSApplication()
        {
            ApplyToOurSchoolLink.Click();
        }
    }
}
