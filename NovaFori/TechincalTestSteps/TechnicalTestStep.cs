using NovaForiTechnicalTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NovaForiTechnicalTest.Steps
{
    [Binding]
    public class TechnicalTestStep

    {
        IWebDriver WebDriver;

        public LinkPage LinkPage { get; set; }

        public TechnicalTestStep(IWebDriver webDriver)
        {

            WebDriver = webDriver;
        }

        [BeforeScenario()]
        public void setup()
        {
            LinkPage = new LinkPage(WebDriver);
        }

        [AfterScenario()]
        public void tearDown()
        {
            WebDriver.Quit();
        }

        [Given(@"the user is on homepage")]
        public void GivenTheUserIsOnHomepage()
        {
            WebDriver.Navigate().GoToUrl("https://www.novafori.com/");
        }

        [Given(@"the user click on the resources link")]
        public void GivenTheUserClickOnTheResourcesLink()
        {
            LinkPage.ClickOnResourcesDropdown();
        }

        [Given(@"the user click on the FAQ's link on the dropdown link")]
        public void GivenTheUserClickOnTheFAQSLinkOnTheDropdownLink()
        {
            LinkPage.ClickOnFaqs();
        }

        [Given(@"the user is on the faqs page")]
        public void GivenTheUserIsOnTheFaqsPage()
        {
            LinkPage.FaqHeadingTitleText().Equals("Frequently Asked Questions");
        }

        [When(@"the user click on each ""(.*)"" sub navigation link on the left side")]
        public void WhenTheUserClickOnEachSubNavigationLinkOnTheLeftSide(string stickyLeftNavigationLink)
        {
            LinkPage.SelectLinksAndClickFilters(stickyLeftNavigationLink.Split(',').Select(x => x.Trim()).ToList());
        }

        [Then(@"the total number of the  sub navigation link on the left side should be (.*)")]
        public void ThenTheTotalNumberOfTheSubNavigationLinkOnTheLeftSideShouldBe(int totalNumberOfStickyLink)
        {
            LinkPage.CountLinksInStickyNavigationPage().Equals(totalNumberOfStickyLink);
        }

    }
}