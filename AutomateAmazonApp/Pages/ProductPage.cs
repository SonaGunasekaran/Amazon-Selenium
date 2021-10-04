/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.Pages
{
    public class ProductPage
    {
        public ProductPage(IWebDriver driver)
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
        
        [FindsBy(How = How.Id, Using = "productTitle")]
        [CacheLookup]
        public IWebElement productTitle;

        [FindsBy(How = How.Id, Using = "buy-now-button")]
        [CacheLookup]
        public IWebElement buyNowbtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='a-spacing-base']")]
        [CacheLookup]
        public IWebElement addressTitle;
    }
}