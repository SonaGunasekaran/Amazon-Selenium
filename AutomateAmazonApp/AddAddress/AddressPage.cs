using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;


namespace AutomateAmazonApp.AddAddress
{
    public class AddressPage
    {
        public AddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-hamburger-menu")]
        [CacheLookup]
        public IWebElement hamBurgerMenu;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/ul[1]/li[27]/a")]
        [CacheLookup]
        public IWebElement myAcc;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[3]/div[1]/a/div/div/div/div[2]/div/span")]
        [CacheLookup]
        public IWebElement yourAddress;

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "continue")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        [CacheLookup]
        public IWebElement signbtn;

        [FindsBy(How = How.Id, Using = "ya-myab-address-add-link")]
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

        [FindsBy(How = How.Name, Using = "address-ui-widgets-enterAddressStateOrRegion")]
        [CacheLookup]
        public SelectElement State;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-addr-details-address-type-and-business-hours")]
        [CacheLookup]
        public SelectElement addressType;

        [FindsBy(How = How.Id, Using = "address-ui-widgets-form-submit-button-announce")]
        [CacheLookup]
        public IWebElement addAddressbtn;


    }
}
