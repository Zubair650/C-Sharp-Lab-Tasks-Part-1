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
            
                int[] arr2 = new int[arrlength];
                Array.Copy(arr, arr2, arrlength);
            
                foreach (int value in arr2)
                {
                    Console.WriteLine("Copied Array:"+ value);
                }
            }
        }
    }