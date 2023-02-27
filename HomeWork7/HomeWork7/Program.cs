using System.Diagnostics.Metrics;
using System.Reflection;

namespace HomeWork7
{
    internal class Program
    {

        static void Recursion(int counter)
        {
            counter--;
            Console.WriteLine($"First part: {counter}");

            if (counter != 0)
                SumTo(counter); 
            Console.WriteLine($"Second part: {counter}");

        }
        static void SumTo(int counter)
        {
            Console.WriteLine($"First part: {counter}");

            Recursion(counter);

            Console.WriteLine($"Second part: {counter}");
        
        
        }

        static void Main()
        {
            SumTo(counter: 5);  
            SumTo(counter: 1);  
            SumTo(counter: 9);  
            SumTo(counter: -8); 

            Console.ReadKey();  
        }
    }
}