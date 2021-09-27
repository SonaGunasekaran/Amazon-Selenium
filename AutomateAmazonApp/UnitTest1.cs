/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using NUnit.Framework;
using NUnit.Framework.Internal;


namespace AutomateAmazonApp
{
    public class Tests : Base.Baseclass
    {
        string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Filecsv.csv";
        string emailCsvPath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Emailfile.csv";

        //[Test, Order(1)]
        //public void TestLoginPage()
        //{
        //    Pages.LoginPage.DoActions.CheckEmailAndPassword(csvFilePath,
        //                                             "Email,Password");

        //}

        //[Test, Order(2)]
        //public void TestSignupPage()
        //{
        //    Pages.NewUser.SignupActionCass.CheckInputFields();
        //}

        //[Test, Order(3)]
        //public void TestSearchActionAndBuyNowAction()
        //{
        //    Pages.BuyNow.SearchActionClass.CheckInputFields();
        //}

        //[Test, Order(4)]
        //public void TestAddToCart()
        //{
        //    Pages.AddToCart.AddToCartActionPage.CheckInputFields();
        //}

        [Test, Order(5)]
        public void TestAddAddress()
        {
            Pages.AddAddressPage.AddressActionClass.CheckInputFields();
        }

        //[Test, Order(6)]
        //public void TestProductAndRating()
        //{
        //    Pages.SearchProduct.ProductAndRatingAction.GetProductAndRating();
        //}

        //[Test, Order(7)]
        //public void TestForgetPassword()
        //{
        //    Pages.LoginPage.ForgetPasswordAction.CheckInputFields();
        //}
        //[Test]
        //public void TestMethodForEmailSending()
        //{
        //    ExtentReport.Email.UserData(emailCsvPath, "From,To,Password");
        //}

    }
}