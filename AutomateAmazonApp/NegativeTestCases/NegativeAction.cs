using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using System;

namespace AutomateAmazonApp.NegativeTestCases
{
    public class NegativeAction : Base.Baseclass
    {
        public static void CheckLoginPageWithInvalidData(string csvFilePath, string dataHeader)
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
                        NegativeLoginPage nlogin = new NegativeLoginPage(driver);

                        nlogin.signIn.Click();

                        nlogin.email.SendKeys(column[0]);

                        nlogin.continuebtn.Click();

                        nlogin.password.SendKeys(column[1]);

                        nlogin.signbtn.Click();

                        Assert.True(nlogin.invalid.Displayed);
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }

                }
            }
        }

        public static void NegativeCreateAmazonAccount(string csvFilePath1, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath1))
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
                        NegativeSignUp nsignup = new NegativeSignUp(driver);

                        //click on sign-in button
                        nsignup.signIn.Click();

                        //click on create account button
                        nsignup.createAccount.Click();

                        //Passing fullname through sendkeys
                        nsignup.name.SendKeys(column[0]);

                        //Passing mobile number through sendkeys
                        nsignup.mobNumber.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(4000);

                        //Passing email id through sendkeys
                        nsignup.email.SendKeys(column[2]);

                        //Passing the password through sendkeys
                        nsignup.password.SendKeys(column[3]);

                        //continue
                        nsignup.continuebtn.Click();

                        Assert.IsTrue(nsignup.invalid.Displayed);

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

