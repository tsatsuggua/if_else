using System;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            string value;
            do
            {
                int res;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*,^):");
                string symbol = Console.ReadLine();

                if (symbol == "+")
                {

                    res = num1 + num2;
                    Console.WriteLine(res);
                }
                if (symbol == "-")
                {
                    res = num1 - num2;
                    Console.WriteLine(res); 
                }
                if (symbol == "*")
                {
                    res = num1 * num2;
                    Console.WriteLine(res); 
                }
                if (symbol == "/")
                {

                    if (num2 == 0)
                    {
                        Console.WriteLine("ошибОЧКА");
                    }
                    else
                    {
                        Console.WriteLine(res = num1 / num2);
                    }
                }
                if (symbol == "^")
                {
                    int num_n = 1;
                    for (int i = 0; i < num2; i++)
                    {
                        num_n *= num1;
                    }
                    Console.WriteLine($"{num_n}");
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y");
        }


    }
}