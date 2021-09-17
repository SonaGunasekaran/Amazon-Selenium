/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.Search;
using OpenQA.Selenium;
using System;

namespace AutomateAmazonApp.SearchAction
{
    public class SearchActionClass : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            try
            {
                SearchItem search = new SearchItem(driver);

                //enter the search item to search
                search.searchItem.SendKeys("Redmi Note 10S");

                //click on search icon
                search.searchIcon.Click();
                System.Threading.Thread.Sleep(2000);

                //click the desired product
                search.product.Click();
                logger.Error("Product not found");
                System.Threading.Thread.Sleep(2000);

                //click on buy now button
                search.buyNowbtn.Click();
                logger.Error("field not found");
                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
                System.Threading.Thread.Sleep(2000);

                //enter the email address 
                search.email.SendKeys("sona16061999@gmail.com");

                //click continue button
                search.continuebtn.Click();

                //enter the password
                search.password.SendKeys("Takeiteasy12#");

                //click on loginbutton
                search.signbtn.Click();
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
