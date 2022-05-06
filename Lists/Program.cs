// See https://aka.ms/new-console-template for more information
using Lists;
using System;
/*
Sort sort = new Sort();
int[] arr = new int[] { -3222454,2154,2154,21546,-56465465,0,65456454,1000000,5454545 };
Random random = new Random();
int[] array = Utils.RandomArray(10000);

sort.DirectSort(array);
sort.EfficientBubbleSort(array); //209ms
Utils.Print(array);
sort.DirectSort(array);//303ms

/*
//Linkedlist with head and node
LinkedListForNodeList ll = new LinkedListForNodeList();
ll.InsertHead(5);
ll.InsertHead(3);
ll.InsertHead(1);
ll.InsertHead(6);
ll.InsertTail(7);
//inserts a new node with value 3 after node with value 1
ll.InsertAfterKey(1, 4);
ll.InsertBeforeKey(5, 8);


ll.DeleteNode(1);//deletes a specified node
ll.DeleteHead();//deletes the head node
ll.DeleteTail();//deletes the tail node
ll.PrintList();
*/
//DoubleLinkedList
DoubleLinkedList dll = new DoubleLinkedList();
dll.InsertHead(5);
dll.InsertHead(3);
//after node with key 5, we insert node with value 4
dll.InsertAfterKey(5, 4);
dll.InsertBeforeKey(5, 8);
dll.InsertTail(1);
dll.RemoveFromHead();
dll.RemoveFromTail();
dll.PrintList();








