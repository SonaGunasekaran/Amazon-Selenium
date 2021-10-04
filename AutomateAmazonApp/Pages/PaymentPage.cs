/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.Pages
{
    public class PaymentPage
    {
        public PaymentPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='pp-c3qVSc-86']")]
        [CacheLookup]
        public IWebElement netBankingbtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='a-dropdown-prompt']")]
        [CacheLookup]
        public IWebElement bankOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='1_dropdown_combobox']/li[3]/a")]
        [CacheLookup]
        public IWebElement bank1;

        [FindsBy(How = How.Name, Using = "ppw-widgetEvent:SetPaymentPlanSelectContinueEvent")]
        [CacheLookup]
        public IWebElement contbtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='a-row a-size-large a-text-bold a-spacing-mini']")]
        [CacheLookup]
        public IWebElement reviewDisplay;


    }
}
