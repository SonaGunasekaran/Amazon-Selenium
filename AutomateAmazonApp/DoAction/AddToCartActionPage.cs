/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.Pages;
using NUnit.Framework;
using System;

namespace AutomateAmazonApp.DoAction
{
    public class AddToCartActionPage : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            try
            {
                string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Filecsv.csv";

                DoActions.CheckEmailAndPassword(csvFilePath, "Email,Password");

                AddToCartPage cart = new AddToCartPage(driver);

                cart.searchItem.SendKeys("Sony Digital Vlog Camera ZV-1 Only");

                //click on search icon
                cart.searchIcon.Click();
                System.Threading.Thread.Sleep(2000);

                //click the desired product
                cart.product.Click();
                logger.Error("Product not found");
                System.Threading.Thread.Sleep(10000);

                //click add to cart btton to added items into cart
                cart.addtocartbtn.Click();
                logger.Info("Added to cart successfully");
                System.Threading.Thread.Sleep(8000);

                string expected = "Added to Cart";
                string actual = cart.addedCart.Text;
                Assert.AreEqual(actual, expected);
            
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }

    }
}
