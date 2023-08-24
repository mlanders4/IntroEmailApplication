# IntroEmailApplication

In this lab exercise we will learn how to send an email from a C# console application with an attachment, using Gmail SMTP. For this, first we will set SMTP details of a Gmail account using the SmtpClient class.

1. Download and install [Visual Studio 2022](https://visualstudio.microsoft.com/) and [Resharper](https://www.jetbrains.com/resharper/download/#section=web-installer). You have a 30 day free Resharper trial, but if you want to use it or other Jetbrains products after that, you can fill out [this form](https://www.jetbrains.com/shop/eform/students/) to receive a student license. To activate Reshaper, first open Visual Studio and run the Resharper executable. Then, close and reopen Visual Studio.

2. Clone this repository to your local machine.

3. Create an "app password" by following the steps listed [here](https://support.google.com/accounts/answer/185833?hl=en). **PLEASE USE A THROW-AWAY ACCOUNT FOR THIS LAB.**

4. Open the solution file, go to `Program.cs`, modify the *name*, *email address*, *username*, and *password* in the code and run the console application (there are `TODO` comments showing you where to update the code).

5. Look at the ReSharper warnings in the right side of the code pane and resolve each one.

6. Add `try-catch` blocks where appropriate.

7. Add meaningful comments to the code.

8. Take some time to hover over the various classes used and get comfortable with Intellisense in Visual Studio. Turn in the `Program.cs` file when you are done.
 
## Advanced Exercise (Optional)

For those of you that are more comfortable with C#, use the basics outlined in this code to create a Windows Forms project. Modify this code to now capture the details from these UI elements and send the email.
