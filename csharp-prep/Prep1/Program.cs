using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First Name?");
        string user_first_name=Console.ReadLine();
        Console.WriteLine("What is Your Last Name?");
        string user_last_name=Console.ReadLine();
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine($"{user_last_name}, {user_first_name} {user_last_name}");
    }
}

