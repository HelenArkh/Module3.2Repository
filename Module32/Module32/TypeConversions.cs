using System;
using System.Collections.Generic;
using System.Text;

namespace Module32
{
    class TypeConversions
    {
        public static void Conversions()
        {
            int oldData = 6;
            string data = oldData.ToString();

            Console.WriteLine(data);

            Console.WriteLine("Enter your name:");
            
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age:");
            
            var age = int.Parse(Console.ReadLine());

           // int intage = age;

          //  bool isCorrect = int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.WriteLine("What is your favourite day of week?");
            
            var day = (DayOfWeek)int.Parse(Console.ReadLine());

            Console.WriteLine("Your favorite day is {0}", day);

            var howITall = 162;
            var myShoe = 37.5;

            Console.WriteLine("What is my grouth? {0} sm", howITall);
            Console.WriteLine("What is my shoe size? {0}", myShoe);

            Console.ReadKey();
        }
    }
}
