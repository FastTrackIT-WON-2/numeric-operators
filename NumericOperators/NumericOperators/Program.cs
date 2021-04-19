using System;
using System.Globalization;
using System.Threading;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisionForFloat_ReturnsFloat();
        }

        public static void DivisionForIntegers_ReturnsIntegers()
        {
            int a = 3;
            int b = 2;

            int c = (a / b) * 6;

            Console.WriteLine(c);
        }

        public static void IncrementPostfix_vs_Prefix()
        {
            int a1 = 3;
            // Prefix increment
            int b1 = ++a1;

            Console.WriteLine(a1);
            Console.WriteLine(b1);

            Console.WriteLine("--------------------------------");

            int a2 = 3;
            // Postfix increment
            int b2 = a2++;

            Console.WriteLine(a2);
            Console.WriteLine(b2);
        }

        public static void ArithmeticOverflow_Example()
        {
            int nr = int.MaxValue;
            int nr_to_add = 1;

            // how to check for overflow?
            bool isOverflow = IsOverflow(nr, nr_to_add);
            if (isOverflow)
            {
                Console.WriteLine("Whoops, arithmetic overflow!");
            }
            else
            {
                int result = nr + nr_to_add;

                Console.WriteLine(result);
            }
        }

        public static bool IsOverflow(int nr, int nr_to_add)
        {
            bool isOverflow = int.MaxValue - nr < nr_to_add;
            return isOverflow;
        }

        public static bool IsNotOverflow(int nr, int nr_to_add)
        {
            bool isNotOverflow = int.MaxValue - nr > nr_to_add;
            return isNotOverflow;
        }

        public static void DivisionByZero_Example()
        {
            int nr = 1234;
            int b = 0;

            int result = nr / b;

            Console.WriteLine(result == 0);
        }

        public static void PowersOfTwo_Example()
        {
            int a = 1;

            Console.WriteLine(a << 0);

            Console.WriteLine(a << 1);

            Console.WriteLine(a << 2);

            Console.WriteLine(a << 3);

            Console.WriteLine(a << 4);
        }

        public static void DivisionForFloat_ReturnsFloat()
        {
            int a = 3;
            int b = 2;

            float result = (float)a / b;

            Console.WriteLine(result);
        }
    }
}
