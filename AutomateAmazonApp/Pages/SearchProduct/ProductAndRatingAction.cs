﻿/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :23/09/2021
 */
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace AutomateAmazonApp.Pages.SearchProduct
{
    public class ProductAndRatingAction : Base.Baseclass
    {
        public static void GetProductAndRating()
        {
            IWebElement search = driver.FindElement(By.Id("twotabsearchtextbox"));
            //enter the search item to search
            search.SendKeys("women boots");

            //click on search icon
            IWebElement searchIcon = driver.FindElement(By.Id("nav-search-submit-button"));
            searchIcon.Click();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("*****************Product Name**********************");

            IList<string> productName = new List<string>();
            foreach (var name in driver.FindElements(By.XPath("//*[@class='a-size-base-plus a-color-base']")))
            {
                if (!string.IsNullOrEmpty(name.Text))
                {
                    productName.Add(name.Text);

                    Console.WriteLine("Product Name {0}", name.Text);
                }
                else
                {
                    productName.Remove(name.Text);

                }
            }

            Console.WriteLine("*****************Product Price**********************");

            IList<string> productPrice = new List<string>();
            foreach (var price in driver.FindElements(By.XPath("//*[@class='a-price-whole']")))
            {
                if (!string.IsNullOrEmpty(price.Text))
                {
                    productPrice.Add(price.Text);
                    Console.WriteLine("Product Price {0}", price.Text);
                }
                else
                {
                    productPrice.Remove(price.Text);
                }
            }

            Console.WriteLine("*****************Product Rating**********************");

            IList<string> productRating = new List<string>();
            foreach (var r in driver.FindElements(By.XPath("//*[@class='a-popover-trigger a-declarative']")))
            {
                r.Click();
                System.Threading.Thread.Sleep(5000);
                foreach (var rating in driver.FindElements(By.CssSelector("span[class='a-size-medium a-color-base a-text-beside-button a-text-bold']")))
                {
                    if (!string.IsNullOrEmpty(rating.Text))
                    {
                        productRating.Add(rating.Text);
                        Console.WriteLine("Product Rating {0}", rating.Text);
                    }
                    else
                    {
                        productRating.Remove(rating.Text);
                    }
                }
            }
        }
    }
}