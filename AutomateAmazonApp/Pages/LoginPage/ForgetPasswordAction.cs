﻿/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :21/09/2021
 */

namespace AutomateAmazonApp.Pages.LoginPage
{
    public class ForgetPasswordAction : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            LoginPage flogin = new LoginPage(driver);

            //Click on signin button
            flogin.signIn.Click();

            //Enter the email
            flogin.email.SendKeys("sona16061999@gmail.com");
            
            //click on continue button
            flogin.continuebtn.Click();

            //Click on forget password link
            flogin.forgetPass.Click();
            System.Threading.Thread.Sleep(500);

            //click on continue button
            flogin.contbtn.Click();
        }
    }
}
