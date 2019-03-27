using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Alex", Age = 29 };

            person1.PropertyChanged += new ConsoleSender().PrintMessage;
            person1.Name = "Sapaaaaaaaaar";
            person1.Age = 500;

            Console.WriteLine($"{ person1.Name }  and {person1.Age}");

            Console.ReadLine();
        }
    }
}
