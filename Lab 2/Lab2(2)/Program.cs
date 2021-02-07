using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int sum = 0;
            int i;
            Console.WriteLine("Sum of the Even Numbers: ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = i + sum;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("Sum of the ODD Numbers: ");
            for (i = 1; i <= n; i++)
            {
               
                if (i%2 != 0)
                {
                    sum = i + sum;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
