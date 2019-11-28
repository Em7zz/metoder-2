using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 upphöjt till 7: " + Power(10, 7));
            Console.WriteLine("2 upphöjt till 10: " + Power(2, 10));

        }
        private static float Power(float a, int b)
        {
            float w = a;
            for (int i = 1; i < b; i++)
            {
                w = a * w;

            }
            return w;
        }


    }
}
