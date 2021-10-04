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
    public class SignupActionCass : Base.Baseclass
    {
        public static void CheckInputFields(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                //Skip the row with the column names
                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {

                        SignupPage signup = new SignupPage(driver);

                        //click on sign-in button
                        signup.signIn.Click();

                        //click on create account button
                        signup.createAccount.Click();

                        string expected = "Create Account";
                        string actual = signup.createAccDisplay.Text;
                        Assert.AreEqual(expected, actual);
                        System.Threading.Thread.Sleep(4000);

                        //Passing fullname through sendkeys
                        signup.name.SendKeys(column[0]);

                        //Passing mobile number through sendkeys
                        signup.mobNumber.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(4000);

                        //Passing email id through sendkeys
                        signup.email.SendKeys(column[2]);

                        //Passing the password through sendkeys
                        signup.password.SendKeys(column[3]);

                        //continue
                        signup.continuebtn.Click();
                        logger.Info("New account created successfully");
                        Takescreenshot();
                        System.Threading.Thread.Sleep(2000);

                        Assert.AreEqual(driver.Url, "https://www.amazon.in/ap/register");
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
