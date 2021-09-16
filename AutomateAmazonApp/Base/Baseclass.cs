/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomateAmazonApp.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //Launching chrome browser
            driver = new ChromeDriver();

            //Maximize the facebook window
            driver.Manage().Window.Maximize();

            //Get the Amazon URL
            driver.Url = "https://www.amazon.in/";
        }
        [TearDown]
        public void TearDown()
        {
            //Close the current window
            driver.Quit();
        }
    }

}

