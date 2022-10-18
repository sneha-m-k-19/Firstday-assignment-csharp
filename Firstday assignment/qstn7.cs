using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to read rollni,name and marks of three subjects and calculate the total,percentage
namespace Firstday_assignment
{
    internal class qstn7
    {
        static void Main(string[] args)
        {
            int rollNo, m1, m2, m3, per, total;
            string name;
            Console.WriteLine("Enter the roll No:");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the 3 mark:");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
            per = (total * 100) / 300;
            Console.WriteLine("Total :" + total + "\nPercentage :" + per);
            Console.ReadLine();
        }
    }
}
