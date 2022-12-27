using SchoolManagement;
using System.Diagnostics.Metrics;

namespace Maveric.Runner
{
    public class program
    {
        static void Main(String[]args)
        {
            Console.WriteLine("***********Student Info**************");

            Student stud1 = new Student();
            Student stud2 = new Student(); 
            Student stud3= new Student();
           


            stud1.studentId = 1001;
            stud1.studentName = "jack";
            stud1.studentMailid= "jack @gmail.com";
            stud1.studentPercentage = 45.2;
            stud1.schoolName= "Global school";
            stud1.schoolAddress = "chennai";

            stud2.studentId = 1002;
            stud2.studentName = "peter";
            stud2.studentMailid = "peter @gmail.com";
            stud2.studentPercentage = 85.2;
            stud2.schoolName = "Global school";
            stud2.schoolAddress = "chennai";

            stud3.studentId = 1003;
            stud3.studentName = "mark";
            stud3.studentMailid = "mark @gmail.com";
            stud3.studentPercentage = 55.2;
            stud3.schoolName = "Global school";
            stud3.schoolAddress = "chennai";

           
            stud1.PrintstudentDetailed();
            Console.WriteLine("================================================");
            stud2.PrintstudentDetailed();
            Console.WriteLine("================================================");
            stud3.PrintstudentDetailed();
            Console.WriteLine("================================================");

            stud1.studPercentage1();
            stud2.studPercentage1();
            stud3.studPercentage1();










        }
    }
}
