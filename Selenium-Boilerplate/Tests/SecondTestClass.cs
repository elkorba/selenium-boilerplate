using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Selenium_Boilerplate.Tests
{
    [TestFixture]
    public class SecondTestClass
    {
        // Instruction: move it to external class and treat it as global setup
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Setup Headless");
        }

        // Instruction: move it to external class and treat it as global cleanup
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown Headless");
        }

        //Instruction: Make it in headless mode
        [Test]
        public void TestMethod3()
        {
            // Solution:
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("http://www.selenium.dev");
            
            ClassicAssert.AreEqual(SharedResources.GetSeleniumPageTitle(), driver.Title);
            driver.Quit();
        }
    }
}