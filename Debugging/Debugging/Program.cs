using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PASS1 = "home";
            const string PASS2 = "lady";
            const string PASS3 = "mouse";
            string password;

            Console.Write("Please enter your password ");
            password = Console.ReadLine();
            while (password != PASS1 || password != PASS2 || password != PASS3)
            {
                Console.WriteLine("Invalid password. Please enter again. ");
            }
            Console.WriteLine("Valid password");
        }
    }
}
