using System;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요. :");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            string result = number % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
