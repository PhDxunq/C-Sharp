using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class TemporaryEmp : Employees
    {
        private int workDay;
        public int WorkDay
        {
            get { return workDay; }
            set { workDay = value; }
        }

        public TemporaryEmp() : base()
        {
            this.workDay = 0;
        }

        public TemporaryEmp(int empID, string empName, DateTime dob, string department, int numWork, int workDay)
            : base(empID, empName, dob, department, numWork)
        {
            this.workDay = workDay;
        }

        public override double CalculateSalary()
        {
            double salary;
            if (workDay <= 25) {
                salary = workDay * 50000;
            }
            else
            {
                salary = 25 * 50.000 + (workDay - 25) * 50.000 * 2;
            }
            return salary;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter Work Day:");
            WorkDay = int.Parse(Console.ReadLine() ?? "0");
        }

        public override void DisplayDetail()
        {
            base.DisplayDetail();
            Console.WriteLine($"WorkDay: {workDay}");
            Console.WriteLine($"Salary: {CalculateSalary():N0} VND");
        }
    }
}
