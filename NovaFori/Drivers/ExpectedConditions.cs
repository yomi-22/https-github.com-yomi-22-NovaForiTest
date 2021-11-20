using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaForiTechnicalTest.Drivers
{
    public static class ExpectedConditions
    {
        public static Func<IWebDriver, IAlert> AlertIsPresent();
        //
        // Summary:
        //     An expectation for checking the Alert State
        //
        // Parameters:
        //   state:
        //     A value indicating whether or not an alert should be displayed in order to meet
        //     this condition.
        //
        // Returns:
        //     true alert is in correct state present or not present; otherwise, false.
        public static Func<IWebDriver, bool> AlertState(bool state);
        //
        // Summary:
        //     An expectation for checking that an element is present on the DOM of a page.
        //     This does not necessarily mean that the element is visible.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     The OpenQA.Selenium.IWebElement once it is located.
        public static Func<IWebDriver, IWebElement> ElementExists(By locator);
        //
        // Summary:
        //     An expectation for checking that an element is present on the DOM of a page and
        //     visible. Visibility means that the element is not only displayed but also has
        //     a height and width that is greater than 0.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     The OpenQA.Selenium.IWebElement once it is located and visible.
        public static Func<IWebDriver, IWebElement> ElementIsVisible(By locator);
        //
        // Summary:
        //     An expectation for checking if the given element is in correct state.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        //   selected:
        //     selected or not selected
        //
        // Returns:
        //     true given element is in correct state.; otherwise, false.
        public static Func<IWebDriver, bool> ElementSelectionStateToBe(By locator, bool selected);
        //
        // Summary:
        //     An expectation for checking if the given element is in correct state.
        //
        // Parameters:
        //   element:
        //     The element.
        //
        //   selected:
        //     selected or not selected
        //
        // Returns:
        //     true given element is in correct state.; otherwise, false.
        public static Func<IWebDriver, bool> ElementSelectionStateToBe(IWebElement element, bool selected);
        //
        // Summary:
        //     An expectation for checking an element is visible and enabled such that you can
        //     click it.
        //
        // Parameters:
        //   element:
        //     The element.
        //
        // Returns:
        //     The OpenQA.Selenium.IWebElement once it is clickable (visible and enabled).
        public static Func<IWebDriver, IWebElement> ElementToBeClickable(IWebElement element);
        //
        // Summary:
        //     An expectation for checking an element is visible and enabled such that you can
        //     click it.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     The OpenQA.Selenium.IWebElement once it is located and clickable (visible and
        //     enabled).
        public static Func<IWebDriver, IWebElement> ElementToBeClickable(By locator);
        //
        // Summary:
        //     An expectation for checking if the given element is selected.
        //
        // Parameters:
        //   element:
        //     The element.
        //
        //   selected:
        //     selected or not selected
        //
        // Returns:
        //     true given element is selected.; otherwise, false.
        public static Func<IWebDriver, bool> ElementToBeSelected(IWebElement element, bool selected);
        //
        // Summary:
        //     An expectation for checking if the given element is selected.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     true given element is selected.; otherwise, false.
        public static Func<IWebDriver, bool> ElementToBeSelected(By locator);
        //
        // Summary:
        //     An expectation for checking if the given element is selected.
        //
        // Parameters:
        //   element:
        //     The element.
        //
        // Returns:
        //     true given element is selected.; otherwise, false.
        public static Func<IWebDriver, bool> ElementToBeSelected(IWebElement element);
        //
        // Summary:
        //     An expectation for checking whether the given frame is available to switch to.
        //     If the frame is available it switches the given driver to the specified frame.
        //
        // Parameters:
        //   frameLocator:
        //     Used to find the frame (id or name)
        //
        // Returns:
        //     OpenQA.Selenium.IWebDriver
        public static Func<IWebDriver, IWebDriver> FrameToBeAvailableAndSwitchToIt(string frameLocator);
        //
        // Summary:
        //     An expectation for checking whether the given frame is available to switch to.
        //     If the frame is available it switches the given driver to the specified frame.
        //
        // Parameters:
        //   locator:
        //     Locator for the Frame
        //
        // Returns:
        //     OpenQA.Selenium.IWebDriver
        public static Func<IWebDriver, IWebDriver> FrameToBeAvailableAndSwitchToIt(By locator);
        //
        // Summary:
        //     An expectation for checking that an element is either invisible or not present
        //     on the DOM.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     true if the element is not displayed; otherwise, false.
        public static Func<IWebDriver, bool> InvisibilityOfElementLocated(By locator);
        //
        // Summary:
        //     An expectation for checking that an element with text is either invisible or
        //     not present on the DOM.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        //   text:
        //     Text of the element
        //
        // Returns:
        //     true if the element is not displayed; otherwise, false.
        public static Func<IWebDriver, bool> InvisibilityOfElementWithText(By locator, string text);
        //
        // Summary:
        //     An expectation for checking that all elements present on the web page that match
        //     the locator.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     The list of OpenQA.Selenium.IWebElement once it is located.
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> PresenceOfAllElementsLocatedBy(By locator);
        //
        // Summary:
        //     Wait until an element is no longer attached to the DOM.
        //
        // Parameters:
        //   element:
        //     The element.
        //
        // Returns:
        //     false is the element is still attached to the DOM; otherwise, true.
        public static Func<IWebDriver, bool> StalenessOf(IWebElement element);
        //
        // Summary:
        //     An expectation for checking if the given text is present in the specified element.
        //
        // Parameters:
        //   element:
        //     The WebElement
        //
        //   text:
        //     Text to be present in the element
        //
        // Returns:
        //     true once the element contains the given text; otherwise, false.
        public static Func<IWebDriver, bool> TextToBePresentInElement(IWebElement element, string text);
        //
        // Summary:
        //     An expectation for checking if the given text is present in the element that
        //     matches the given locator.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        //   text:
        //     Text to be present in the element
        //
        // Returns:
        //     true once the element contains the given text; otherwise, false.
        public static Func<IWebDriver, bool> TextToBePresentInElementLocated(By locator, string text);
        //
        // Summary:
        //     An expectation for checking if the given text is present in the specified elements
        //     value attribute.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        //   text:
        //     Text to be present in the element
        //
        // Returns:
        //     true once the element contains the given text; otherwise, false.
        public static Func<IWebDriver, bool> TextToBePresentInElementValue(By locator, string text);
        //
        // Summary:
        //     An expectation for checking if the given text is present in the specified elements
        //     value attribute.
        //
        // Parameters:
        //   element:
        //     The WebElement
        //
        //   text:
        //     Text to be present in the element
        //
        // Returns:
        //     true once the element contains the given text; otherwise, false.
        public static Func<IWebDriver, bool> TextToBePresentInElementValue(IWebElement element, string text);
        //
        // Summary:
        //     An expectation for checking that the title of a page contains a case-sensitive
        //     substring.
        //
        // Parameters:
        //   title:
        //     The fragment of title expected.
        //
        // Returns:
        //     true when the title matches; otherwise, false.
        public static Func<IWebDriver, bool> TitleContains(string title);
        //
        // Summary:
        //     An expectation for checking the title of a page.
        //
        // Parameters:
        //   title:
        //     The expected title, which must be an exact match.
        //
        // Returns:
        //     true when the title matches; otherwise, false.
        public static Func<IWebDriver, bool> TitleIs(string title);
        //
        // Summary:
        //     An expectation for the URL of the current page to be a specific URL.
        //
        // Parameters:
        //   fraction:
        //     The fraction of the url that the page should be on
        //
        // Returns:
        //     true when the URL contains the text; otherwise, false.
        public static Func<IWebDriver, bool> UrlContains(string fraction);
        //
        // Summary:
        //     An expectation for the URL of the current page to be a specific URL.
        //
        // Parameters:
        //   regex:
        //     The regular expression that the URL should match
        //
        // Returns:
        //     true if the URL matches the specified regular expression; otherwise, false.
        public static Func<IWebDriver, bool> UrlMatches(string regex);
        //
        // Summary:
        //     An expectation for the URL of the current page to be a specific URL.
        //
        // Parameters:
        //   url:
        //     The URL that the page should be on
        //
        // Returns:
        //     true when the URL is what it should be; otherwise, false.
        public static Func<IWebDriver, bool> UrlToBe(string url);
        //
        // Summary:
        //     An expectation for checking that all elements present on the web page that match
        //     the locator are visible. Visibility means that the elements are not only displayed
        //     but also have a height and width that is greater than 0.
        //
        // Parameters:
        //   elements:
        //     list of WebElements
        //
        // Returns:
        //     The list of OpenQA.Selenium.IWebElement once it is located and visible.
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> VisibilityOfAllElementsLocatedBy(ReadOnlyCollection<IWebElement> elements);
        //
        // Summary:
        //     An expectation for checking that all elements present on the web page that match
        //     the locator are visible. Visibility means that the elements are not only displayed
        //     but also have a height and width that is greater than 0.
        //
        // Parameters:
        //   locator:
        //     The locator used to find the element.
        //
        // Returns:
        //     The list of OpenQA.Selenium.IWebElement once it is located and visible.
        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> VisibilityOfAllElementsLocatedBy(By locator);

    }
}
