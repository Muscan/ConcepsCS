using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Utils
    {
        public static int[] RandomArray(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-89821, 98215100);
            }
            return array;
        }
        //print method fir the sorted array 
        
        public static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }



    }
    
    
    
}
