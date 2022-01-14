using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class swap
    {
        public static void newSwap()
        {
            int number1, number2, temp;
            Console.WriteLine("Input the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " +number1);
            Console.WriteLine("Second Number : " +number2);
            Console.Read();
        }
    }
}

