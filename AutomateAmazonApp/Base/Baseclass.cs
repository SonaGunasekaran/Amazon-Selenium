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

            //driver.Url = "https://www.amazon.in/ap/signin?_encoding=UTF8&openid.assoc_handle=inflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.in%2Fgp%2Fyourstore%2Fhome%3Fie%3DUTF8%26action%3Dsign-out%26path%3D%252Fgp%252Fyourstore%252Fhome%26ref_%3Dnav_AccountFlyout_signout%26signIn%3D1%26useRedirectOnSuccess%3D1";

            logger.Info("Exit");
        }
        [TearDown]
        public void TearDown()
        {
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            //Close the current window
            driver.Quit();
        }
    }

}

