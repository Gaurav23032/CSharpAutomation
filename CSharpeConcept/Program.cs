using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpeConcept
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int Smith = 25;
            int John = 45;
            int Henary = 65;
            if (Smith > John || Smith > Henary)
            {
                if (John > Henary)
                {
                    Console.WriteLine("Henary is younger");

                }
                {
                    Console.WriteLine("John is Younger");
                }
            }

                {
                    Console.WriteLine("Smith is younger");
                }
            
        }
    }
}

