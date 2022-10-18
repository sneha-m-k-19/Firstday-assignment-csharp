using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to accept two integers and check whether they are equal or not
namespace Firstday_assignment
{
    internal class qstn6
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter the number 1 :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2 :");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine(n1 + " and " + n2 + " are equal");
            }
            else
            {
                Console.WriteLine(n1 + " and " + n2 + " are not equal");
            }
            Console.ReadLine();
        }
    }
}
