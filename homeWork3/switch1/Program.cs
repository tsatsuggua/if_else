namespace switch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();

            switch (login)
            {
                case "USER": Console.WriteLine("Enter your password");
                    string password = Console.ReadLine();
                    if(password=="123")
                    {
                        Console.WriteLine("Hello user");
                    }
                    else
                    { 
                        Console.WriteLine("Password is not correct");
                    }
                    break;
                case "": Console.WriteLine("Hello anonimus");
                    break;
            }
            switch (login)
            {
                case "ADMIN":
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
                    break;
            }

            Console.ReadKey();

        }
    }
}