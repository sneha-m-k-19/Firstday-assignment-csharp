using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to check whether a given number is positive or negative
namespace Firstday_assignment
{
    internal class qstn5
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter the number 1 :");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine(n1 + " is Positive");
            }
            else
            {
                Console.WriteLine(n1 + " is negetive");
            }
            Console.ReadLine();
        }
    }
}
