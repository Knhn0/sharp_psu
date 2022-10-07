using System;

namespace FirstTask
{
    class Program
    {
        static void Division(string number)
        {
            try
            {
                int parsedString = int.Parse(number);
                Console.WriteLine($"Частное от деления 100 на число = {100 / parsedString}");
            }
            catch
            {
                Console.WriteLine("Исключение, скорее всего вы ввели не число, или число равное 0");
            }
        }
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Введите число");
            number = Console.ReadLine();
            Division(number);
        }
    }
}