using System;
using MindBox;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MindboxLib.Circle.square(10));
            Console.WriteLine(MindboxLib.Circle.square(2.4));
            Console.WriteLine(MindboxLib.Triangle.square(5, 12, 13));
            Console.WriteLine(MindboxLib.Triangle.square(3, 3, 5));
            Console.WriteLine(MindboxLib.Triangle.square(3, 0, 5));
        }
    }
}
