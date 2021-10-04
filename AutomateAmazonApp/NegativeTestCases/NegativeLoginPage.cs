using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace AutomateAmazonApp.NegativeTestCases
{
    public class NegativeLoginPage
    {
        public NegativeLoginPage(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[2]/div/div[1]/div/div/div/div/ul/li/span")]
        [CacheLookup]
        public IWebElement invalid;
    }
}
