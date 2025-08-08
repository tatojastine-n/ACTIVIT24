using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAuthenticationLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string validUsername = "admin";
            const string validPassword = "1234";
            bool isAuthenticated = false;

            while (!isAuthenticated)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (username == validUsername && password == validPassword)
                {
                    isAuthenticated = true;
                    Console.WriteLine("\nLogin successful!\n");
                }
                else
                {
                    Console.WriteLine("\nTry again. Incorrect credentials.\n");
                }
            }

        }
    }
}
