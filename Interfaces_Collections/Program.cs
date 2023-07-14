using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {//IEnumrator
            //Team india = new Team();

            //foreach (Player p in india)
            //{
            //    Console.WriteLine(p);
            //}

            // Using IComparable
            //Product p1 = new Product(2000, "mouse");
            //Product p2 = new Product(4000, "keyboard");

            //int res = p1.CompareTo(p2);

            //if(res < 0)
            //{
            //    Console.WriteLine("keybaord is less costly than keyboard");
            //}
            //else if(res > 0)
            //{
            //    Console.WriteLine("Keybord is costly than mouse");
            //}
            //else
            //{
            //    Console.WriteLine("has same price");
            //}

            //Using IComparare
            Employee e1 = new Employee { name = "om" ,salary =5000};
            Employee e2 = new Employee { name = "aman",salary = 60000 };

            RunsComparison obj = new RunsComparison();
            int result = obj.Compare(e1, e2);

            if (result < 0)
            {
                Console.WriteLine("om has less salary than aman");
            }
            else if (result > 0)
            {
                Console.WriteLine("om has more salary than aman");
            }
            else
            {
                Console.WriteLine("om & aman has same salary");
            }

        }
    }
}
