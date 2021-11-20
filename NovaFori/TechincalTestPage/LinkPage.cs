using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NovaForiTechnicalTest.Drivers
{
    public class LinkPage
    {
        protected IWebDriver WebDriver;
        protected readonly WebDriverWait Wait;
        public LinkPage(IWebDriver driver)
        {
            WebDriver = driver;
            PageFactory.InitElements(WebDriver, this);
            Wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
        }

        private IWebElement ResourcesDropdown => WebDriver.FindElement(By.Id("w-dropdown-list-0"));
        private IWebElement Faqs => WebDriver.FindElement(FaqsElement);
        private By FaqsElement => By.CssSelector("a.dropdown-link w-dropdown-link");
        private List<IWebElement> LeftNavigationLists => WebDriver.FindElements(By.CssSelector(" div.sticky-leftnav")).ToList();
        private IWebElement PricingLink => WebDriver.FindElement(PricingLinkElement);
        private By PricingLinkElement => By.CssSelector("a[href='#faq-pricing']");
        private IWebElement IntegrationsLink => WebDriver.FindElement(By.CssSelector("a[href='#faq-integrations']"));
        private IWebElement MarketplaceLink => WebDriver.FindElement(By.CssSelector("a[href='#faq-marketplace']"));
        private IWebElement HostingLink => WebDriver.FindElement(By.CssSelector("a[href='#faq-hosting']"));
        private IWebElement IndustryLink => WebDriver.FindElement(By.CssSelector("a[href='#faq-industry']"));
        private IWebElement FaqHeadingTitle => WebDriver.FindElement(FaqHeadingTitleElement);
        private By FaqHeadingTitleElement => By.CssSelector(".base-hero-heading");




        public void ClickOnResourcesDropdown()
        {
            //This will open the dropdown on the resources tab
            Wait.Until(ExpectedConditions.ElementIsVisible(FaqsElement));
            ResourcesDropdown.Click();
        }

        public string FaqHeadingTitleText()
        {
            //This will returns the Frequently Asked Questions when the user is on the faqs page
            Wait.Until(ExpectedConditions.ElementIsVisible(FaqHeadingTitleElement));
            return FaqHeadingTitle.Text;
        }
        public void ClickOnFaqs()
        {
            // This click on the faqs link once the dropdown displayed
            Wait.Until(ExpectedConditions.ElementIsVisible(FaqsElement));
            Faqs.Click();
        }
        public int CountLinksInStickyNavigationPage()
        {
            // Wait until the pricing link element is visible 
            Wait.Until(ExpectedConditions.ElementExists(PricingLinkElement));
            int linkCount = LeftNavigationLists.Count;
            return linkCount;
        }
        public void SelectLinksAndClickFilters(List<string> availableLink)
        {
            try
            {

                //This will click on each link on the left side navigate page but if the page is broken then return not found 404
                LeftNavigationLists.Where(x => x.Selected == true).ToList().ForEach(y => y.Click());
                //  LeftNavigationLists.ForEach(a=>a.Click());

                var getPriceTextValue = PricingLink.Text;

                if (availableLink.Any(x => x.Equals(getPriceTextValue, StringComparison.OrdinalIgnoreCase)))
                    PricingLink.Click();

                var getIntegrationsValue = IntegrationsLink.Text;

                if (availableLink.Any(x => x.Equals(getIntegrationsValue, StringComparison.OrdinalIgnoreCase)))
                    IntegrationsLink.Click();

                var getMarketplaceValue = MarketplaceLink.Text;
                if (availableLink.Any(x => x.Equals(getMarketplaceValue, StringComparison.OrdinalIgnoreCase)))
                    MarketplaceLink.Click();

                var getHostingValue = IntegrationsLink.Text;
                if (availableLink.Any(x => x.Equals(getHostingValue, StringComparison.OrdinalIgnoreCase)))
                    HostingLink.Click();

                var getIndustryValue = IntegrationsLink.Text;
                if (availableLink.Any(x => x.Equals(getIndustryValue, StringComparison.OrdinalIgnoreCase)))
                    IndustryLink.Click();
            }
            // this will return not found 404 error message if any of the click cant be clicked
            catch (NotFoundException ex)
            {
                Console.WriteLine("Not found 404");
            }
        }
    }

}