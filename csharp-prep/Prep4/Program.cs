using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>user_Numbers=new List<int>();
        bool user_Response=true;
        do
        {
            Console.WriteLine(
                "Please give me a number...");
                string user_Input=Console.ReadLine();
                int user_Number=int.Parse(user_Input);
                user_Numbers.Add(user_Number);
                
                Console.WriteLine(
                    "Shall We Continue?");
                Console.WriteLine(
                    "Please type \"yes\" or \"no\"");
                user_Input=Console.ReadLine();
                if (user_Input=="yes"){}
                else if (user_Input=="no")
                {
                    user_Response=false;
                }
                else{}
        } while(user_Response==true);

        int user_Total=user_Numbers.Sum();
        double user_Average=user_Numbers.Average();
        int user_Max=user_Numbers.Max();
        Console.WriteLine($@" Results::: 
            User Total:{user_Total}
            User Average:{user_Average}
            User Maximum:{user_Max}");
    }
}