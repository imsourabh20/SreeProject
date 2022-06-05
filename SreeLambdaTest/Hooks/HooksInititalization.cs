using OpenQA.Selenium;
using SreeLambdaTest.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SreeLambdaTest.Pages;

namespace SreeLambdaTest.Hooks
{
    [Binding]
    public sealed class HooksInititalization
    {
        private readonly ScenarioContext _scenarioContext;
        public HooksInititalization(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeScenario]
        public void BeforeScenario(SeleniumDriver seleniumDriver)
        {
            var lambdaPageObject = new LambdaPage(seleniumDriver.Current);
        }

       
    }
}
