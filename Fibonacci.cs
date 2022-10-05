using System;
class Fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 0;

            Console.Write(a + ", " + b );

            for (i = 1; i < 10; i++)
            {
                c = a + b;
                Console.Write(", "+c);

                a = b;
                b = c;
            }

            Console.WriteLine();

        }
    }