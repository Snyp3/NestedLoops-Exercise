using System;
using System.Threading;

namespace P02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string currentNumber = i.ToString();

                int oddSum = 0;
                int evenSum = 0;


                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (j % 2 == 0) // таке е правилно защото Lenght-a почва от 0
                    {
                        oddSum += int.Parse(currentNumber[j].ToString()); // за сегашната задача няма значение
                                                                          // дали е odd 1во или else
                    }
                    else
                    {
                        evenSum += int.Parse(currentNumber[j].ToString());
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
