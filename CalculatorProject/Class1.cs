using System;

namespace MetLife.CalculatorProject123
{
    public class CalculatorDemo
    {
        public static void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

        public static void add(double a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void add(int a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine(a *b);
        }
    }
}
