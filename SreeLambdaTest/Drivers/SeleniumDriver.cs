using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SreeLambdaTest.Drivers
{

    public class SeleniumDriver : IDisposable
    {
        private readonly Lazy<IWebDriver> _currentWebDriverLazy;
        private bool _isDisposed;
        private readonly ScenarioContext _scenarioContext;
        public SeleniumDriver()
        {
            _currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);
        }
 
        public IWebDriver Current => _currentWebDriverLazy.Value;

        private IWebDriver CreateWebDriver()
        {
            //We use the Chrome browser
            string chromeDirectoryPath = (@"C:\SreeProject\");
            var chromeooption = new ChromeOptions();
            chromeooption.AddArgument("--auth-server-whitelist=*");
            chromeooption.AddArgument("--start-maximized");
            chromeooption.AddArgument("--disable-notifications");
            chromeooption.AddArgument("--ignore-certificate-errors");
            var driver = new ChromeDriver(chromeDirectoryPath, chromeooption);

            return driver;
        }
        public IWebDriver WebDriver { get; set; }
      
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();
            }

            _isDisposed = true;
        }
    }
  
}
