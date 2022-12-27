using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public int studentId;
        public string studentName;
        public string studentMailid;
        public double studentPercentage;
        public string schoolName;
        public string schoolAddress;

        public void studPercentage1()
        {
            if(studentPercentage>=90)
            {
                Console.WriteLine("Hi " + studentName+ "! you are passed with GRADE A");
            }
            else if(studentPercentage>=80 && studentPercentage<=89)
            {
                Console.WriteLine("Hi " + studentName+ "! you are passed with GRADE B");
            }
            else if(studentPercentage>=60 && studentPercentage<=79)
            {
                Console.WriteLine("Hi " +studentName+ "! you are passed with GRADE C");
            }
            else if (studentPercentage < 60)
            {
                Console.WriteLine("Hi " + studentName + "! you are passed with GRADE F");
            }

        }

        public void PrintstudentDetailed()

        {
            Console.WriteLine("STUDENTID : " + studentId);
            Console.WriteLine("STUDENT NAME : " + studentName);
            Console.WriteLine("STUDENT MAILID : " + studentMailid);
            Console.WriteLine("STUDENT PERCENTAGE : " + studentPercentage);
            Console.WriteLine("STUDENT SCHOOLNAME : " + schoolName);
            Console.WriteLine("STUDENT SCHOOLADDRESS : " + schoolAddress);
        }
    
    }
}
