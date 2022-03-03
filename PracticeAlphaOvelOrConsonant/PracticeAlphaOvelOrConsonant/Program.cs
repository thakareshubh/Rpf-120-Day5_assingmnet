using System;

namespace PracticeAlphaOvelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet");
           char al=Convert.ToChar(Console.ReadLine());
            FindCoAndVo p1 = new FindCoAndVo();
            p1.find(al);

        }
    }
    public class FindCoAndVo
    { 
 
        public void  find(char al)
        {
            if(al=='a' || al=='e'|| al=='i' || al== 'o' || al=='u' || al=='A' || al=='E' || al=='I' || al=='O' || al=='U')
            {
                Console.WriteLine(al + " is alphabet");
            }
            else
            {
                Console.WriteLine(al + " is consonant");
            }
                
            
        }
    }
}
