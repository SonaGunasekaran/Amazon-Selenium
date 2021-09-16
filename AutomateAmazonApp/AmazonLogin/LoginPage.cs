/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.AmazonLogin
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        [CacheLookup]
        public IWebElement signIn;

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
