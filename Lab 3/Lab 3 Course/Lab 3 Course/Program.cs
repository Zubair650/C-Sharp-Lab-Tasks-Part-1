using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Course
{
    class Course
    {
        public Course()
        {
            Console.WriteLine("Constructor called");
        }
        private string courseName;
        private string courseCode;
        private int courseCredit;
        void ShowCourseInfo(string courseName, string courseCode, int courseCredit)
        {
            Console.WriteLine("Course Name:" + courseName);
            Console.WriteLine("Course Code:" + courseCode);
            Console.WriteLine("Course Credit:" + courseCredit);
        }
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.ShowCourseInfo("OOP-2", "101", 3);
        }
    }
}
