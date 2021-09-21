using AutomateAmazonApp.AddAddress;
using System;

namespace AutomateAmazonApp.Pages.AddAddressPage
{
    public class AddressActionClass : Base.Baseclass
    {
        public static void CheckInputFields()
        {
            try
            {
                AddressPage address = new AddressPage(driver);
                address.hamBurgerMenu.Click();
                System.Threading.Thread.Sleep(8000);

                address.myAcc.Click();

                address.yourAddress.Click();

                address.email.SendKeys("sona16061999@gmail.com");

                address.continuebtn.Click();

                address.password.SendKeys("Takeiteasy12#");

                address.signbtn.Click();

                address.newAddress.Click();

                address.fullName.SendKeys("Santhosh");

                address.mobNum.SendKeys("9876873341");

                address.postalCode.SendKeys("626101");

                address.addressLine1.SendKeys("46,Chokaalinga nagar");

                address.addressLine2.SendKeys("Madurai");

                address.townOrcity.SendKeys("Madurai");

                address.State.SelectByText("TAMIL NADU");

                address.State.SelectByText("Home (7 am – 9 pm delivery)");

                address.addAddressbtn.Click();


            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
       
    }
}
