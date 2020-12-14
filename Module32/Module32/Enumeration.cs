using System;
using System.Collections.Generic;
using System.Text;

namespace Module32
{
    class Enumeration
    {
        public static void MyFavoriteDayOfWeek()
        {
            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);
        }
    }

    enum DaysOfWeek : byte
    {
        Tuesday,
        Monday,
        Wednesday,
        Friday
    }
}
