using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program in c# to display the n terms of odd natural numbers and their sum
namespace Firstday_assignment
{
    internal class qstn7a
    {
        static void Main(string[] args)
        {
            int n1, count = 0, n2 = 0;
            Console.WriteLine("Enter the number of odd numbers you want :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " odd numbers ");
            for (int i = 1; i < 100; i++)
            {
                if (count < n1)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                        n2 = n2 + i;
                        count++;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("sum of first " + n1 + " odd numbers :" + n2);
            Console.ReadLine();
        }
    }
}
