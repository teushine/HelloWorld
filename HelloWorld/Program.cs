﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
