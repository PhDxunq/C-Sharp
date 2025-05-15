using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CourseManager
    {
        private List<Course> courses = [];

        public void ViewAllCourses()
        {
            foreach(var course in courses)
            {
                course.DisplayCourseInfo();
            }
        }

        public void AddCourse()
        {
            Console.WriteLine("Course Online(1) or Offline(2)");
            int courseType = int.Parse(Console.ReadLine() ?? "1");
            Course course;
            course = (courseType == 1) ? new OnlineCourse() : ((courseType == 2) ? new Course() : throw new InvalidDataException("Invalid Course"));
            course.Input();
            courses.Add(course);

            
        }
        public void DeleteCourse()
        {
            Console.WriteLine("Enter courseID:");
            int courseId = int.Parse(Console.ReadLine() ?? string.Empty);
            courses.Remove(courses.Where(c => c.CouserID == courseId).First());
        }

        public void UpdateCourse()
        {
            Console.WriteLine("Enter courseID:");
            int courseId = int.Parse(Console.ReadLine() ?? string.Empty);
            Course foundCourse = courses.Where(c => c.CouserID == courseId).First();
            if(foundCourse == null)
            {
                Console.WriteLine("Cannot Find");
            }
            Console.WriteLine("Fee Per Student: ");
            foundCourse.FeePerStudent = float.Parse(Console.ReadLine() ?? "1.0f");

        }
    }
}
