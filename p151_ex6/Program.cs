using System;

namespace p151_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요.(ex:2) : ");
            string input1 = Console.ReadLine();
            Console.Write("현재 본인의 점수를 입력해 주세요. (ex:85) : ");
            string input2 = Console.ReadLine();

            int grade = int.Parse(input1);
            int score = Convert.ToInt32(input2);

            if (grade == 4)
            {
                if (score >= 70)
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 합격입니다.");
                }
                else
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 불합격입니다.");
                }
            }
            else
            { 
                if (score >= 60)
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 합격입니다.");
                }
                else
                {
                    Console.WriteLine($"입력하신 점수 {score}는(은) 불합격입니다.");
                }
            }
            if (score <0 && score>100)
            {
                Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
            }
        }
    }
}
