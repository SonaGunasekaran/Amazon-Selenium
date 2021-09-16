/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.Search;

namespace AutomateAmazonApp.SearchAction
{
    public class SearchActionClass : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            SearchItem search = new SearchItem(driver);

            //enter the search item to search
            search.searchItem.SendKeys("Redmi Note 10S");

            //click on search icon
            search.searchIcon.Click();
            System.Threading.Thread.Sleep(2000);

            //click the desired product
            search.product.Click();
            System.Threading.Thread.Sleep(2000);

            //click on buy now button
            search.buyNowbtn.Click();
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
    }
}
