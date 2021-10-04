/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */
using AutomateAmazonApp.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AutomateAmazonApp.DoAction
{
    public class PaymentActionPage : Base.Baseclass
    {
        public static void CheckForPayment()
        {
            string addressFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Address.csv";

            try
            {
                AddressActionClass.CheckInputFields(addressFilePath,
                                                           "Full name,Mobile number,Pin code,Address line1,Address line2,Town/City");

                string title1 = "Select a Payment Method - Amazon.in Checkout";
                string title = driver.Title;
                Assert.AreEqual(title1, title);
                
                PaymentPage pay = new PaymentPage(driver);

                System.Threading.Thread.Sleep(6000);
                //Click on choose bank option
                pay.bankOption.Click();

                //Click on desired bank
                pay.bank1.SendKeys(Keys.ArrowDown);
                pay.bank1.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(2000);

                //click on continue button
                pay.contbtn.Click();

                //Validate whether it is redirect to next page 
                System.Threading.Thread.Sleep(5000);
                string expected = "Review your order";
                string actual = pay.reviewDisplay.Text;
                Assert.AreEqual(actual, expected);

               System.Threading.Thread.Sleep(8000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }
    }
}
