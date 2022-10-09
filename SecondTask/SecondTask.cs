using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask1
{
    static class Programm
    {
        static void Main()
        {
            Employee alex = new Employee();
            Department depart1 = new Department();

            alex.FirstName = "Alex";
            alex.LastName = "Volkov";
            alex.Age = 34;
            alex.GetId = "01";
            Employee.Print(alex);
            alex.dep = depart1;
            depart1.Employees.Add(alex);
            Console.WriteLine(depart1.PrintName());
        }
    }
}