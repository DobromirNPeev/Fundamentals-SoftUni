﻿using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            double area = a * b;
            Console.WriteLine($"{area:f2}");
        }
    }
}
