using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Sort
    {
        //create a direct sort method   

        public  void DirectSort(int[] arr)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) //arr[i]=5, arr[j]=3
                    {
                        temp = arr[i]; //temp = 5, arr[i]=5, arr[j]=3
                        arr[i] = arr[j]; //temp=5, arr[i]3, arr[j]=3
                        arr[j] = temp; //temp=5, arr[i]=3, arr[j]=5
                    }
                }
            }
            watch.Stop();
           
            Console.WriteLine($"Execution Time for direct sort: {watch.ElapsedMilliseconds} ms");
        }

       

        //Bubble sort method    

        public int[] EfficientBubbleSort(int[] nr)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            bool swapped = false;
            int n = nr.Length;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (nr[i] > nr[i + 1])
                    {
                        int aux;
                        aux = nr[i];
                        nr[i] = nr[i + 1];
                        nr[i + 1] = aux;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped == true);
            
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Execution Time for Bubble Sort: {watch.ElapsedMilliseconds} ms");
            return nr;
        }

    }
}




