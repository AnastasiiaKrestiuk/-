using System;

namespace HW3
{
    class Task1
    {
        static void Main(string[] args)
        {
            bool IsPalindrom(int number)
            {
                int result = 0;
                int temp = number;
                bool isPalindrom = false;
                do
                {
                    int n = temp % 10;
                    result = (result * 10) + n;
                    
                    temp = temp / 10;                    
                } while (temp % 10 != 0);

                if (number == result) isPalindrom = true;
               
                return isPalindrom;
            }

            int n = int.Parse(Console.ReadLine());

            if (IsPalindrom(n) == true) Console.WriteLine("да");

            else Console.WriteLine("нет");
        }
    }
}
