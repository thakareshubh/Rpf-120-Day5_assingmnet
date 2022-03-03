using System;

namespace PracticeFactorOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int number=Convert.ToInt32(Console.ReadLine());
            FactorizationOfNumber.Factorized(number);
        }
    }
}
