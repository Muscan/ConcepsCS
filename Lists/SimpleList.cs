using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class SimpleList
    {
        //declare objects of type List
        private List<string> List { get; set; }
        private List<int> CountNumbers { get; set; }
        private List<int> CountNumbers1 { get; set; }   
        private List<object> ListObjects { get; set; }
       
        public SimpleList()
        {
            //Instantiate objects
            List = new List<string>();
            CountNumbers = new List<int>();
            CountNumbers1 = new List<int>();
            ListObjects = new List<object>(); 
        }
        //Write a program in C# Sharp to copy the elements one list into another list

        public void CopyList(List<int> sourceList, List<int> destinationList)
        {
            for (int i = 0; i < sourceList.Count; i++)
            {//in order to auto increase the size of the destination list,.
             //.Add must be called
                destinationList.Add(sourceList[i]);

            }
        }

        public void Print(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void CopyListToAnArray(List<int> list, int[] destinationArray)
        {
            list.CopyTo(destinationArray);
        }
        
    }
}
