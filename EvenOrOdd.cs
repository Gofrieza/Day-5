using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class EvenOrOdd
    {
        public static void OddOrEven()
        {
            int num1, rem1;
            Console.WriteLine("Check whether a number is even or odd :\n");
            Console.WriteLine("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("Number is an even integer: " +num1);
            else
                Console.WriteLine("Number is an odd integer." +num1);
        }
    }
}
