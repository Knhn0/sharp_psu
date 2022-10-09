using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace ForthTask
{
    class Names
    {
        private string name { get; set; }
        private string surname { get; set; }

        public void People(string name)
        {
            Console.WriteLine($"Имя: {this.name = name}");
        }

        public void People(string name, string surname)
        {
            Console.WriteLine($"Имя: {this.name = name} Фамилия: {this.surname = surname}");
        }
    }

    public class ForthTaskC
    {
    }
}