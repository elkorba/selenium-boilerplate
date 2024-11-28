using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Legacy;

// https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertions.html

// This class is for problem solving purposes
namespace Selenium_Boilerplate.Tests
{
    [TestFixture]
    public class FirstTestClass
    {
        // public static int counter = 0;
        public int counter = 0;
        public required IWebDriver driver;

        // Instruction: move it to external class and treat it as global setup
        [SetUp]
        public void SetUp()
        {
            counter = counter+1;
            Console.WriteLine("Setup " + counter);
            driver = new ChromeDriver();
        }

        // Instruction: move it to external class and treat it as global cleanup
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
            driver.Quit();
        }

        // Instruction: make sure these tests pass without changing assertions
        [Test]
        [TestCase(1, "message", true)]
        // [TestCase(2, null, false)]
        [TestCase(2, "", true)]
        [TestCase(3, " ", true)]
        public void TestMethod1(int i, string s, bool b)
        {
            Console.WriteLine(s);
            
            ClassicAssert.IsNotNull(s);

            ClassicAssert.AreEqual(i, counter);
            ClassicAssert.IsTrue(b);
        }

        // Instruction: make sure this test pass
        [Test]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("https://www.selenium.dev");
            
            ClassicAssert.AreEqual(SharedResources.GetSeleniumPageTitle(), driver.Title);
            driver.Quit();
        }

        // Instruction: how to avoid situation in which after test failure browser is not closed
        // Apply appropriate changes to the code
        // Adding driver.quit() to teardown
    }
}