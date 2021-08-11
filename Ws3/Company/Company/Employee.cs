using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Employee
    {
        static void Main(string[] args)
        {
            int employeeID;
            String employeeName  ;
            String designation;
            float taxAmount = 0;
            double salary = 0, netSalary = 0;

            Console.Write("Enter the id of an employee : ");
            employeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of an employee : ");
            employeeName = Console.ReadLine();

            Console.Write("Enter designation : ");
            designation = Console.ReadLine();

            Console.Write("Enter the id of an employee : ");
            salary = Convert.ToDouble(Console.ReadLine());

            if(salary >= 10000)
            {
                taxAmount = (float)(salary * 32.5 / 100);
            }
            else
            {
                taxAmount = (float)(salary * 24.5 / 100);
            }
            netSalary = salary - taxAmount;

            Console.WriteLine("\n Employee Details: ");
            Console.WriteLine("Employee ID : " + employeeID);
            Console.WriteLine("Employee Name : " + employeeName);
            Console.WriteLine("Designation : " + designation);
            Console.WriteLine("Salary : (0) $", salary);
            Console.WriteLine("Net Salary : (0:F2) $ is ");
        }
    }
}
