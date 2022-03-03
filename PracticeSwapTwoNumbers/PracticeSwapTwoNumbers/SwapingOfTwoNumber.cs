using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSwapTwoNumbers
{
    internal class SwapingOfTwoNumber
    {
        public void swap(int a,int b)
        {
            int temp=a;
            a=b;
            b=temp;
            Console.WriteLine("value of a is :" + a + "value of b is :" + b );
        }
    }
}
