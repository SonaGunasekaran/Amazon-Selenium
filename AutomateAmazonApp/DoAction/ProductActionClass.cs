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
    public class ProductActionClass : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            try
            {
                string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Filecsv.csv";

                DoActions.CheckEmailAndPassword(csvFilePath, "Email,Password");

                ProductPage product= new ProductPage(driver);

                //enter the search item to search
                product.searchItem.SendKeys("Sony Digital Vlog Camera ZV-1 Only");

                //click on search icon
                product.searchIcon.Click();
                System.Threading.Thread.Sleep(2000);

                //click the desired product
                product.product.Click();
                logger.Error("Product not found");
                System.Threading.Thread.Sleep(10000);

                Assert.IsTrue(product.productTitle.Displayed);
                
                //click on buy now button
                product.buyNowbtn.Click();
                logger.Error("field not found");
                Takescreenshot();
                System.Threading.Thread.Sleep(2000);

                if(product.addressTitle.Displayed)
                {
                    Console.WriteLine("Product is available");
                }
                else
                {
                    Console.WriteLine("Product is not available");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
