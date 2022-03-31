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

//ChainedList
ChainedList cl = new ChainedList();
cl.Add(1);

cl.Add(2);
cl.Add(3);
cl.Add(4);
cl.Add(5);

cl.RemoveAt(2);
cl.ReplaceAt(0);
cl.Print();


Sort sort = new Sort();
int[] arr = new int[] { -3222454,2154,2154,21546,-56465465,0,65456454,1000000,5454545 };
Random random = new Random();
int[] array = Utils.RandomArray(10000);

//sort.DirectSort(array);

sort.EfficientBubbleSort(array); //209ms
Utils.Print(array);
//sort.DirectSort(array);//303ms
    


