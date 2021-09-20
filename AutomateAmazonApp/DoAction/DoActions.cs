/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.AmazonLogin;
using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Linq;

namespace AutomateAmazonApp.DoAction
{
    public class DoActions : Base.Baseclass
    {
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

                        //enter the email
                        login.email.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(2000);

                        //click on continue button
                        login.continuebtn.Click();
                        System.Threading.Thread.Sleep(2000);

                        //enter the password 
                        login.password.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(2000);

                        //click on loginbutton
                        login.signbtn.Click();
                        logger.Info("Logged Suucessfully");
                        System.Threading.Thread.Sleep(4000);

                        //login.menu.SendKeys(Keys.ArrowDown);

                        login.hamBurgerMenu.Click();
                        System.Threading.Thread.Sleep(8000);

                        login.signOut.Click();
                        System.Threading.Thread.Sleep(2000);
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

