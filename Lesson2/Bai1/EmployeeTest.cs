using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class EmployeeTest
    {
        public static void Test()
        {
            NewEmployee newEmployee = new NewEmployee();
            int choice = 0;
            do
            {
                Console.WriteLine("1 - Manager");
                Console.WriteLine("2 - Engineer");
                Console.WriteLine("3 - Technician");
                Console.WriteLine("4 - Teacher");
                Console.Write("Select the desigation(1-4): ");
                choice = int.Parse(Console.ReadLine() ?? "1");
                Console.Write("Enter Year Of Service: ");
                newEmployee.YearsOfService = int.Parse(Console.ReadLine() ?? "0");
                switch (choice)
                {
                    case 1:
                        newEmployee.designation = "Manager";
                        newEmployee.salary = 5000;
                        break;
                    case 2:
                        newEmployee.designation = "Engineer";
                        newEmployee.salary = 4000;
                        break;
                    case 3:
                        newEmployee.designation = "Technician";
                        newEmployee.salary = 3000;
                        break;
                    case 4:
                        newEmployee.designation = "Teacher";
                        newEmployee.salary = 2000;
                        break;
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;

                }
                Console.Write("Enter the employee name: ");
                newEmployee.EmployeeName = Console.ReadLine() ?? "";
                newEmployee.DisplayDetails();


            } while (choice < 1 || choice > 4);

        }
    }
}
