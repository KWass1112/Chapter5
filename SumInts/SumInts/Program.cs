using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            bool again = true;
            int entry = 0;
            
           while (entry != 999)
           {
                Console.WriteLine("Enter a number >> ");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                
           }
            Console.WriteLine(total - 999);
        }
    }
}
