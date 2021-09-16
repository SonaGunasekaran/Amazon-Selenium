﻿/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.AmazonSignup;

namespace AutomateAmazonApp.ActionSigup
{
    public class SignupActionCass : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            SignupPage login = new SignupPage(driver);

            //click on sign-in button
            login.signIn.Click();

            //click on create account button
            login.createAccount.Click();

            //enter the name 
            login.name.SendKeys("Sona");

            //enter phone number
            login.mobNumber.SendKeys("9876654412");
            System.Threading.Thread.Sleep(4000);

            //enter emil address
            login.email.SendKeys("sona16061999@gmail.com");

            //enter password
            login.password.SendKeys("fkjfk67390");

            //continue
            login.continuebtn.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}