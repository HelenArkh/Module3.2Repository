﻿using System;

namespace Module32
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Helen";
            
            Console.WriteLine(myName);

            Console.WriteLine("\t Привет, мир!");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n Helen");
            Console.WriteLine("\x23");

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(5);
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            Form.Questionnaire();

            Console.ReadKey();
        }
    }
}
