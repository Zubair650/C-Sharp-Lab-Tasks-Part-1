using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student(string name, string id, string department, float cgpa)
        {
            Console.WriteLine("Constructor called");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Cgpa: " + cgpa);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Zubair", "101", "CSE", 3.75f);
            s1.ShowInfo();
        }
    }
}