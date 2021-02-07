using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Triangle
    {
        Triangle()
        {
            Console.WriteLine("Constructor called");
        }
        private int x ;
        private int y ;
        private int z ;
        void ShowInfo(int x, int y, int z)
        {
            Console.WriteLine("1st side: " + x);
            Console.WriteLine("2nd side: " + y);
            Console.WriteLine("3rd side: " + z);
        }
        void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Equilateral");
            }
            if (x == y || x == z || y == z)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("No equal sides");
            }
        }
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            t1.ShowInfo(10, 10, 10);
            t1.TestTriangle();
        }
    }
}
