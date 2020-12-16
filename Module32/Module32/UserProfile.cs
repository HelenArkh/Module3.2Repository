using System;
using System.Collections.Generic;
using System.Text;

namespace Module32
{
    class UserProfile
    {
        public static void Questionnaire()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();

            Console.WriteLine("Your birthdate is {0}", birthdate);

        }
    }
}
