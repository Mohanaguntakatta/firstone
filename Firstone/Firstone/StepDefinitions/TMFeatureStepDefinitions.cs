using Firstone.Pages;
using Firstone.Utilites;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Firstone.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions:CommonDriver
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();

            Loginpage loginpageobj = new Loginpage();
            loginpageobj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object intialization and definitioon
            HomePage homepageobj = new HomePage();
            homepageobj.GotoTMPage(driver);
        }

        [When(@"I create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {

            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObg = new TMPage();

            string newCode = tmPageObg.GetCode(driver);
            string newDescription = tmPageObg.GetDescription(driver);
            string newPrice = tmPageObg.GetPrice(driver);

            Assert.That(newCode == "C001", "Actual code and expected code do not match");
            Assert.That(newDescription == "Glass", "Actual code and expected code do not match");
            Assert.That(newPrice == "100", "Actual code and expected code do not match");
        }
    }
}
