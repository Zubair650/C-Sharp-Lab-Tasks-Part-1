using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
     class Department
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

        private Student[] students;
        private int studentCount;

        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        public Department() 
        {
            students = new Student[60];
        
        }

        public Department(string name,string id)
        {
            this.name = name;
            this.id = id;
            students = new Student[60];
        }
        /*public void AddStudent(Student student)
        {
            students[studentCount++] = student;
        }*/
        public void AddStudent(params Student[] arrStudents)
        {
            foreach (var s in arrStudents)
            {
                students[studentCount++] = s;
                s.Department = this;
            }
        }

            public void AllStudents()
        {
            for(int i=0;i< studentCount; i++)
            {
                students[i].ShowInfo();
                Console.WriteLine("---------------------");
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Department Name: " + name); 
            Console.WriteLine("Department ID: " + id);
        }

    }
}
