using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        Console.WriteLine(
            "Please put in a two, or three, digit number.  EX] 03, 78, 100");
        string user_Input=Console.ReadLine();
        int user_Percentage=int.Parse(user_Input);

        if (user_Percentage > 100)
        {
            Console.WriteLine("Outstanding Performance!");
            Console.WriteLine("Your Grade is an A");
        }
        else
        {
            string user_Grade="";
            
            if (user_Percentage >= 90)
            {
                user_Grade="A";
                //Console.WriteLine("Your Grade is an A");
            }
            else if (user_Percentage >= 80)
            {
                user_Grade="B";
                //Console.WriteLine("Your Grade is a B");
            }
            else if (user_Percentage >= 70)
            {
                user_Grade="C";
                //Console.WriteLine("Your Grade is a C");
            }
            else if (user_Percentage >= 60)
            {
                user_Grade="D";
                //Console.WriteLine("Your Grade is a D");
            }
            else if (user_Percentage <= 60)
            {
                user_Grade="F";
                //Console.WriteLine("Your Grade is a F");
            }
            Console.WriteLine($"{user_Grade}");
            if (user_Percentage >= 70)
            {
                Console.WriteLine(
                    "Congratulations!! You have passed the course!");
            }
            else
            {
                Console.WriteLine(
                    "You did not pass.  You must retake the course.");
            }
        }
    }
}