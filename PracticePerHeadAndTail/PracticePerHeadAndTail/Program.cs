using System;

namespace PracticePerHeadAndTail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int usernumber=Convert.ToInt32(Console.ReadLine());
            HeadAndTailComputation P1=new HeadAndTailComputation();
            P1.compute(usernumber);

        }
    }
}
