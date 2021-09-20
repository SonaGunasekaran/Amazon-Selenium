
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace AutomateAmazonApp.ExtentReport
{
    [TestFixture]
    public class ReportClass
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\ExtendReport\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Sona");
                extent.AddSystemInfo("ProviderName", "Sona");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "Facebook Automation");
                string conifgPath = @"C:\Users\sona.g\source\repos\AutomateFacebookApp\AutomateFacebookApp\ExtendReport\extend-config.xml";
                htmlReporter.LoadConfig(conifgPath);
            }
            return extent;
        }
    }
}
