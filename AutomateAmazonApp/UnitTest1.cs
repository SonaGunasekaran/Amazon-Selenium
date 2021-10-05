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
        string signupFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Signup.csv";
        string addressFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Address.csv";
        string negativeFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\NegativeLogin.csv";
        string negativeSignupPath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\NegativeSignup.csv";
       
        [Test, Order(1)]
        public void TestSignupPage()
        {
            DoAction.DoActions.CreateAmazonAccount(signupFilePath,
                                                        "Your name,Mobile Number,Email,Password");
        }
        [Test, Order(2)]

        public void TestLoginPage()
        {

            DoAction.DoActions.LoginIntoAamzon(csvFilePath,
                                                     "Email,Password");
            DoAction.DoActions.TitleAfterLaunching();

        }

        [Test, Order(3)]
        public void TestBuyNowAction()
        {
            DoAction.DoActions.CheckForBuyNow();
        }

        [Test, Order(4)]
        public void TestAddToCart()
        {
            DoAction.DoActions.CheckAddToCartFields();
        }

        [Test, Order(5)]
        public void TestAddAddress()
        {
            DoAction.DoActions.AddAddressIntoAmzon(addressFilePath,
                                                           "Full name,Mobile number,Pin code,Address line1,Address line2,Town/City");
        }

        [Test, Order(6)]
        public void TestPaymentMethod()
        {
            DoAction.DoActions.CheckForPayment();
        }

        [Test, Order(7)]
        public void TestForgetPassword()
        {
            DoAction.DoActions.ForgetPassword();
        }


        [Test, Order(8)]
        public void TestPlaceOrderPage()
        {
            Pages.PlaceOrderPage.CheckForPayment();
        }

        [Test, Order(9)]
        public void TestMethodForEmailSending()
        {
            ExtentReport.Email.UserData(emailCsvPath, "From,To,Password");
        }

        [Test, Order(10)]
        public void NegativeTestForLoginPage()
        {
            NegativeTestCases.NegativeAction.CheckLoginPageWithInvalidData(negativeFilePath,
                                                     "Email,Password");
        }


        [Test, Order(11)]
        public void NegativeTestForSignupPage()
        {
            NegativeTestCases.NegativeAction.NegativeCreateAmazonAccount(negativeSignupPath,
                                                                             "Your name,Mobile Number,Email,Password");

        }
    }
}