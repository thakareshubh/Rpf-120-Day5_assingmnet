using System;

namespace PracticeQuotientAndReminderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter divident and divisor");
            int divident=Convert.ToInt32(Console.ReadLine());
            int divisor=Convert.ToInt32(Console.ReadLine());
            ComputeReminderAndQuotient p1=new ComputeReminderAndQuotient();
            p1.compute(divident, divisor);
        }
    }
}
