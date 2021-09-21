/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.Pages.BuyNow
{
    public class SearchItem
    {
        public SearchItem(IWebDriver driver)
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

        [FindsBy(How = How.Id, Using = "buy-now-button")]
        [CacheLookup]
        public IWebElement buyNowbtn;

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
