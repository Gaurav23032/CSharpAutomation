using maths.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment
{
    public class Program
    {
       public  static void M3()
        {
            Console.WriteLine("Gaurav Kshirsagar");
            double result = Volume.VolumeOfSphere(12);
            Console.WriteLine(result);

            result = Volume.VolumeOfCuboid(10, 10, 10);
            Console.WriteLine(result);

            result = Volume.VolumeOfCuboid(20, 20, 20);
            Console.WriteLine(result);
            Console.WriteLine(Volume.VolumeOfCuboid(30, 30, 30));


            string authorname = Volume.GetAuthorName();
            Console.WriteLine(authorname);
           
        }
    }
}