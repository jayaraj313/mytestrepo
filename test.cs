using System;
using System.IO;

public class LoginManager
{
    private static string _password;

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your password:");
        _password = Console.ReadLine();

        StreamWriter file = new StreamWriter("passwords.txt", true); 
        file.WriteLine(_password);
        file.Close();
    }
}
