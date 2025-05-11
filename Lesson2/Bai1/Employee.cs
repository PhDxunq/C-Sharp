using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Employee : IEmployee
    {

        private string _employeeName;
        private int _yearsOfService;
        protected double _bonus;
        public string designation;
        public double salary;

        //Properties = method = function
        public string EmployeeName {

            //R/W => get and set
            // R => get
            // W => set
            get {
                return _employeeName;
            }
            set{
                if (value.Length < 6 || value.Length > 40)
                {
                    throw new ArgumentException("Name must be between 6 to 40");
                }
                _employeeName = value;
            }
        }

        public int YearsOfService
        {

            //R/W => get and set
            // R => get
            // W => set
            get
            {
                return _yearsOfService;
            }
            set
            {
                if (YearsOfService < 0 || YearsOfService > 60)
                {
                    throw new ArgumentException("Years Of Service must be between 0 to 60");
                }
                _yearsOfService = value;
            }
        }

        

        public virtual double CalculateBonus(string designation, int tenure, double salary)
        {
            if (designation.Equals("Manager")) {
                _bonus = salary * (tenure <= 5 ? 1.5 : 2);
            } else if (designation.Equals("Engineer")) { 
                _bonus = salary * (tenure <= 5 ? 1 : 2);
            } else if (designation.Equals("Technician")) {
                _bonus = salary * (tenure <= 3 ? 0.25 : (tenure > 3 && tenure <=5) ? 0.5 : 2);
            } else {
                _bonus = 0 ;
            }
            return _bonus;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name : {_employeeName} \n" +
                              $"Year of Service : {YearsOfService} \n" +
                              $"Designation: {designation} \n" +
                              $"Salary: {salary} \n" +
                              $"Bonus: {CalculateBonus(designation, YearsOfService, salary)} \n" +
                              $"Total Income : {salary + CalculateBonus(designation,YearsOfService,salary)}");
        }
    }
}
