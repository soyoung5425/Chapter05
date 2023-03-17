using System;

namespace YunSoYoung_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            while (a>=0)
            {
                int i = 0;
                while (a >= i)
                {
                    if(i<5)
                    {
                        break;
                    }
                    Console.Write("*");
                    i -= 1;
                }
            }
            Console.WriteLine();
        }
    }
}
