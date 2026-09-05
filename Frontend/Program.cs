using System;
using System.Collections.Generic;
using System.Globalization;
using Backend;

namespace Frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var t1 = new Time();
                var t2 = new Time(14, 0, 0, 0);
                var t3 = new Time(9, 34, 0, 0);
                var t4 = new Time(19, 45, 56, 0);
                var t5 = new Time(23, 3, 45, 678);

                var times = new List<Time> { t1, t2, t3, t4, t5 };

                // Usamos Inversión Cultural para que el formato use comas fijas en lugar de puntos locales
                var culture = CultureInfo.InvariantCulture;

                foreach (var time in times)
                {
                    Console.WriteLine($"Time: {time}");
                    Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds().ToString("N0", culture).PadLeft(15)}");
                    Console.WriteLine($"\tSeconds     : {time.ToSeconds().ToString("N0", culture).PadLeft(15)}");
                    Console.WriteLine($"\tMinutes     : {time.ToMinutes().ToString("N0", culture).PadLeft(15)}");
                    Console.WriteLine($"\tAdd         : {time.Add(t3)}");
                    Console.WriteLine($"\tIs Other day: {time.IsOtherDay(t4)}");
                    Console.WriteLine();
                }

                var t6 = new Time(45, -7, 90, -87);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}