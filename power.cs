using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class power
    {
        public static void two()
        {
            int a, b;
            double pnum = 1;
            Console.Write("Enter the value of A :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B :");
            b = Convert.ToInt32(Console.ReadLine());
            for(int i =0 ;i<32 ; i++)
            {
                pnum = pnum * a;
                Console.WriteLine();
            }
            Console.WriteLine("power:", a, b, pnum);
            Console.ReadKey();
        }
    }
}
