using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
     class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;
        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student() { }

        public Student(string name, string id,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
         Department department;

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student CGPA: " + cgpa);
            //department.ShowInfo();
        }

    }
}
