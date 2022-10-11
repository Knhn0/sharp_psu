using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace SecondTask1
{
    public class Department
    {
        private string nameOfDep;
        private readonly int numberOfDep;
        private Employee lead;

        public List<Employee> Employees { get; set; }

        public Department(string nameOfDep, Employee lead, int numberOfDep)
        {
            this.nameOfDep = nameOfDep;
            this.numberOfDep = numberOfDep;
            this.lead = lead;
            Employees = new List<Employee>() { lead };
        }
        
        public string NameOfDep
        {
            get { return nameOfDep; }
            set { nameOfDep = value; }
        }

        public int NumberOdDep
        {
            get { return numberOfDep; }
        }
    }
}