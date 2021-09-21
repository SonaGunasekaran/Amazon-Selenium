/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.AddToCart
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

        [FindsBy(How = How.XPath, Using = "//*[@class='_bXVsd_gridColumn_2Jfab']")]
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
    }
}
