using System;

namespace MethodOverloading_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 10;
            //Add(x, y);
           

            //decimal value1 = 1.50m;
            //decimal value2 = 2.75m;
            //Add(value1, value2);

            //int c = 0;
            //int d = 2;
            //Add(c, d, true);

            var answer = Add(0, 2, true);
            Console.WriteLine(answer);
        }
        public static int Add(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
            
        }
        public static decimal Add(decimal x, decimal y)
        {
            Console.WriteLine(x + y);
            return x + y;
            
        }
        public static string Add(int c, int d, bool isDollars)
        {
            if (isDollars  && c + d != 1)
            {
                return $"{c + d} dollars";
            }
            else if (isDollars && c + d == 1)
            {
                return $"{c + d} dollar";
            }
            else
            {
                return c + d.ToString();
            }
        }

    }
}
