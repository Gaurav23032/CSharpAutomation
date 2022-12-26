
using Employeeproject;

namespace Maveric.Runner
{
    public class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***********EMPLOYEE DASHBORD**********");
            Employee.companyName = "Maveric";
            Employee.companyLocation= "Chennai";

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3= new Employee();
            Employee emp4 = new Employee();

            emp1.empId = 101;
            emp1.empName = "saul";
            emp1.empSalary = -9000;
            emp1.empPerformanceType = 'B';
           

            emp2.empId = 102;
            emp2.empName = "kim";
            emp2.empSalary = 12000.2;
            emp1.empPerformanceType = 'A';

            emp3.empId = 103;
            emp3.empName = "jack";
            emp3.empSalary = 6000.2;
            emp1.empPerformanceType ='c';
           

          //  emp3.empId = 104;
          //  emp3.empName = "Gaurav";
          //  emp3.empSalary = 7000;

            Employee.companyName = "Maveric System";
            Employee.companyLocation = "Channai";

            emp2.printEmployeeDetails();
            emp3.printEmployeeDetails();
            emp4.printEmployeeDetails();
            emp1.GetGrossSalaryWithBonus();
            emp2.GetGrossSalaryWithBonus();
            emp3.GetGrossSalaryWithBonus();
            emp4.GetGrossSalaryWithBonus();
        }
    }
}