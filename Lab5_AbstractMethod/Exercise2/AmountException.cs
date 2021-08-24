using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class InvalidSalary : ApplicationException
    {
        public InvalidSalary() : base("Senior must get more than 60,000$ ") { }
    }
    public class InvalidBonus : ApplicationException
    {
        public InvalidBonus() : base("Bonus is over 10,000$ ") { }
    }
    public class Employee
    {
        public string name;
        public double salary;
        public double bonus;
        public string major;

        public void getName()
        {
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your major : ");
            major = Console.ReadLine();
            Console.WriteLine("Enter your salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
            bonus = salary * 0.05;
        }
    }
    class AmountException
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getName();

            try
            {
                if(emp.major=="Senior Lecture" && emp.salary < 60000)
                {
                    throw new InvalidSalary();
                }else if (emp.bonus > 10000)
                {
                    throw new InvalidBonus();
                }
            }catch(InvalidSalary objSalary)
            {
                Console.WriteLine(objSalary.Message);
            }catch(InvalidBonus objBonus)
            {
                Console.WriteLine(objBonus.Message);
            }
            finally
            {
                Console.WriteLine("\nHave a good day !");
            }
            Console.ReadLine();
        }
    }
}
