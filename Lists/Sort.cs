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
        /*3,9,7,1
        * first iteration
        for (int i = 0; i < arr.Length-1; i++)
        {
               for (int j = i + 1; j < arr.Length; j++)       //j=i+1 
               {
                   if (arr[i] > arr[j]) //if 0(3) > 1(9)
                   {
                       temp = arr[i];   //-
                       arr[i] = arr[j]; //-
                       arr[j] = temp;   //-
                   }  
               }
       }

                                                                                                          0      1      2     3
         i   |  i < arr.Length-1|  j     | j < arr.Length| arr[i] > arr[j]  | temp| arr[i] |  arr[j]   |  3   |  9   |  7  |  1  |
         0      (4-1)=3;0<3 T     (0+1)1   (1<4)T          arr[0] > arr[1]F    -      -         -         3      9      7     1
         0            -            2        2<4 T          arr[0] > arr[2]F    -      -         -         3      9      7     1 
         0            -            3        3<4 T          arr[0] > arr[3]T    3      1         3         1      9      7     3
         0            -            4        4<4 F                 -            -      -         -         1      9      7     3
         1          1<3T          (i+1)2    2<4 T          arr[1] > arr[2]T    9      7         9         1      7      9     3
         1          -             j++ 3     3<4 T          arr[1] > arr[3]T    7      3         7         1      3      9     7
         1          -             4         4<4 F                 -            -      -         -         1      3      9     7
         2          2<3T          (2+1)3    3<4 T          arr[2] > arr[3]T    9      7         9         1      3      7     9
         -           -            (3+1)4    4<4F                -              -      -         -         1      3      7     9
         3          3<3F           -         -                  -              -      -         -         -      -       -    -

        */


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




