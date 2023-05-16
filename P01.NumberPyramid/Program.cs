using System;

namespace P01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isBigger = false;
            int currentNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNumber > number)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write($"{currentNumber} ");// Console.Write(currentNumber + " ");
                    currentNumber++;           
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
