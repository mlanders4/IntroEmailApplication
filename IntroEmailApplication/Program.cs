using MailKit.Net.Smtp;
using MimeKit;

namespace ConsoleEmailApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the command line email client!");

            var loop = true;

            while (loop)
            {
                Console.WriteLine();
                Console.WriteLine("New Message");

                var mail = new MimeMessage();

                mail.From.Add(new MailboxAddress("Jared Hoyt", "jaredhoyt@gmail.com")); // TODO: update to your own name and email address

                Console.Write("To: ");
                mail.To.Add(new MailboxAddress("", Console.ReadLine()));

                Console.Write("Subject: ");
                mail.Subject = Console.ReadLine();

                Console.Write("Body: ");
                mail.Body = new TextPart("plain") { Text = Console.ReadLine() };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("jaredhoyt", "abcdefghijklmnop"); // TODO: update to your own username and APP PASSWORD (this is different from your normal password)
                    client.Send(mail);
                    client.Disconnect(true);

                    Console.WriteLine("Message sent succesfully!");
                }

                Console.Write("\nWould you like to send another email? (Y/N): ");

                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    loop = false;
                }
            }
        }
    }
}