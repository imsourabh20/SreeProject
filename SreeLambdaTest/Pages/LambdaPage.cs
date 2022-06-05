using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SreeLambdaTest.Pages
{
    public class LambdaPage
    {
        private static readonly By title = By.XPath("/html/body/div/div/h2");
        private readonly IWebDriver _webDriver;
        private const string lambdaAppurl = "https://lambdatest.github.io/sample-todo-app/";
   
        public const int DefaultWaitInSeconds = 5;
        public LambdaPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public IWebElement FirstItem => _webDriver.FindElement(By.Name("li1"));
        public IWebElement SecondItem => _webDriver.FindElement(By.Name("li2"));
        public IWebElement ThirdItem => _webDriver.FindElement(By.Name("li3"));
        public IWebElement ForurthItem => _webDriver.FindElement(By.Name("li4"));
        public IWebElement FifthItem => _webDriver.FindElement(By.Name("li5"));
        public IWebElement SixthItem => _webDriver.FindElement(By.Name("li6"));
        public IWebElement textfield => _webDriver.FindElement(By.Id("sampletodotext"));


        public IWebElement addButton => _webDriver.FindElement(By.Id("addbutton"));

        public void OpenLambdaApp()
        {
            _webDriver.Navigate().GoToUrl(lambdaAppurl);
           
        }
        public void verifyTitle(string Title)
        {
            try
            {
                _webDriver.FindElement(title);
            }
            catch { throw new Exception(GetType() + "Page is not correctly loaded:locator is not foung'" + title); }

        }

        public void clickfirstcheckbox()
        {
            FirstItem.Click();

        }
        public void clicksecondcheckbox()
        {
            SecondItem.Click();
        }
        public void Addnewitem(string newItem)
        {
            textfield.SendKeys(newItem);
         
        }
        public void ClickAdd()
        {
            addButton.Click();
        }
        public void verifynewitem(string newItem)
        {
          string  getText = SixthItem.Text;
            Assert.IsTrue(newItem.Contains(getText));
        }
    }
}
