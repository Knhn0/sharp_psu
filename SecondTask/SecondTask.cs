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
            Department depart1 = new Department(alex.NameOfDep, alex, 1);

            alex.FirstName = "Alex";
            alex.LastName = "Volkov";
            alex.Age = 34;
            alex.Id = "01";
            //Employee.Print(alex);
            alex.dep = depart1;
            alex.NameOfDep = "first";
            depart1.Employees.Add(alex);

            Employee denis = new Employee();
            denis.FirstName = "Denis";
            denis.LastName = "Strtov";
            denis.Age = 23;
            denis.Id = "02";
            denis.NameOfDep = "second";
            denis.dep = depart1;
            depart1.Employees.Add(denis);

            Dictionary<string, Employee> people = new Dictionary<string, Employee>();

            foreach (var item in depart1.Employees)
            {
                people.Add(depart1.NameOfDep, item);
            }
            var sortedDict = people.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }   
    }
}