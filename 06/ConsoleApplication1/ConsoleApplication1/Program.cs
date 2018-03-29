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
            Console.WriteLine("Введите координаты x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y");
            int y = int.Parse(Console.ReadLine());
            if (x > 4)
            {
                Console.WriteLine("Точка попала в 2 область");
            }
            else
            {
                Console.WriteLine("Точка попала в 1 область");
            }
            Console.ReadLine();
            


        }
    }
}
