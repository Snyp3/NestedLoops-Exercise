using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbers = 0;

            while (input != "stop")
            {
                int currentNumber = int.Parse(input);
                int primeCounter = 0;

                if (currentNumber < 0) // няма да е правилно да се направи <= 0 щото 0 не не негативе
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                if (currentNumber == 0)             //за да бе остабе безкраен while
                {                                   //за да бе остабе безкраен while
                    input = Console.ReadLine();     //за да бе остабе безкраен while
                    continue;                       //за да бе остабе безкраен while
                }                                   //за да бе остабе безкраен while
                
                for (int i = 1; i <= currentNumber; i++)         // това показва прости и сложни числа
                {                                               // това показва прости и сложни числа
                    if (currentNumber % i == 0)                 // това показва прости и сложни числа
                    {                                           // това показва прости и сложни числа
                        primeCounter++;                         // това показва прости и сложни числа
                    }
                    
                }

                if (primeCounter == 2)
                {
                    sumPrimeNumbers += currentNumber;
                }
                else
                {
                    sumNonPrimeNumbers += currentNumber;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");        
                 

        }
    }
}
