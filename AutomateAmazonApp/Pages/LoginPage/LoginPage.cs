/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomateAmazonApp.Pages.LoginPage
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

        [FindsBy(How = How.LinkText, Using = "Forgot Password")]
        [CacheLookup]
        public IWebElement forgetPass;

        [FindsBy(How = How.Id, Using = "continue")]
        [CacheLookup]
        public IWebElement contbtn;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        [CacheLookup]
        public IWebElement signbtn;

        [FindsBy(How = How.Id, Using = "nav-hamburger-menu")]
        [CacheLookup]
        public IWebElement hamBurgerMenu;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/ul[1]/li[29]/a")]
        [CacheLookup]
        public IWebElement signOut;
    }
}
