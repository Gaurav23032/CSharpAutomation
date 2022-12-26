using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment
{
    public class MultiplicationTableFive
    {
        public static void Display()
        {
        int count1 = 0, count2 = 0;
            int i = 1;
            for(; i <= 30; i++)
                if((5*i)%2==0)
            {
                    Console.WriteLine("It is even number" + 5 * i);
            }
                else
                {
                    Console.WriteLine("It is odd number" + 5 * i);
                }
            Console.WriteLine(count1);
        }
    }
}
