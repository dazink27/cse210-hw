using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is your guess?");
        Random randomGenerator=new Random();
        int magic_number=randomGenerator.Next(0,10);


        string user_Input=Console.ReadLine();
        int user_Number=int.Parse(user_Input);

        if (user_Number == magic_number)
        {
            Console.WriteLine(
                "That is the magic number!");
        }
        else
        {
            while (user_Number != magic_number)
            {
                if (magic_number > user_Number)
                {
                    Console.WriteLine(
                        "The Magic Number is Higher!");
                }
                else
                {
                    Console.WriteLine(
                        "The Magic Number is Lower!");
                }
                Console.WriteLine("What is your guess?");
                user_Input=Console.ReadLine();
                user_Number=int.Parse(user_Input);
            }
        Console.WriteLine(
            "Congrats! You have the right number!!");
        }
        
    }
}