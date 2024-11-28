using OpenQA.Selenium.Chrome;
using Selenium_Boilerplate.Context;
using TechTalk.SpecFlow;

namespace Hooks {
  [Binding]
  public class GlobalHooks
  {
      private readonly WebDriverContext _webDriverContext;

      public GlobalHooks(WebDriverContext webDriverContext)
      {
          _webDriverContext = webDriverContext;
      }

      [BeforeScenario]
      public void SetUp()
      {
          Console.WriteLine("BeforeScenario");
          
          var options = new ChromeOptions();
          options.AddArgument("--headless");
          options.AddArgument("--disable-gpu");

          _webDriverContext.Driver = new ChromeDriver(options);
      }

      [AfterScenario]
      public void TearDown()
      {
          Console.WriteLine("AfterScenario");
          
          _webDriverContext.Driver.Quit();
      }
  }
}