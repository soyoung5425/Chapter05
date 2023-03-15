using System;

namespace p161_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "3":
                case "4":
                case "5":
                    Console.WriteLine($"입력하신 {input}월은 봄 입니다.");
                    return;

                case "6":
                case "7":
                case "8":
                    Console.WriteLine($"입력하신 {input}월은 여름 입니다.");
                    return;

                case "9":
                case "10":
                case "11":
                    Console.WriteLine($"입력하신 {input}월은 가을 입니다.");
                    return;

                case "12":
                case "1":
                case "2":
                    Console.WriteLine($"입력하신 {input}월은 겨울 입니다.");
                    return;

                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해주세요.");
                    return;
            }

        }
    }
}
