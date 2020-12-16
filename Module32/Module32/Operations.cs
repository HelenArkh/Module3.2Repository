using System;
using System.Collections.Generic;
using System.Text;

namespace Module32
{
    class Operations
    {
        public static void MainOperations()
        {
            double result1 = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result1);

            double result2 = 5.0 % 2.0;
            Console.WriteLine("5 % 2 = {0}", result2);

            int counter = 10;
            Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);
            Console.WriteLine("Value: {0} Increment: {1}", counter, counter++);

            double result3 = 10.0 * 2.0 / 5.0;
            Console.WriteLine("Value: {0}", result3);

            double result4 = 10 % 3;
            Console.WriteLine("Value: {0}", result4);
        }
    }
}
