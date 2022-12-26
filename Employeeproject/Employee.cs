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
        public static string companyLocation;
        public char empPerformanceType;

        public double EmpSalary
        {
            get
            {
                return empSalary;
            }
            set
            {
                if(value>3000)
                {
                    empSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid Salary So Default value remains !!!");
                }
            }
        }

        public void printEmployeeDetails()
        {
            Console.WriteLine("Employee Id:" + empId);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + empSalary);
            Console.WriteLine("company Name:" + Employee.companyName);
            Console.WriteLine("Employee Location:" + Employee.companyLocation);
            Console.WriteLine("Employee Performance:" + empPerformanceType);
            Console.WriteLine("-------------------------------------------");
        }
        //calculate Bonus

        public void GetGrossSalaryWithBonus()
        {

            if (empPerformanceType == 'A')
            {
                Console.WriteLine("25%");
                Console.WriteLine(empSalary + (empSalary * 25/ 100));
            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine("15%");
                Console.WriteLine(empSalary + (empSalary * 15/ 100));
            }
            else if (empPerformanceType == 'c')
            {
                Console.WriteLine("10%");
                Console.WriteLine(empSalary + (empSalary * 10/ 100));
            }
            else
            {
                Console.WriteLine("Not Eligible for Bonus");
            }


        }
    }
    
}
