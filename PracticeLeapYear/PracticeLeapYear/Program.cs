using System;

namespace PracticeLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year here");
            int year = Convert.ToInt32(Console.ReadLine());
            ComputationOfYear.Compute(year);
        }
    }
}
