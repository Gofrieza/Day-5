using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class factorial
    {
        public static void Fact()
        {
            int i, f = 1, num;
            Console.WriteLine("Calculate the factorial of a given number: ");
            Console.WriteLine("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.WriteLine("The Factorial of entered number is: " +f);
        }
    }
}
