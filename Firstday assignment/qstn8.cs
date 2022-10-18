using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to print pattern
namespace Firstday_assignment
{
    internal class qstn8
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int K = 1; K <= 2 * i - 1; K++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
