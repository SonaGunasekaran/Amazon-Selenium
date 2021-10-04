/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using AutomateAmazonApp.Pages;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomateAmazonApp.DoAction
{
    public class DoActions : Base.Baseclass
    {
        //Used to check title given and retived are same

        public static void TitleAfterLaunching()
        {
            string title1 = "Online Shopping site in India: Shop Online for Mobiles, Books, Watches, Shoes and More - Amazon.in";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void CreateAmazonAccount(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                //Skip the row with the column names
                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {

                        SignupPage signup = new SignupPage(driver);

                        //click on sign-in button
                        signup.signIn.Click();

                        //click on create account button
                        signup.createAccount.Click();

                        string expected = "Create Account";
                        string actual = signup.createAccDisplay.Text;
                        Assert.AreEqual(expected, actual);
                        System.Threading.Thread.Sleep(4000);

                        //Passing fullname through sendkeys
                        signup.name.SendKeys(column[0]);

                        //Passing mobile number through sendkeys
                        signup.mobNumber.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(4000);

                        //Passing email id through sendkeys
                        signup.email.SendKeys(column[2]);

                        //Passing the password through sendkeys
                        signup.password.SendKeys(column[3]);

                        //continue
                        signup.continuebtn.Click();
                        logger.Info("New account created successfully");
                        Takescreenshot();
                        System.Threading.Thread.Sleep(2000);

                        Assert.AreEqual(driver.Url, "https://www.amazon.in/ap/register");
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }
            }
        }


        public static void LoginIntoAamzon(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {
                        LoginPage login = new LoginPage(driver);

                        // click on sign-in button
                        login.signIn.Click();

                        string actual = "Sign-In";
                        string expected = login.signInTitle.Text;
                        Assert.AreEqual(actual, expected);
                        //enter the email
                        login.email.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //click on continue button
                        login.continuebtn.Click();
                        System.Threading.Thread.Sleep(500);

                        //enter the password 
                        login.password.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //click on loginbutton
                        login.signbtn.Click();
                        logger.Info("Logged Suucessfully");
                        System.Threading.Thread.Sleep(500);

                        string expectedUrl = "https://www.amazon.in/?ref_=nav_ya_signin&";
                        Assert.AreEqual(driver.Url, expectedUrl);
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }
            }

        }

        public static void ForgetPassword()
        {
            LoginPage flogin = new LoginPage(driver);

            //Click on signin button
            flogin.signIn.Click();

            //Passing email id through sendkeys
            flogin.email.SendKeys("sona16061999@gmail.com");

            //click on continue button
            flogin.continuebtn.Click();

            //Click on forget password link
            flogin.forgetPass.Click();
            System.Threading.Thread.Sleep(500);

            //click on continue button
            flogin.contbtn.Click();
        }

        public static void CheckProduct()
        {
            try
            {
                string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Filecsv.csv";

                LoginIntoAamzon(csvFilePath, "Email,Password");

                ProductPage product = new ProductPage(driver);

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

                if (product.addressTitle.Displayed)
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

        public static void CheckInputFields()
        {
            try
            {
                string csvFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Filecsv.csv";

                LoginIntoAamzon(csvFilePath, "Email,Password");

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

        public static void AddAddressIntoAmzon(string csvFilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(csvFilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] column = csvParser.ReadFields();
                    try
                    {
                        CheckProduct();

                        //checking the address title
                        string title1 = "Enter the delivery address for this order";
                        string title = driver.Title;
                        Assert.AreEqual(title1, title);

                        AddressPage add = new AddressPage(driver);

                        //validation
                        string actual = add.newAddress.Text;
                        string expected = "Add a new address";
                        Assert.AreEqual(actual, expected);

                        //enter the full name
                        add.fullName.SendKeys(column[0]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the mob number
                        add.mobNum.SendKeys(column[1]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the postal code
                        add.postalCode.SendKeys(column[2]);
                        System.Threading.Thread.Sleep(500);

                        //Enter the Address line one
                        add.addressLine1.SendKeys(column[3]);
                        System.Threading.Thread.Sleep(1000);

                        //Enter Address line two
                        add.addressLine2.SendKeys(column[4]);
                        System.Threading.Thread.Sleep(300);

                        ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,1500)");
                        System.Threading.Thread.Sleep(1000);

                        //Select the respective state
                        SelectElement state = new SelectElement(driver.FindElement(By.Name("address-ui-widgets-enterAddressStateOrRegion")));
                        state.SelectByValue("TAMIL NADU");
                        System.Threading.Thread.Sleep(6000);

                        //Click on Add Address
                        add.addressbtn.Click();

                        System.Threading.Thread.Sleep(6000);

                        if (add.paymentDisplay.Displayed)
                        {
                            Console.WriteLine("Address added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add address");
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }

            }
        }

        public static void CheckForPayment()
        {
            string addressFilePath = @"C:\Users\sona.g\source\repos\AutomateAmazonApp\AutomateAmazonApp\FileCSV\Address.csv";

            try
            {
                AddAddressIntoAmzon(addressFilePath,
                                                 "Full name,Mobile number,Pin code,Address line1,Address line2,Town/City");

                string title1 = "Select a Payment Method - Amazon.in Checkout";
                string title = driver.Title;
                Assert.AreEqual(title1, title);

                PaymentPage pay = new PaymentPage(driver);

                System.Threading.Thread.Sleep(6000);
                //Click on choose bank option
                pay.bankOption.Click();

                //Click on desired bank
                pay.bank1.SendKeys(Keys.ArrowDown);
                pay.bank1.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(2000);

                //click on continue button
                pay.contbtn.Click();

                //Validate whether it is redirect to next page 
                System.Threading.Thread.Sleep(5000);

                if (pay.reviewDisplay.Displayed)
                {
                    Console.WriteLine("payment succesfully selected");
                }
                else
                {
                    Console.WriteLine("Failed to select payment");
                }
                System.Threading.Thread.Sleep(8000);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }
    }
}

