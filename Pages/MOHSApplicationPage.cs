using OpenQA.Selenium;

namespace SeleniumNUnit.Pages
{
    public class MOHSApplicationPage
    {
        private readonly IWebDriver driver;

        public MOHSApplicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Note Before Application

        private IWebElement NoteBeforeApplicationNextButton => driver.FindElement(By.XPath("(//button[contains(@aria-label, 'Next')])[1]"));

        //Parent information
        private IWebElement ParentFirstNameField => driver.FindElement(By.XPath("//input[@complink='Name_First']"));
        private IWebElement ParentLastNameField => driver.FindElement(By.XPath("//input[@complink='Name_Last']"));
        private IWebElement ParentEmailField => driver.FindElement(By.Id("Email-arialabel"));
        private IWebElement ParentPhoneField => driver.FindElement(By.Name("PhoneNumber"));
        private IWebElement SecondParentDropDown => driver.FindElement(By.Id("select2-Dropdown-arialabel-container"));
        private IWebElement HearFromSearchEngineCheckBox => driver.FindElement(By.CssSelector("[for='Checkbox_1']"));
        private IWebElement PreferredStartDateCalanderField => driver.FindElement(By.CssSelector("input#Date-date"));
        private IWebElement ParentNextButton => driver.FindElement(By.XPath("(//button[contains(@aria-label, 'Next')])[2]"));

        //Student Information
        private IWebElement NumberOfStudentDropDown => driver.FindElement(By.Id("select2-Dropdown1-arialabel-container"));
        private IWebElement NumberOfStudentOne => driver.FindElement(By.XPath("//li[text()='One']"));
        private IWebElement StudentFirstNameField => driver.FindElement(By.XPath("//input[@complink='Name2_First']"));
        private IWebElement StudentLastNameField => driver.FindElement(By.XPath("//input[@complink='Name2_Last']"));
        private IWebElement StudentEmailField => driver.FindElement(By.Id("Email2-arialabel"));
        private IWebElement StudentPhoneField => driver.FindElement(By.Name("PhoneNumber2"));
        private IWebElement StudentDOBField => driver.FindElement(By.Id("Date3-date"));
        private IWebElement StudentGenderDropDown => driver.FindElement(By.Id("select2-Dropdown3-arialabel-container"));
        private IWebElement StudentGenderMale => driver.FindElement(By.XPath("//li[text()='Male']"));
        private IWebElement MiaPreAccountConfirmationDropDown => driver.FindElement(By.Id("select2-Dropdown4-arialabel-container"));
         private IWebElement MostRecentGradeField => driver.FindElement(By.CssSelector("input#Number1-arialabel"));
        private IWebElement StudentCurrentSchoolingDropDown => driver.FindElement(By.Id("select2-Dropdown5-arialabel-container"));
        private IWebElement MotivationToApplyMOHSChildNeedFlexibleSchedule => driver.FindElement(By.CssSelector("[for='Checkbox7_1']"));
        private IWebElement Homeschool => driver.FindElement(By.XPath("//li[text()='Homeschool']"));
        private IWebElement Algebra1Checkbox => driver.FindElement(By.XPath("//*[text()='Algebra 1']"));
        private IWebElement English1Checkbox => driver.FindElement(By.XPath("//*[text()='English 1']"));
        private IWebElement PhysicsCheckbox => driver.FindElement(By.XPath("//*[text()='Physics']"));
        private IWebElement StudentChallangeDropDown => driver.FindElement(By.Id("select2-Dropdown13-arialabel-container"));
        private IWebElement StudentNextButton => driver.FindElement(By.XPath("(//button[contains(@aria-label, 'Next')])[3]"));

        //Finacial Aid Application Element Locators
        private IWebElement FinancialAidDropDown => driver.FindElement(By.Id("select2-Dropdown12-arialabel-container"));
        private IWebElement SubmitButton => driver.FindElement(By.XPath("(//button[@value='submit'])[1]"));

        //Common Element Locators
        private IWebElement DropDownYes => driver.FindElement(By.XPath("//li[text()='Yes']"));
        private IWebElement DropDownNo => driver.FindElement(By.XPath("//li[text()='No']"));
        
        //Success Full Submistion Locators
        private IWebElement SuccessMessage => driver.FindElement(By.CssSelector("[elname='thankyouMsgText']"));

        public void FillMOHSForm()
        {
            this.NoteBeforeApplicationNextButton.Click();
            this.FillParentInformation();
            this.FillStudentInformation();
            this.FillFinancialAidApplication();
        }
        public void FillParentInformation()
        {
            this.ParentFirstNameField.SendKeys("PFirstName");
            this.ParentLastNameField.SendKeys("PLastName");
            this.ParentEmailField.SendKeys("parent@gmail.com");
            this.ParentPhoneField.SendKeys("7406503456");
            this.SecondParentDropDown.Click();
            Thread.Sleep(1000);
            this.DropDownYes.Click();
            this.HearFromSearchEngineCheckBox.Click();
            this.PreferredStartDateCalanderField.Click();
            this.PreferredStartDateCalanderField.SendKeys("30-Aug-2024");
            this.ParentNextButton.Click();
            
        }

        public void FillStudentInformation()
        {
            this.NumberOfStudentDropDown.Click();
            this.NumberOfStudentOne.Click();
            this.StudentFirstNameField.SendKeys("SFirstName");
            this.StudentLastNameField.SendKeys("SLastName");
            this.StudentEmailField.SendKeys("Student@gmail.com");
            this.StudentPhoneField.SendKeys("7406507634");
            this.StudentDOBField.SendKeys("12-Apr-1999");
            Thread.Sleep(1000);
            this.StudentGenderDropDown.Click();
            Thread.Sleep(1000);
            this.StudentGenderMale.Click();
            this.MiaPreAccountConfirmationDropDown.Click();
            Thread.Sleep(1000);
            this.DropDownNo.Click();
            this.MostRecentGradeField.SendKeys("12");
            // this.StudentCurrentSchoolingDropDown.Click(); // this field not availabe any more
            // Thread.Sleep(1000);
            // this.Homeschool.Click();   
            this.MotivationToApplyMOHSChildNeedFlexibleSchedule.Click();
            this.Algebra1Checkbox.Click();
            this.English1Checkbox.Click();
            this.PhysicsCheckbox.Click();
            Thread.Sleep(1000);
            this.StudentChallangeDropDown.Click();
            Thread.Sleep(1000);
            this.DropDownNo.Click();

             Thread.Sleep(2000);
            this.StudentNextButton.Click();
        }

        public void FillFinancialAidApplication()
        {
            FinancialAidDropDown.Click();
            Thread.Sleep(1000);
            DropDownNo.Click();
            SubmitButton.Click();
            Thread.Sleep(2000);
        }

        public string GetSuccessMessage()
        {
            return SuccessMessage.Text;
        }
    }
}
