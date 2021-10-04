using NUnit.Framework;

namespace AutomateAmazonApp.NegativeTestCases
{
    public class NegativeLoginAction:Base.Baseclass
    {
        public static void CheckInputFieldsWithInvalidData()
        {
            NegativeLoginPage nlogin = new NegativeLoginPage(driver);

            nlogin.signIn.Click();

            nlogin.email.SendKeys("sona16061999@gmail.com");

            nlogin.continuebtn.Click();

            nlogin.password.SendKeys("jhskjhd56");

            nlogin.signbtn.Click();

            Assert.True(nlogin.invalid.Displayed);
        }
    }
}
