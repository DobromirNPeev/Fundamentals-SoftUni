﻿using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.0)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
