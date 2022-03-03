using System;

namespace PracticeHormonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number=Convert.ToInt32(Console.ReadLine());
            ComputeHormonic p1=new ComputeHormonic();
            p1.Compute(number);
        }
    }
}
