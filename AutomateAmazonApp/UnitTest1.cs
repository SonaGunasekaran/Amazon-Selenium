/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using NUnit.Framework;

namespace AutomateAmazonApp
{
    public class Tests : Base.Baseclass
    {

        [Test]
        public void TestLoginPage()
        {
            DoAction.DoActions.CheckEmailAndPassword();
        }

        [Test]
        public void TestSignupPage()
        {
            ActionSigup.SignupActionCass.CheckInputFields();
        }

        [Test]
        public void TestSearchActionAndBuyNowAction()
        {
            SearchAction.SearchActionClass.CheckInputFields();
        }

        [Test]
        public void TestAddToCart()
        {
            AddToCartAction.AddToCartActionPage.CheckInputFields();
        }
    }
}