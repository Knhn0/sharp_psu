using System;

namespace ThirdTask { 
    class Programm
    {
        static void Main(string[] args)
        {
            Car first = new Car();
            first.Shell = new Shell();
            first.FirstEngine = new FirstEngine();
            int res = first.CarWeight / first.FirstEngine.Power;
            if (res > 0)
            {
                Console.WriteLine("Поехали");
                first.FirstEngine.Start();
                
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }

        }
    }
}
