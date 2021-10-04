/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using System;

namespace AutomateAmazonApp.DoAction
{
    public class DoActions : Base.Baseclass
    {
        //Used to check title given and retived are same

        public static void TitleAfterLaunching()
        {
            string title1 = "Online Shopping site in India: Shop Online for Mobiles, Books, Watches, Shoes and More - Amazon.in";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void CheckEmailAndPassword(string csvFilePath, string dataHeader)
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
                        LoginPage login = new LoginPage(driver);

                       // click on sign-in button
                        login.signIn.Click();

                        string actual = "Sign-In";
                        string expected = login.signInTitle.Text;
                        Assert.AreEqual(actual, expected);
                        //enter the email
                        login.email.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //click on continue button
                        login.continuebtn.Click();
                        System.Threading.Thread.Sleep(500);

                        //enter the password 
                        login.password.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //click on loginbutton
                        login.signbtn.Click();
                        logger.Info("Logged Suucessfully");
                        System.Threading.Thread.Sleep(500);

                        string expectedUrl = "https://www.amazon.in/?ref_=nav_ya_signin&";
                        Assert.AreEqual(driver.Url,expectedUrl);
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

