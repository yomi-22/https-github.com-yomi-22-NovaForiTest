using NovaForiTechnicalTest.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace NovaForiTechnicalTest.Hooks
{
    public class GlobalHooks
    {
        IWebDriver WebDriver;

        public LinkPage LinkPage { get; set; }


        [BeforeScenario()]
        public void setup()
        {
            LinkPage = new LinkPage(WebDriver);
            WebDriver.Manage().Window.Maximize();
        }

        [AfterScenario()]
        public void tearDown()
        {
            WebDriver.Quit();
        }

    }
}
