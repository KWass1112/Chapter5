using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string D, E, F;
            int totalD = 0, totalE = 0, totalF = 0;
            int total;
            string entry;
            int salesEntry = 0;

            Console.WriteLine("Enter a initial");
            entry = Console.ReadLine();
            if (entry == "D")
            {
                Console.WriteLine("Enter sales");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalD = totalD + salesEntry;
            }
            Console.WriteLine("You total is " + totalD);

            Console.WriteLine("Enter a initial");
            entry = Console.ReadLine();

            if (entry == "E")
            {
                Console.WriteLine("Enter sales");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalE = totalE + salesEntry;
            }
            Console.WriteLine("You total is " + totalE);

            Console.WriteLine("Enter a initial");
            entry = Console.ReadLine();

            if (entry == "F")
            {
                Console.WriteLine("Enter sales");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalF = totalF + salesEntry;
            }
            Console.WriteLine("You total is " + totalF);
            while (entry != "Z")
            {
                Console.WriteLine("Enter a initial");
                entry = Console.ReadLine();
            }
        }
    }
}
