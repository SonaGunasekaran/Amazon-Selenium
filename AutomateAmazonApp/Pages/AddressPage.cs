/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :18/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.Pages
{
    public class AddressPage
    {
        public AddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='a-spacing-none']")]
        [CacheLookup]
        public IWebElement newAddress;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-enterAddressFullName")]
        [CacheLookup]
        public IWebElement fullName;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-enterAddressPhoneNumber")]
        [CacheLookup]
        public IWebElement mobNum;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-enterAddressPostalCode")]
        [CacheLookup]
        public IWebElement postalCode;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-enterAddressLine1")]
        [CacheLookup]
        public IWebElement addressLine1;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-enterAddressLine2")]
        [CacheLookup]
        public IWebElement addressLine2;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-enterAddressCity")]
        [CacheLookup]
        public IWebElement townOrcity;

        [FindsBy(How = How.XPath, Using = "//*[@id='address-ui-widgets-form-submit-button']/span/input")]
        [CacheLookup]
        public IWebElement addressbtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='a-spacing-base']")]
        [CacheLookup]
        public IWebElement paymentDisplay;

    }
}
