/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.AddToCart;

namespace AutomateAmazonApp.AddToCartAction
{
    public class AddToCartActionPage : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            AddToCartPage add = new AddToCartPage(driver);

            //enter the search item to search
            add.searchItem.SendKeys("Redmi Note 10S");

            //click on search icon
            add.searchIcon.Click();

            //click the desired product
            add.product.Click();

            //click add to cart btton to added items into cart
            add.addtocartbtn.Click();
            System.Threading.Thread.Sleep(8000);

            //click cart button
            add.cartbtn.Click();
            System.Threading.Thread.Sleep(10000);

            //click proceed to buy button
            add.proceedtobtn.Click();
            System.Threading.Thread.Sleep(10000);

            //enter the email address 
            add.email.SendKeys("sona16061999@gmail.com");

            //click continue button
            add.continuebtn.Click();

            //enter the password
            add.password.SendKeys("Takeiteasy12#");

            //click on loginbutton
            add.signbtn.Click();

        }

    }
}
