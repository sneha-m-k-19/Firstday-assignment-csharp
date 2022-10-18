using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to to find the largest among three numbers
namespace Firstday_assignment
{
    internal class qstn4
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter the number 1 :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3:");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine(n1 + " is greater");
                }
                else
                {
                    Console.WriteLine(n3 + " is greater ");
                }
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine(n2 + " is greater ");
                }
                else
                {
                    Console.WriteLine(n3 + " is greater ");
                }
            }
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
