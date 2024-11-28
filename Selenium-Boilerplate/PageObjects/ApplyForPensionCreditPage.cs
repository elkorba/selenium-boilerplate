using OpenQA.Selenium;

namespace Selenium_Boilerplate.PageObjects {
    public class ApplyForPensionCreditPage: BasePage
    {
        public ApplyForPensionCreditPage(IWebDriver driver) : base(driver) { }
        
        private static string Url = "https://apply-for-pension-credit.service.gov.uk/apply-citizen-ui/start";

        // Page elements
        private IWebElement Header => _driver.FindElement(By.XPath("//h1"));

        // Page methods
        public string GetHeaderText() => Header.Text;
        public void Open() => _driver.Navigate().GoToUrl(Url);
    }
}