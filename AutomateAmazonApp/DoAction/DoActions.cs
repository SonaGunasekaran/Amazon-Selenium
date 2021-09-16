/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.AmazonLogin;

namespace AutomateAmazonApp.DoAction
{
    public class DoActions : Base.Baseclass
    {
        public static void CheckEmailAndPassword()
        {
            LoginPage login = new LoginPage(driver);

            //click on sign-in button
            login.signIn.Click();

            //enter the email
            login.email.SendKeys("sona16061999@gmail.com");
            System.Threading.Thread.Sleep(2000);

            //click on continue button
            login.continuebtn.Click();
            System.Threading.Thread.Sleep(2000);

            //enter the password 
            login.password.SendKeys("Takeiteasy12#");
            System.Threading.Thread.Sleep(2000);

            //click on loginbutton
            login.signbtn.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
