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
            arr3[3] = 2;
            int count = 0;
            if (arr3[0] != arr3[1] && arr3[0] != arr3[2] && arr3[0] != arr3[3])
            {
                count++;
            }
            if (arr3[1] != arr3[0] && arr3[1] != arr3[2] && arr3[1] != arr3[3])
            {
                count++;
            }
            if (arr3[2] != arr3[0] && arr3[2] != arr3[1] && arr3[2] != arr3[3])
            {
                count++;
            }
            if (arr3[3] != arr3[0] && arr3[3] != arr3[1] && arr3[3] != arr3[2])
            {
                count++;
            }
            Console.WriteLine("Number of Unique elements:" + count);


        }
    }
}

