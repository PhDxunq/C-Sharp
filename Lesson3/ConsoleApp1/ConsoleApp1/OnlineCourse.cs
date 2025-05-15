using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OnlineCourse:Course
    {
        float platformFee = 10.0f;

        
        public override float CalculateTotalFee() {
            return (base.(FeePerStudent + this.platformFee) * EnrolledCount);
        }

        public override void DisplayCourseInfo()
        {
            Console.WriteLine($"Course: {CouserName} | Students: {EnrolledCount} | Total Fee: ${CalculateTotalFee()} (Includes platform fee)");
        }
    }

}
