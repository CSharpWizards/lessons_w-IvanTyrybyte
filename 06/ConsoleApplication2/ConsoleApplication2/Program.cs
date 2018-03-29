using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rost");
            int rost = int.Parse(Console.ReadLine());
            Console.WriteLine("Ves");
            int ves = int.Parse(Console.ReadLine());
            if (ves > rost - 100)
            {
                Console.WriteLine("Вам нужно похудеть");
            }
            else
            {
                Console.WriteLine("Вам нужно поправиться");
            }
            Console.ReadLine();
        }
    }
}
