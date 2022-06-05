using OpenQA.Selenium;
using SreeLambdaTest.Drivers;
using TechTalk.SpecFlow;
using SreeLambdaTest.Pages;

namespace SreeLambdaTest.Steps
{
    [Binding]
    public sealed class LambdaStepDef
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;
        private readonly LambdaPage _lambdaPage ;
       
        public LambdaStepDef(SeleniumDriver browserDriver)
        {
            _lambdaPage = new LambdaPage(browserDriver.Current);
        }

        [Given(@"I navigate to LamdaTest App on following (.*) with (.*)")]
        public void GivenINavigateToLamdaTestAppOnFollowingChromeWithLambdaTestSampleApp(string env, string title)
        {
            _lambdaPage.OpenLambdaApp();
            _lambdaPage.verifyTitle(title);
        }
     

        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            _lambdaPage.clickfirstcheckbox();
        }

        [Given(@"I select the second item")]
        public void GivenISelectTheSecondItem()
        {
            _lambdaPage.clickfirstcheckbox();
        }

        [Given(@"I enter the (.*) in textbox")]
        public void GivenIEnterTheNItemInTextbox(string newItem)
        {
            _lambdaPage.Addnewitem(newItem);
        }


        [When(@"I click the Add button")]
        public void WhenIClickTheAddButton()
        {
            _lambdaPage.ClickAdd();
        }

        [Then(@"I verify whether (.*) is added to the list")]
        public void ThenIVerifyWhetherTheItemIsAddedToTheList(string newItem)
        {
            _lambdaPage.verifynewitem(newItem);
        }

    }
}
