using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array
{
    class Copy
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 4;
            arr[3] = 5;
            arr[4] = 6;
            int arrlength = arr.Length;
            Console.WriteLine("Main Array:");
            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }
                int[] arr2 = new int[arrlength];
                Array.Copy(arr, arr2, arrlength);
                Console.WriteLine("Copied Array:");
                foreach (int value in arr2)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }