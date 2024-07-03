using OpenQA.Selenium;

namespace SeleniumNUnit.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       private IWebElement OnlineHighSchoolLink => driver.FindElement(By.XPath("//*[@href='https://miaprep.com/online-school/']"));

        public void NavigateToMOHS()
        {
            OnlineHighSchoolLink.Click();
        }
        
    }
}
