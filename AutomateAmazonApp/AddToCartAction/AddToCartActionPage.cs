/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.AddToCart;
using OpenQA.Selenium;
using System;

namespace AutomateAmazonApp.AddToCartAction
{
    public class AddToCartActionPage : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            try
            {
                AddToCartPage add = new AddToCartPage(driver);

                //enter the search item to search
                add.searchItem.SendKeys("Redmi Note 10S");

                //click on search icon
                add.searchIcon.Click();
                System.Threading.Thread.Sleep(8000);

                //click the desired product
                add.product.Click();
                logger.Error("Product not found");
                System.Threading.Thread.Sleep(8000);

                //click add to cart btton to added items into cart
                add.addtocartbtn.Click();
                logger.Info("Added to cart successfully");
                System.Threading.Thread.Sleep(8000);

                //click cart button
                add.cartbtn.Click();
                System.Threading.Thread.Sleep(10000);

                //click proceed to buy button
                add.proceedtobtn.Click();
                logger.Info(" Items are proceed to buy ");
                logger.Error("Field not found");
                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
                System.Threading.Thread.Sleep(4000);

                //enter the email address 
                add.email.SendKeys("sona16061999@gmail.com");

                //click continue button
                add.continuebtn.Click();

                //enter the password
                add.password.SendKeys("Takeiteasy12#");

                //click on loginbutton
                add.signbtn.Click();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }

    }
}
