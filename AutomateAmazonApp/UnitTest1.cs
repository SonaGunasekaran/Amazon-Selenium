/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace AutomateAmazonApp
{
    public class Tests : Base.Baseclass
    {
        string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\CsvFile\Filecsv.csv";
        [Test, Order(1)]
        public void TestLoginPage()
        {
            DoAction.DoActions.CheckEmailAndPassword(csvFilePath,
                                                     "Email,Password");
        }

        [Test, Order(2)]
        public void TestSignupPage()
        {
            ActionSigup.SignupActionCass.CheckInputFields();
        }

        [Test, Order(3)]
        public void TestSearchActionAndBuyNowAction()
        {
            SearchAction.SearchActionClass.CheckInputFields();
        }

        [Test, Order(4)]
        public void TestAddToCart()
        {
            AddToCartAction.AddToCartActionPage.CheckInputFields();
        }

        [Test, Order(5)]
        public void TestAddAddress()
        {
            AddressAction.AddressActionClass.CheckInputFields();
        }


        [Test, Order(6)]
        public void TestSendKeys()
        {
            IWebElement MyElement = driver.FindElement(By.Id("twotabsearchtextbox"));
            MyElement.SendKeys(Keys.NumberPad5);
            MyElement.SendKeys(Keys.Control + "v");
            MyElement.SendKeys(Keys.Enter);
        }
    }
}