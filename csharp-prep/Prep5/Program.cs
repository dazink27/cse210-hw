using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome Displayed.");
        }
        static string PromptUserName()
        {
            Console.WriteLine(
                "Username:");
            string user_Name=Console.ReadLine();
            Console.WriteLine(
                $"Your Username is {user_Name}");
            return user_Name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine(
                "User Number:");
            string user_input=Console.ReadLine();
            int user_Number=int.Parse(user_input);
            Console.WriteLine(
                $"Your number is {user_Number}");
            return user_Number;
        }
        static int SquareNumber(int number)
        {
            int number_Squared=number*number;
            return number_Squared;
        }
        static void DisplayResult(
            int number,string username)
        {
            Console.WriteLine(
                $"Your number is {number}");
            Console.WriteLine(
                $"and your name is {username}");
        }
        DisplayWelcome();
        string user_Name=PromptUserName();
        int user_Number=PromptUserNumber();
        int user_Number_Squared=SquareNumber(user_Number);
        DisplayResult(user_Number_Squared,user_Name);

    }
    
}