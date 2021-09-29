using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x = -2;
            while(x <= 2)
            {
                y = -2.4 * x * x + 5 * x - 3;
                Console.WriteLine("x = " + x + " y = " + y);
                x += 0.5;
            }
            
        }
    }
}
