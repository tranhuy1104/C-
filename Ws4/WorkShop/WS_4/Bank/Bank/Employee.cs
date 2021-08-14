using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    /// <summary>
    /// 
    /// The program demonstrates the use of descision-making statements.
    /// 
    /// Class Employee acepts, validates, calculates and displays the details of the employee
    /// using if, if-else and switch-case statements.
    /// </summary>

    class Employee
    {
        /// <summary>
        /// 
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            // Integer variable to store the employee ID
            int employeeID;

            // Sting variables to store the employee name and designation
            string employeeName;
            string designation = "";

            // DateTime variable to store the employee's date of birth
            DateTime birthDate;

            // Character variable to store the employee gender
            char gender;

            // Byte variable to store the number of years served
            byte yearsServed;

            // Double variables to store bonus, salary, tax amount, and net salary
            double bonus = 0, salary = 0, taxAmount = 0, netSalary = 0;

            // Accepting the details of the employee and validating it using if statement
            Console.Write("Enter the ID of employee : ");
            employeeID = Convert.ToInt32(Console.ReadLine());
            if (employeeID > 0)
            {
                Console.Write("Enter the name of employee : ");
                employeeName = Console.ReadLine();
                if (employeeName != "" && employeeName.Length < 40)
                {
                    Console.Write("Enter date of birth [MM/DD/YYYY] : ");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    int age = (DateTime.Today.Subtract(birthDate)).Days / 365;
                    if (age >= 18)
                    {
                        Console.Write("Enter gender [M/F] : ");
                        gender = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("Select designation (Choose the number) : ");
                        Console.WriteLine("1. Manager \n2. System Analyst \n3. Developer \n4. Accountant");
                        Console.Write("Enter your choice : ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the tenure in years : ");
                        yearsServed = Convert.ToByte(Console.ReadLine());

                        // Assigning salary based on the designation selected using switch statement
                        switch (choice)
                        {
                            case 1:
                                designation = "Manager";
                                salary = 21346;
                                break;
                            case 2:
                                designation = "System Analyst";
                                salary = 16729;
                                break;
                            case 3:
                                designation = "Developer";
                                salary = 14525;
                                break;
                            case 4:
                                designation = "Accountant";
                                salary = 13215;
                                break;

                        }

                        // Calculating bonus based on the number of years served
                        if (yearsServed >= 3)
                        {
                            if (salary > 20000)
                            {
                                bonus = salary * 0.09;
                            }
                            else if (salary > 14000 && salary <= 20000)
                            {
                                bonus = salary * 0.05;
                            }
                            else
                            {
                                bonus = salary * 0.02; ;
                            }
                        }
                        //Calculating tax amount and net salary
                        taxAmount = salary * 33 / 100;
                        netSalary = salary - taxAmount;

                        //Displaying the details of employee Console.Wrieline(\nEmployee Details: ");

                        Console.WriteLine("\nEmployee ID : " + employeeID);
                        Console.WriteLine("EmployeeName : " + employeeName);
                        Console.WriteLine("Date or Birth : " + birthDate);
                        if (gender == 'M')
                            Console.WriteLine("Gender : Male");
                        else
                            Console.WriteLine("Gender : Female");
                        Console.WriteLine("Designation : " + designation);
                        Console.WriteLine("Tenure : " + yearsServed);
                        Console.WriteLine("Salary : {0} $", taxAmount);
                        Console.WriteLine("Net salary : {0:F2} $ is rounded off to : {1} $", netSalary, (int)netSalary);
                        Console.WriteLine("Bonus : {0} $", bonus);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry for date of birth");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid entry for employee name");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry for employee ID");
            }
        }
    }
}
