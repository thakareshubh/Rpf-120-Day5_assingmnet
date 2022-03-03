using System;

namespace PracticePowerOf_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number upto which you want to print number");
            int number=Convert.ToInt32(Console.ReadLine());
            PowerOfTwo.ComputePowerTable(number);
        }
    }
}
