using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course : ICourse
    {
        int courseId;
        string courseName;
        float feePerStudent;
        int enrolledCount;

        public int CouserID { 
            get => courseId;
            set
            {
                if (courseId <= 0) throw new Exception("Id must be > 0");
                courseId = value;
            }
        }

        public string CouserName
        {
            get => courseName;
            set
            {
                if (value.Length < 3 || value.Length > 100) throw new Exception("Length must be 3 to 100");
                courseName = value;
            }
        }
        public float FeePerStudent
        {
            get => feePerStudent;
            set
            {
                if (courseId < 0) throw new Exception("FeePerStudent must be > 0");
                feePerStudent = value;
            }
        }

        public int EnrolledCount
        {
            get => enrolledCount;
            set
            {
                if (enrolledCount <= 0) throw new Exception("EnrolledCount must be > 0");
                enrolledCount = value;
            }
        }

        public Course() { };
        public Course(int courseId, string courseName, float feePerStudent, int enrolledCount) {
                CouserID = courseId;
                CouserName = courseName;
                FeePerStudent = feePerStudent;
                EnrolledCount = enrolledCount;
            
        };

        public virtual float CalculateTotalFee()
        {
            return FeePerStudent * EnrolledCount;
        }

        public virtual void DisplayCourseInfo()
        {
            Console.WriteLine($"Course: {courseName} | Students: {enrolledCount} | Total Fee: ${CalculateTotalFee()}");
        }

        public void Input()
        {
            Console.WriteLine("Enter ID: ");
            this.CouserID = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine("Enter Name: ");
            this.CouserName = Console.ReadLine() ?? "";

            Console.WriteLine("Enter FeePerStudent: ");
            this.FeePerStudent = float.Parse(Console.ReadLine() ?? "1.0f");

            Console.WriteLine("Enter EnrolledCount: ");
            this.EnrolledCount = int.Parse(Console.ReadLine() ?? "1");


        }
    }
}
