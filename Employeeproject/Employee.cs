using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeproject
{
    public class Employee
    {
        public int empId;  //non static variable and instant class
        public string empName;
        public double empSalary;
        public static string companyName;
        public  static string companyLocation;

        public void printEmployeeDetails()
        {
            Console.WriteLine("Employee Id:" + empId);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + empSalary);
            Console.WriteLine("company Name:" +Employee.companyName);
            Console.WriteLine("Employee Location:"+Employee.companyLocation);
            Console.WriteLine("-------------------------------------------");
        }
    }
    
}
