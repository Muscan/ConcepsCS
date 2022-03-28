// See https://aka.ms/new-console-template for more information
using Lists;

SimpleList sl = new SimpleList();
List<int> sourceList = new List<int> { 1, 2, 3 };
List<int> destinationList = new List<int>();
sl.CopyList(sourceList, destinationList);
sl.Print(destinationList);


//declare an array which has the same size of the source list. 
int[] destinationArray = new int[sourceList.Count];
sl.CopyListToAnArray(destinationList, destinationArray);
sl.PrintArray(destinationArray);

