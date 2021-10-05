using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomateAmazonApp.NegativeTestCases
{
    public class NegativeSignUp
    {
        public NegativeSignUp(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        [CacheLookup]
        public IWebElement signIn;

        [FindsBy(How = How.Id, Using = "createAccountSubmit")]
        [CacheLookup]
        public IWebElement createAccount;

        [FindsBy(How = How.XPath, Using = "//*[@class='a-spacing-small moa_desktop_signup']")]
        [CacheLookup]
        public IWebElement createAccDisplay;

        [FindsBy(How = How.Name, Using = "customerName")]
        [CacheLookup]
        public IWebElement name;

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement mobNumber;

        [FindsBy(How = How.Id, Using = "ap_email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "continue")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div/ul/li/span")]
        [CacheLookup]
        public IWebElement invalid;
    }
}
