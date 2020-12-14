using System;

namespace Module32
{
    public class Form
    {
        public static void Questionnaire()
        {
            string myName = "Jane";
            byte myAge = 27;
            bool haveIAPet = true;
            double myShoeSize = 37.5;

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("My age is " + myAge);
            Console.WriteLine("Do I have a pet? " + haveIAPet);
            Console.WriteLine("My shoe size is " + myShoeSize);

            Console.ReadKey();
        }
    }
}
