using System;

namespace ram
{
    class Program
    {
        static void Main(string[] args)
        {
        
                int a, b, max;
                Console.WriteLine("enter a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b=");
                b = Convert.ToInt32(Console.ReadLine());
               max = (a > b) ? a : b;
            Console.WriteLine("max={0} between {1}&{2}", max, a, b);
        }
    }
}
