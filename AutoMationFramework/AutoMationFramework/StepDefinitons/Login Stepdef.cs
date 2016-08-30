using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutoMationFramework.StepDefinitons
{
    [Binding]
    class first
    {
        IWebDriver driver;
        [Given(@"I Launch The Browser")]
        public void GivenILaunchTheBrowser()
        {

            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"I navigate to ""(.*)""")]
        public void WhenINavigateTo(string p0)
        {
            //ScenarioContext.Current.Pending();
            driver.Navigate().GoToUrl("https://mozart-uat.iso.com");
        }
        [Then(@"The Login Should Display")]
        public void ThenTheLoginShouldDisplay()
        {
            //ScenarioContext.Current.Pending();
            Assert.IsNotNull(driver.FindElement(By.Id("signIn")));
        }
        [When(@"User Log in With ""(.*)"" and ""(.*)""")]
        [When(@"User Log in With ""(.*)"" and ""(.*)""")]
        public void WhenUserLogInWithAnd(string p0, string p1)
        {
            driver.FindElement(By.Id("username")).SendKeys("p0");
            driver.FindElement(By.Id("password")).SendKeys("p1");

        }
        
        [Then(@"Login should be successfull")]
        public void ThenLoginShouldBeSuccessfull()
        {
            Assert.IsNotNull(driver.FindElement(By.ClassName("ng-binding")));
        }


    }

}