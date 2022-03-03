using System;

namespace PracticeSwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            SwapingOfTwoNumber p1=new SwapingOfTwoNumber();
            p1.swap(a,b);
        }
    }
}
