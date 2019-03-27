using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class ConsoleSender
    {
        public void PrintMessage(object sender, string args)
        {
            if (args == "Name")
            {
                Console.WriteLine("Поле Name изменено");
            }
            else if (args == "Age")
            {
                Console.WriteLine("Поле Age изменено");
            }

            //Console.ReadLine();
        }
    }
}
