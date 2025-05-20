using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class EmployeeManagement
    {
        List<TemporaryEmp> listEmployee = new List<TemporaryEmp>;
        public void Input_Employee()
        {
            string choice;
            do
            {
                Console.WriteLine("\nEnter Employee Information:");
                TemporaryEmp tempEmp = new TemporaryEmp();
                tempEmp.Input();
                listEmployee.Add(tempEmp);
                Console.Write("Do you want to continue? (Y/N): ");
                choice = Console.ReadLine() ?? "N";
            }
            while (choice.Equals("Y", StringComparison.OrdinalIgnoreCase));
        }

        public void Display_Employee()
        {
            Console.WriteLine("List Of Employee");
            foreach(var emp in listEmployee)
            {
                emp.DisplayDetail();
                Console.WriteLine("-----------------------------------------");
            }
        }

        public void Display_Max_NumWork()
        {
            if (listEmployee.Count == 0)
            {
                Console.WriteLine("No employee in the list.");
                return;
            }

            int max = listEmployee.Max(emp => emp.NumWork);
            Console.WriteLine($"\n===== Employee(s) with Max NumWork = {max} =====");
            foreach (var emp in listEmployee)
            {
                if (emp.NumWork == max)
                {
                    emp.DisplayDetail();
                    Console.WriteLine("-------------------------");
                }
            }
        }

        public void Search_Employee()
        {
            Console.Write("\nEnter Employee Name to Search: ");
            string name = Console.ReadLine() ?? "";

            var results = listEmployee
                .Where(emp => emp.EmployeeName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No employee found with that name.");
            }
            else
            {
                Console.WriteLine($"\n===== Found {results.Count} Employee(s) =====");
                foreach (var emp in results)
                {
                    emp.DisplayDetail();
                    Console.WriteLine("-------------------------");
                }
            }
        }

        
    }
}
