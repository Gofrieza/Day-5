﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class flip
    {
        public static void coinflip()
        {
            Console.WriteLine("Let's flip a coin 10000 times");
            Coinflip();
        }
        private static int Coinflip()
        {
            Random Rand = new Random();
            int heads = 0;
            int tails = 0;
            int result = 0;
            for (int i = 0; i < 10000; i++)
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("heads was flipped times", +heads);
            Console.WriteLine("tails was flipped times", +tails);
            return result;
        }
    }
}