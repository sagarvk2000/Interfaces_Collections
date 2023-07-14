using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Collections
{
    public class Employee
    {
        public string name { get; set; }

        public double salary { get; set; }
    }
    public class RunsComparison : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.salary < y.salary)
            {
                return -1;
            }
            else if (x.salary > y.salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

}
