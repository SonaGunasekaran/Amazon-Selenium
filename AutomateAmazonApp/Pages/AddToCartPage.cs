/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.Pages
{
    public class AddToCartPage
    {
        public AddToCartPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        [CacheLookup]
        public IWebElement searchItem;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        [CacheLookup]
        public IWebElement searchIcon;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div[1]/div[1]/div/span[3]/div[2]/div[1]/span/div/div/div[1]/div[2]/div[1]/div/div[1]/a/div/img")]
        [CacheLookup]
        public IWebElement product;

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        [CacheLookup]
        public IWebElement addtocartbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div[5]/div[4]/div[1]/div[9]/div/div[1]/div/div/div[1]/div[3]/div[1]/div[2]/div[3]/form/span/span/input")]
        [CacheLookup]
        public IWebElement cartbtn;

        [FindsBy(How = How.Name, Using = "proceedToRetailCheckout")]
        [CacheLookup]
        public IWebElement proceedtobtn;

        [FindsBy(How = How.ClassName, Using = "a-size-medium-plus a-color-base sw-atc-text a-text-bold")]
        [CacheLookup]
        public IWebElement addedCart;
    }
}
