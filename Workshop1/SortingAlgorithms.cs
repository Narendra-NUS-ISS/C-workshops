using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1
{
    class SortingAlgorithms
    {
        public static void Main()
        {
            MergeSort();
        }
        // Bubble sort
        // Hint : Exchange sort
        /**
         * ----Bubble sort-----
After Iteration 0  :  3 , 35 , 2 , 45 , 60 , 5 , 320 ,
After Iteration 1  :  3 , 2 , 35 , 45 , 5 , 60 , 320 ,
After Iteration 2  :  2 , 3 , 35 , 5 , 45 , 60 , 320 ,
After Iteration 3  :  2 , 3 , 5 , 35 , 45 , 60 , 320 ,
After Iteration 4  :  2 , 3 , 5 , 35 , 45 , 60 , 320 ,
After Iteration 5  :  2 , 3 , 5 , 35 , 45 , 60 , 320 ,
After Iteration 6  :  2 , 3 , 5 , 35 , 45 , 60 , 320 ,
         **/
        public static void BubbleSort()
        {
            Console.WriteLine("----Bubble sort-----");
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
                Console.Write("After Iteration " + i + "  :  ");
                for (int k = 0; k < n; k++)
                {
                    Console.Write(arr[k] + " , ");
                }
                Console.WriteLine();
            }
        }

        // Insertion Sort
        // Hint :  left sub array
        /** 
         * ----Insertion sort-----
 Array after iteration 1  :  60 , 35 , 2 , 45 , 320 , 5 ,
 Array after iteration 2  :  35 , 60 , 2 , 45 , 320 , 5 ,
 Array after iteration 3  :  3 , 35 , 60 , 45 , 320 , 5 ,
 Array after iteration 4  :  3 , 35 , 45 , 60 , 320 , 5 ,
 Array after iteration 5  :  3 , 35 , 45 , 60 , 320 , 5 ,
 Array after iteration 6  :  3 , 5 , 35 , 45 , 60 , 320 ,
         * 
         *  **/
        public static void InsertionSort()
        {
            Console.WriteLine("----Insertion sort-----");
            int[] arr = { 3, 60, 35, 2, 45, 320, 5 };
            int n = arr.Length;
            int temp = 0;
            for(int i=1; i < n; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
                Console.Write(" Array after iteration " + i+"  :  ");
                for (int k = 0; k < n; k++)
                {
                    Console.Write(arr[k]+" , ");
            }
                Console.WriteLine();
            }
        }

        //Selection sort
        // Hint : find right min & exchange
        /**  
         * ----Selection sort-----
 Iteration 1  :  2 , 60 , 35 , 3 , 45 , 320 , 5 ,
 Iteration 1  :  2 , 3 , 35 , 60 , 45 , 320 , 5 ,
 Iteration 1  :  2 , 3 , 5 , 60 , 45 , 320 , 35 ,
 Iteration 1  :  2 , 3 , 5 , 35 , 45 , 320 , 60 ,
 Iteration 1  :  2 , 3 , 5 , 35 , 45 , 320 , 60 ,
 Iteration 1  :  2 , 3 , 5 , 35 , 45 , 60 , 320 ,
         *  **/
        public static void SelectionSort()
        {
            Console.WriteLine("----Selection sort-----");
            int[] arr = { 3, 60, 35, 2, 45, 320, 5,3 };
            int n = arr.Length;
            int temp = 0;
            for (int i = 0; i < n-1; i++)
            {
                int minpos = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minpos])
                    {
                        minpos = j;
                    }

                }
                temp = arr[i];
                arr[i] = arr[minpos];
                arr[minpos] = temp;
                Console.Write(" Iteration 1  :  ");
                for (int k = 0; k < n; k++)
                {
                    Console.Write(arr[k] + " , ");
                }
                Console.WriteLine();
            }
        }

        // MergeSort ( Divide & COnquer)
        public static void MergeSort()
        {
            int[] arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            int length = arr.Length / 2;
            int[] tempArr = new int[length];
            int left = 0;
            int right = length - 1;
            doMerge(arr, tempArr,left, right);
            Console.WriteLine("------Merge sort----");
            for(int i = 0; i < tempArr.Length; i++)
            {
                Console.Write(tempArr[i]+" , ");
            }
        }

        public static void doMerge(int[] arr, int[] tempArr, int left, int right)
        {
            if(arr== null ||arr.Length ==0 || left <= right)
            {
                return;
            }
            int mid = (left + right) / 2;
            doMerge(arr, tempArr, left, mid);
            doMerge(arr, tempArr,left, mid);
            merge(arr, tempArr, left, mid, right);

        }
        public static void merge(int[] arr,int[] tempArr,int lower, int mid, int high)
        {
            for (int x = lower; x <= high; x++)
            {
                tempArr[x] = arr[x];
            }
            int i = lower;
            int j = mid + 1;
            int k = lower;
            while (i <= mid && j <= high)
            {
                if (tempArr[i] <= tempArr[j])
                {
                    arr[k] = tempArr[i];
                    i++;
                }
                else
                {
                    arr[k] = tempArr[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                arr[k] = tempArr[i];
                k++;
                i++;
            }
           
        }


    }
}
