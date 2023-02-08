namespace ternarn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string log = "Hello ";

            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();

            log += login == "USER" ? "User" : "Anonimus";

            if (login == "USER")
            {
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                if (password == "123")
                {
                    Console.WriteLine(log);
                }
                else
                {
                    Console.WriteLine("Password is not correct");
                }
            }

            else if (login == "ADMIN")
            {
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                if (password == "123")
                {
                    Console.WriteLine("Hello administrator");
                }
                else
                {
                    Console.WriteLine("Password is not correct");
                }
            }

            else
            {
                Console.WriteLine(log);
            }

            Console.ReadKey();  
        }
    }
}