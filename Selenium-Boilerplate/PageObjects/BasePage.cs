using OpenQA.Selenium;

namespace Selenium_Boilerplate.PageObjects {
    public class BasePage {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver) {
            _driver = driver;
        }
    }
}