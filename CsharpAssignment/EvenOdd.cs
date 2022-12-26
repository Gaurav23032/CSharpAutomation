using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment
{
    public  class EvenOdd
    {
      public static void  M1()
        {
            
            int i = 0;
            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 30; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i + "");
                }
            }
            Console.WriteLine("\n Odd Numbers :");
            for(i=1;i<=30;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i + "");
                }
            }
            Console.WriteLine();
        }
    }
}
