using NUnit.Framework.Legacy;
using Selenium_Boilerplate.Context;
using Selenium_Boilerplate.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowProject1
{
    [Binding]
    public class StepDefinitions 
    {
        private readonly WebDriverContext webDriverContext;
        HowToClaimPage page;
        ApplyForPensionCreditPage applyPage;

        public StepDefinitions(WebDriverContext webDriverContext)
        {
            this.webDriverContext = webDriverContext;
        }

        [Given(@"I have opened the browser")]
        public void GivenIHaveOpenedTheBrowser()
        {
            // Instruction: add your code here
            page = new HowToClaimPage(this.webDriverContext.Driver);
        }
        
        [Given(@"I have entered page url")]
        public void GivenIHaveEnteredPageUrl()
        {
            // Instruction: add your code here
            page.Open();
        }

        [Given(@"I have clicked ""(.*)"" button")]
        public void GivenIHaveClickedButton(string p0)
        {
            // Instruction: add your code here
            applyPage = page.ClickApplyNowButton();
        }
        
        [Then(@"the page header should be ""(.*)""")]
        public void ThenThePageHeaderShouldBe(string p0)
        {
            // Instruction: add your code here
            StringAssert.AreEqualIgnoringCase(p0, applyPage.GetHeaderText());
        }
    }
}