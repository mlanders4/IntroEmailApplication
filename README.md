# IntroEmailApplication

In this lab exercise we will learn how to send an email from a C# console application using the MailKit library.

## Table of Contents

- [Windows](#windows)
- [Mac/Windows/Linux](#macwindowslinux)
- [Advanced Exercise (Optional)](#advanced-exercise-optional)

## Windows

1. Download the following:

    - [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
    - [Visual Studio 2022](https://visualstudio.microsoft.com/)

2. Create an "app password" by following the steps listed [here](https://support.google.com/accounts/answer/185833?hl=en). **PLEASE USE A THROW-AWAY ACCOUNT FOR THIS LAB.**

3. Open Visual Studio and select the *Clone a repository* option. Input the URL of this repository (**https://github.com/csce361Github/IntroEmailApplication.git**) and click the *Clone* button.

4. Navigate to `Program.cs` and modify the *name*, *email address*, *username*, and *password* (there are `TODO` comments showing you where to update the code).

5. Run the application by hitting the green, outlined play button (*Start Without Debugging*) or by hitting `Ctrl + F5`. Send an email and ensure that the program works correctly.

    **Note:** if you are getting errors such as "the MailKit package cannot be found in the Microsoft Visual Studio Offline Packages" or something similar, in the menu bar navigate to `Project -> Manage NuGet Packages` and ensure that you have *nuget.org* as a Package Source. If not, click the settings icon to the right of the dropdown, click the green plus button, and add the following package source:

    ```bash
    Name: nuget.org
    Source: https://api.nuget.org/v3/index.json
    ```

    Click *update* and then hit *OK*. This should allow you to now access the *nuget.org* in the Package Source dropdown.

    You should be able to properly run the project, but if you are still missing the MailKit package, you might not have the MailKit package installed and will need to manually install it. Navigate back to the NuGet Package Manager and install MailKit.

6. Add `try-catch` blocks where appropriate.

7. Add meaningful comments to the code.

8. Take some time to hover over the various classes used and get comfortable with Intellisense in Visual Studio. Turn in the `Program.cs` file when you are done.

## Mac/Windows/Linux

1. Download the following:

    - [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
    - [Visual Studio Code](https://code.visualstudio.com/)
        - `C#` extension from Microsoft
        - `Visual NuGet` extension from Full Stack Spider

2. Create an "app password" by following the steps listed [here](https://support.google.com/accounts/answer/185833?hl=en). **PLEASE USE A THROW-AWAY ACCOUNT FOR THIS LAB.**

3. Clone this repository to your local machine and open the project in Visual Studio Code.

4. Navigate to `Program.cs` and modify the *name*, *email address*, *username*, and *password* (there are `TODO` comments showing you where to update the code).

5. Right-click on the `IntroEmailApplication.csproj` file, select *Visual Nuget: Manage Packages*, and install the *MailKit* package.

6. Run the program by opening a terminal instance in the `IntroEmailApplication/IntroEmailApplication` directory and running the following command:

    ```bash
    dotnet run
    ```

    Send an email and ensure that the program works correctly.

7. Add `try-catch` blocks where appropriate.

8. Add meaningful comments to the code.

9. Take some time to hover over the various classes used and get comfortable with Intellisense in Visual Studio Code. Turn in the `Program.cs` file when you are done.

## Advanced Exercise (Optional)

For those of you that are more comfortable with C#, use the basics outlined in this code to create a Windows Forms project. Modify this code to now capture the details from these UI elements and send the email.
