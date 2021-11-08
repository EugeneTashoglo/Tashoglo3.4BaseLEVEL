using System;

namespace Tashoglo3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("|     X     |     Y     |");
                for (double x = 0.1; x <= 3; x += 0.2)
                {
                    double y = x * x + 4 * Math.Sin(Math.PI * x);
                    Console.WriteLine($"|{x:F2}           |{y:F2}|");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
