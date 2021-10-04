/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :22/09/2021
 */
using AutomateAmazonApp.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateAmazonApp.DoAction
{
    public class AddressActionClass : Base.Baseclass
    {
        public static void CheckInputFields(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {
                        ProductActionClass.CheckInputFields();
                        
                        //checking the address title
                        string title1 = "Enter the delivery address for this order";
                        string title = driver.Title;
                        Assert.AreEqual(title1, title);

                        AddressPage add = new AddressPage(driver);

                        //validation
                        string actual =add.newAddress.Text;
                        string expected = "Add a new address";
                        Assert.AreEqual(actual, expected);

                        //enter the full name
                        add.fullName.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the mob number
                        add.mobNum.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the postal code
                        add.postalCode.SendKeys(column[2]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the Address line one
                        add.addressLine1.SendKeys(column[3]);
                        System.Threading.Thread.Sleep(1000);

                        //Enter Address line two
                        add.addressLine2.SendKeys(column[4]);
                        System.Threading.Thread.Sleep(300);

                        ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,1500)");
                        System.Threading.Thread.Sleep(1000);

                        //Select the respective state
                        SelectElement state = new SelectElement(driver.FindElement(By.Name("address-ui-widgets-enterAddressStateOrRegion")));
                        state.SelectByValue("TAMIL NADU");
                        System.Threading.Thread.Sleep(6000);

                        //Click on Add Address
                        add.addressbtn.Click();

                        System.Threading.Thread.Sleep(6000);
                        string expected1 = "Select a payment method";
                        string actual1 = add.paymentDisplay.Text;
                        Assert.AreEqual(actual1, expected1);
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }

            }
        }
    }
}
