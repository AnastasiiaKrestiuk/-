using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            double Distance (int ax, int ay, int az, int bx, int by, int bz)
            {
                double distance = Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)), 2);
                return distance;
            }

            int GetNumbers (string massage)
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
            
            int ax = GetNumbers("Введите координату x первой точки:");
            int ay = GetNumbers("Введите координату y первой точки:");
            int az = GetNumbers("Введите координату z первой точки:");
            int bx = GetNumbers("Введите координату x второй точки:");
            int by = GetNumbers("Введите координату y второй точки:");
            int bz = GetNumbers("Введите координату z второй точки:");

            Console.WriteLine(Distance(ax, ay, az, bx, by, bz));

        }
    }
}
