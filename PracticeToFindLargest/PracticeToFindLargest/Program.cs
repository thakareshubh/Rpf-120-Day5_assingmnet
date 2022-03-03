using System;

namespace PracticeToFindLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int num3=Convert.ToInt32(Console.ReadLine());
            PracticeToFind p1=new PracticeToFind();
            p1.Find(num1,num2,num3);
        }
    }

    public class PracticeToFind
    {
        public void Find(int num1,int num2,int num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is greter");

            }
            else if(num2>num1 && num2>num3)
            {

                Console.WriteLine(num2+" is greter");

            }
            else 
            {
                Console.WriteLine(num3 + " is greter");
            }
        }
    }
}
