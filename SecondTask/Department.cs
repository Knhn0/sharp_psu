using System.Security.Principal;

namespace SecondTask1
{
    public class Department
    {
        private string nameOfDep;
        private int numberOfDep;
        private string nameOfLead;

        public List<Employee> employees { get; set; }

        public Employee PrintName()
        {
            return employees;
        }
        public string NameOfDep
        {
            get { return nameOfDep; }
            set { nameOfDep = value; }
        }
    }
}