﻿using System;

namespace YunSoYoung_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
