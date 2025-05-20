using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    abstract class Employees
    {
        private int empID;
        private string empName;
        private DateTime dob;
        private string department;
        private int numWork;

        public int EmployeeID
        {
            get { return empID; }
            set { 
                if (value < 0) {
                throw new ArgumentOutOfRangeException("EmployeeID must be > 0.");
                }
                empID = value; 
            }
        }

        public string EmployeeName
        {
            get { return empName; }
            set
            {
                if(value.Length < 6 || value.Length > 40)
                {
                    throw new ArgumentOutOfRangeException("EmployeeName must be between 6 and 40.");
                }
                empName = value;
            }
        }

        public DateTime Dob
        {
            get { return dob; }

            set
            {
                var today = DateTime.Today;
                var age = today.Year - dob.Year;

                if(age < 18) {
                    throw new ArgumentOutOfRangeException("Age must be greater than 18.");
                }
                dob = value;
            }
        }

        public string Department
        {
            get { return department; }
            set
            {
                department = value;
            }
        }

        public int NumWork
        { 
            get { return numWork; } 
            set
            {
                numWork = value;
            } 
        }

        // Create a no arguments constructor:
        public Employees() {
            EmployeeID = 10;
            EmployeeName = string.Empty;
            Department = "Aptech";
            NumWork = 0;
        }

        public Employees(int empID, string empName, DateTime dob, string department, int numWork) {
            EmployeeID = empID;
            EmployeeName = empName;
            Dob = dob;
            Department = department;
            NumWork = numWork;
        }

        public virtual void Input()
        {
            Console.Write("Enter EmployeeID: ");
            this.EmployeeID = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter EmployeeName: ");
            this.EmployeeName = Console.ReadLine() ?? "";
            Console.Write("Enter EmployeeDOB: ");
            string stringDOB = Console.ReadLine() ?? "";
            string[] dobs = stringDOB.Split("/");
            this.Dob = new DateTime(int.Parse(dobs[2]), int.Parse(dobs[1]), int.Parse(dobs[0]), 0, 0, 0);
            Console.Write("Enter Department: ");
            this.Department = Console.ReadLine() ?? "";
            Console.Write("Enter Number Of Work: ");
            this.NumWork = int.Parse(Console.ReadLine() ?? "0");
        }

        public virtual void DisplayDetail()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} \n" +
                              $"EmployeeName: {EmployeeName}\n" +
                              $"DOB: {Dob}\n" +
                              $"Department: {Department}\n" +
                              $"NumWork: {NumWork}\n");
        }

        public abstract double CalculateSalary();
    }
}
