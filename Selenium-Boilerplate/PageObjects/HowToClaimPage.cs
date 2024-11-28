using System.Security.Policy;
using OpenQA.Selenium;

namespace Selenium_Boilerplate.PageObjects {
    public class HowToClaimPage: BasePage
    {
        public HowToClaimPage(IWebDriver driver) : base(driver) { }
        
        private static string Url = "https://www.gov.uk/pension-credit/how-to-claim";

        // Page elements
        private IWebElement Header => _driver.FindElement(By.XPath("//h1"));
        private IWebElement ApplyNowBtn => _driver.FindElement(By.XPath($"//a[contains(text(),'Apply now')]"));

        // Page methods
        public string GetHeaderText() => Header.Text;
        public ApplyForPensionCreditPage ClickApplyNowButton()
        {
            ApplyNowBtn.Click();
            return new ApplyForPensionCreditPage(_driver);
        }
        public void Open() => _driver.Navigate().GoToUrl(Url);
    }
}