﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class Largest
    {
        public static void large()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three numbers");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the greatest among three: " +num1);
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest among three: " +num3);
                }
            }
            else if (num2 > num3)
                Console.WriteLine("The 2nd Number is the greatest among three: " +num2);
            else
                Console.WriteLine("The 3rd Number is the greatest among three: " +num3);
        }
    }
}
