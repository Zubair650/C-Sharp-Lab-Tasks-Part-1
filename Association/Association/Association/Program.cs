using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
     class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Eng.", "EEE");
            Student s1 = new Student("Zubair Ahmed", "160", 3.94f);
            Student s2 = new Student("Saad Ahmed", "105", 3.4f);
            Student s3 = new Student("Sayem Khan", "267", 3.56f);
            Student s4 = new Student("Rakib Rahman", "105", 3.84f);

            d1.AddStudent(s1,s2,s3);
            /*d1.AddStudent(s2);
            d1.AddStudent(s3);
            d2.AddStudent(s4);*/
            s1.Department.ShowInfo();
            d1.AllStudents();
            d2.AllStudents();
            Console.WriteLine("---------------------");

            /* s1.Department = d1;
            s1.ShowInfo();
           Console.WriteLine("---------------------");
            s2.Department = d2;
            d2.ID = "EE";
            s2.ShowInfo();*/
        }
    }
}
