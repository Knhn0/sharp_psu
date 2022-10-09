using System;

namespace ForthTask
{
    class Calc
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Произведение = {a * b}");
        }

        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine($"Произведение = {a * b * c}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Multiply(12, 2);
            calc.Multiply(12, 2, 2);

            Names man = new Names();
            man.People("Alex");
            man.People("Alex", "Volkov");

        }
    }
}