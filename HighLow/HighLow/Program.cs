using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int entry;
            int guesses = 0;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Pick a number between 1 and 10.");
                entry = Convert.ToInt32(Console.ReadLine());
                if (entry > r)
                {
                    Console.WriteLine("Too high");
                }
                else if (entry < r)
                {
                    Console.WriteLine("Too low");
                }
                else if (entry == r)
                {
                    Console.WriteLine("You got it");
                    again = false;
                }
                guesses = guesses + 1;
                if (guesses == 6)
                {
                    Console.WriteLine("You ran out of guesses = " + guesses + "\n answer was " + r);
                    again = false;
                }
            }
        }
    }
}
