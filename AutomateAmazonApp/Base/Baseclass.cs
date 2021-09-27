/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.ExtentReport;
using AventStack.ExtentReports;
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

        //Exptend report class
        ExtentReports reports = ReportClass.report();
        ExtentTest test;

        [SetUp]
        public void Setup()
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");

            //Launching chrome browser
            logger.Info("Launching browser");

            driver = new ChromeDriver();

            //Maximize the facebook window
            driver.Manage().Window.Maximize();

            //Get the Amazon URL
            driver.Url = "https://www.amazon.in/";

            logger.Info("Exit");
        }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\Screenshot\Test6.png");
        }

        [TearDown]
        public void TearDown()
        {
            Takescreenshot();
            test.Info("Details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\Screenshot\Test6.jpg").Build());

            test.Log(Status.Pass, "Test Passes");

            reports.Flush();
            //Close the current window
            driver.Quit();
        }
    }

}

