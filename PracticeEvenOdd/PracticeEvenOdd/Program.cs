using System;

namespace PracticeEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());
            PracticeEvenOdd p1=new PracticeEvenOdd();
            p1.Evenodd(number);
            
        }
    }

    public class PracticeEvenOdd
    {
        public void Evenodd(int number)
        {
            if(number%2==0)
            {
                Console.WriteLine(number + " :is even number");

            }
            else
            {
                Console.WriteLine(number + " :is odd number");
            }
        }
    }
}
