using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Triangle
    {
        private int x = 10;
        private int y = 10;
        private int z = 10;
        void ShowInfo()
        {
            Console.WriteLine("1st side: " + x);
            Console.WriteLine("1st side: " + y);
            Console.WriteLine("1st side: " + z);
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
            t1.TestTriangle();
        }
    }
}
