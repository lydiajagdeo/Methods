using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"That's great, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Cool cool and what is your favorite band?");
            var band = Console.ReadLine();
            
            
            var addition = Sum(2, 6);
            var multiplication = Multiply(2, 4, 6);
            var subtraction = Minus(9, 4);
            var division = Divide(60, 3);

            static int Sum(int num1, int num2)
            {
                var answer = num1 + num2;
                Console.WriteLine(answer);
                return answer;
            }
            static int Multiply(int num1, int num2, int num3)
            {
                var answer2 = num1 * num2 * num3;
                Console.WriteLine(answer2);
                return answer2;
            }

            static int Divide(int num1, int num2)
            {
                var answer3 = num1 / num2;
                Console.WriteLine(answer3);
                return answer3;
            }

            static int Minus(int num1, int num2)
            {
                var answer4 = num1 - num2;
                Console.WriteLine(answer4);
                return answer4;
            }
        }
    }
}

