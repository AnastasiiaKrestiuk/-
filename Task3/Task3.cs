using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            void Power (int number)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{Math.Pow(i, 3)}, ");
                }
            }

            int GetNumber(string massage)
            {
                int result = 0;
                bool isCorrect = false;

                while (!isCorrect)
                {
                    Console.WriteLine(massage);
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число. Введите число.");
                    }
                }

                return result;
            }

            int number = GetNumber("Введите число:");
            Power(number);
        }
    }
}
