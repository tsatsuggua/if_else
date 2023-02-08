using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace homeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();

            if (login == "USER")
            {
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                if (password == "123")
                {
                    Console.WriteLine("Hello User");
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

                if (password == "321")
                {
                    Console.WriteLine("Hello Administrator");
                }
                else
                {
                    Console.WriteLine("Password is not correct");
                }
            }
            else if (login == "")
            {
                Console.WriteLine("Hello anonimus");
            }


            Console.ReadKey();
        }
    }
}