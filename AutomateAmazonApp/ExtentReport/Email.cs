/*
 * Project:Amazon Application-Selenium WebDriver
 * Author:Sona G
 * Date :15/09/2021
 */
using Microsoft.VisualBasic.FileIO;
using System;
using System.Net;
using System.Net.Mail;
namespace AutomateAmazonApp.ExtentReport
{
    public class Email
    {
        public static void UserData(string emailfilePath, string dataHeader)
        {
            using (TextFieldParser csvParser = new TextFieldParser(emailfilePath))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    using (MailMessage mail = new MailMessage())
                    {
                        try
                        {
                            //Add sender mail id
                            mail.From = new MailAddress(fields[0]);
                            //To recepiant mail id
                            mail.To.Add(fields[1]);
                            mail.Subject = "Amazon Automation Report";
                            mail.Body = "Kindly find the attachment below";
                            mail.IsBodyHtml = true;
                            //Add the report attachment
                            mail.Attachments.Add(new Attachment(@"C:\Users\sona.g\source\repos\FBDatadriven\FBDatadriven\ExtendReport\index.html"));

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                //sending credentials to network
                                smtp.Credentials = new NetworkCredential(fields[0], fields[2]);
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

            }
        }
    }
}
