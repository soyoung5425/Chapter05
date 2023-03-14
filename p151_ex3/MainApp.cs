using System;

namespace p151_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. :");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if(number>=50)
            {
                Console.WriteLine($"입력하신 숫자 {number}는 50이상의 수 입니다.");
            }
            else
            {
                Console.WriteLine($"입력하신 숫자 {number}는 50미만의 수 입니다.");
            }
        }
    }
}
