using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1
{
    class Example1
    {
        public static void Main()
        {
            int[] arr = { 3, 60, 35, 2, 45, 320, 5 };
            int n = arr.Length;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < (n - i); j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        //swap elements  
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }

                }
                Console.WriteLine("After Iteration " + i + "   ");
                for (int k = 0; k < n; k++)
                {
                    Console.Write(arr[k] + " , ");
                }
            }
           

        }

    }
}
