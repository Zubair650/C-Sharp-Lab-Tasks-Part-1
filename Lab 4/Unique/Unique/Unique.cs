using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array
{
    class Unique
    {
        static void Main(string[] args)
        {
            int[] arr3 = new int[4];
            arr3[0] = 2;
            arr3[1] = 2;
            arr3[2] = 1;
            arr3[3] = 0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The Unique Elements are:");
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr3[i] != arr3[j])
                    {
                        Console.WriteLine(arr3[j]);

                    }
                }
            }
        }
    }
}
