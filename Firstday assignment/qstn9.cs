﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to print a inverted pattern
namespace Firstday_assignment
{
    internal class qstn9
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
