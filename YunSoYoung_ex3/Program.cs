using System;

namespace YunSoYoung_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                int j = 0;
                while(j<=i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

            Console.WriteLine();

            int a = 0;
            while(a<5)
            {
                int b = 5;
                while(b>a)
                {
                    Console.Write("*");
                    b--;
                }
                Console.WriteLine();
                a++;
            }

            Console.WriteLine();

            int c = 0;
            do
            {
                int d = 0;
                while (d <= c)
                {
                    Console.Write("*");
                    d++;
                }
                Console.WriteLine();
                c++;
            }
            while (c < 5);

            Console.WriteLine();

            int e = 0;
            do
            {
                int f = 5;
                while (f > e)
                {
                    Console.Write("*");
                    f--;
                }
                Console.WriteLine();
                e++;
            }
            while (e < 5);
        }
    }
}
