using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            int average;
            int count = 0;
            int total = 0;

            while (entry != 999)
            {
                Console.WriteLine("Enter a test score >> ");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                count++;
            }
            average = total / count;
            Console.WriteLine(average);
        }
    }
}
