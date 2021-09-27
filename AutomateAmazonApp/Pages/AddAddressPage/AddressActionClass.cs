/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :22/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateAmazonApp.Pages.AddAddressPage
{
    public class AddressActionClass : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            try
            {
                //Click on ham burger menu
                driver.FindElement(By.XPath("//*[@class='hm-icon nav-sprite']")).Click();
                System.Threading.Thread.Sleep(8000);

                //Click on your account
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/ul[1]/li[27]/a")).Click();

                //Click on your address
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div[1]/a/div/div/div/div[2]/div/span")).Click();

                /*------------Sign In-----------------*/
                //Enter the email
                driver.FindElement(By.Name("email")).SendKeys("sona16061999@gmail.com");

                //Click on continue button
                driver.FindElement(By.Id("continue")).Click();

                //Enter the password
                driver.FindElement(By.Name("password")).SendKeys("Takeiteasy12#");

                //Click on Sign in button
                driver.FindElement(By.Id("signInSubmit")).Click();

                //Click  on add address
                driver.FindElement(By.Id("ya-myab-address-add-link")).Click();

                //enter the full name
                driver.FindElement(By.Id("address-ui-widgets-enterAddressFullName")).SendKeys("Santhosh");

                //Enter the mob number
                driver.FindElement(By.Id("address-ui-widgets-enterAddressPhoneNumber")).SendKeys("9876873341");

                //Enter the postal code
                driver.FindElement(By.Id("address-ui-widgets-enterAddressPostalCode")).SendKeys("625016");

                //Enter the Address line one
                driver.FindElement(By.Id("address-ui-widgets-enterAddressLine1")).SendKeys("46,Chokaalinga nagar");

                //Enter Address line two
                driver.FindElement(By.Id("address-ui-widgets-enterAddressLine2")).SendKeys("Madurai");

                //Select the respective state
                SelectElement state = new SelectElement(driver.FindElement(By.Name("address-ui-widgets-enterAddressStateOrRegion")));
                state.SelectByValue("TAMIL NADU");
                System.Threading.Thread.Sleep(4000);

                //Select the Delivery type
                SelectElement delType = new SelectElement(driver.FindElement(By.Name("address-ui-widgets-addr-details-address-type-and-business-hours")));
                delType.SelectByIndex(1);
                System.Threading.Thread.Sleep(4000);

                //Click on Add Address 
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/form/span/div/span/span/span/input")).Click();

                driver.FindElement(By.LinkText("Remove")).Click();

                driver.FindElement(By.Id("deleteAddressModal-0-submit-btn")).Click();

                Assert.AreEqual(driver.Url, "https://www.amazon.in/a/addresses?alertId=yaab-enterAddressSucceed");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

    }
}
