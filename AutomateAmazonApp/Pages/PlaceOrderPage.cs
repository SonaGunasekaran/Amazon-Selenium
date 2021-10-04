/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :01/10/2021
 */
using AutomateAmazonApp.DoAction;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AutomateAmazonApp.Pages
{
    public class PlaceOrderPage : Base.Baseclass
    {
        public static void CheckForPayment()
        {
            try
            {
                DoActions.CheckForPayment();

                System.Threading.Thread.Sleep(2000);

                string title1 = "Place Your Order - Amazon.in Checkout";
                string title = driver.Title;
                Assert.AreEqual(title1, title);

                string actual=driver.FindElement(By.Id("spc_netbanking")).Text;
                Assert.AreEqual(actual, "Net Banking: HDFC Bank");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

    }
}
