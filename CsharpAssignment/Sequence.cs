using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment
{
    public  class Sequence
    {
        public static void M3()
        {
           
            int a; int b;
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\b");
            for(a=1;a<=20;a++)
            {
                Console.WriteLine( a * b);
            }
        }
    }
}
