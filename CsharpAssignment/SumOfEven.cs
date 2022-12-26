using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment
{
    public class SumOfEven
    {
        public static void Sum()
        {
            int a = 0;
            int Sum = 0;
            for (a = 0; a <= 50; a++)
            {
                if (a % 2 == 0)
                {
                    Sum = Sum + a;
                }
            }
            Console.WriteLine("sum of Even number Between 0 to 50 :-"  + Sum);
            if (Sum%2==0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}
