using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace IntroEmailApplication
{
    internal class Program
    {
        private const int SmtpPort = 465; // SMTP port for secure email sending
        private const bool IsSslConnection = true; // Enable SSL for security

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the command line email client!");

            bool userWantsToSendMessage = true;

            while (userWantsToSendMessage)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("New Message");

                    var mail = new MimeMessage();

                    // Update sender information
                    mail.From.Add(new MailboxAddress("Matthew Landers", "matthewlanders0429@gmail.com"));

                    Console.Write("To: ");
                    mail.To.Add(new MailboxAddress("", Console.ReadLine()));

                    Console.Write("Subject: ");
                    mail.Subject = Console.ReadLine();

                    Console.Write("Body: ");
                    mail.Body = new TextPart("plain") { Text = Console.ReadLine() };

                    using (var client = new SmtpClient())
                    {
                        try
                        {
                            // Connect to the SMTP server
                            client.Connect("smtp.gmail.com", SmtpPort, IsSslConnection);

                            // Authenticate with your email credentials
                            client.Authenticate("matthewlanders0429", "!QAZ2wsx!QAZ2wsx");

                            // Send the email
                            client.Send(mail);
                            Console.WriteLine("Message sent successfully!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error sending email: " + ex.Message);
                        }
                        finally
                        {
                            client.Disconnect(true); // Ensure client disconnects
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                Console.WriteLine();
                Console.Write("Would you like to send another email? (Y/N): ");

                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    userWantsToSendMessage = false;
                }
            }
        }
    }
}
