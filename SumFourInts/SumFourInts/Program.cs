using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int q;

            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Enter a number >> ");
                q = Convert.ToInt16(Console.ReadLine());
                total = total + q;
            }
            Console.WriteLine(total);
        }
    }
}
