using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Sort
    {
        //create a bubble sort method   

        public static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        //print method fir the sorted array 

        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }









    }
}
