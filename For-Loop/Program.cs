﻿using System;

namespace Forloop

{
    class program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Number :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}