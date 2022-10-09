using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask1
{
    public class Employee
    {
        private static string id;
        private static string firstName;
        private static string lastName;
        private static int age;

        public Department dep { get; set; }

        public string GetId
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static void Print(Employee employee)
        {
            Console.WriteLine($"His id: {id}");
            Console.WriteLine($"His Name: {firstName}");
            Console.WriteLine($"His Surname: {lastName}");
            Console.WriteLine($"His age: {age}");
        }
    }
}