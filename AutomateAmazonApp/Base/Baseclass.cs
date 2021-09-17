/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.DoAction;
using log4net;
using log4net.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace AutomateAmazonApp.Base
{
    public class Baseclass
    {
        public static ILog logger = LogManager.GetLogger(typeof(Tests));
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            //Launching chrome browser
            logger.Info("Launching browser");
            
            driver = new ChromeDriver();

            //Maximize the facebook window
            //driver.Manage().Window.Maximize();

            //Get the Amazon URL
            driver.Url = "https://www.amazon.in/";

            logger.Info("Exit");
        }
        [TearDown]
        public void TearDown()
        {
            //Close the current window
            driver.Quit();
        }
    }

}

