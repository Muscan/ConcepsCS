using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class LinkedListForNodeList
    {
        NodeList head;
        NodeList currentElement;
        NodeList tail;

        //constructor
        public LinkedListForNodeList()
        {
            head = null;
            currentElement = null;
            tail = null;
        }

        //insert head

        public void InsertHead(int data)
        {
            NodeList newNode = new NodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        //insert tail       
        
        public void InsertTail(int data)
        {
            NodeList newNode = new NodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        //insert before key

        public void InsertAfterKey(int key, int data)
        {
            NodeList newNode = new NodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                NodeList temp = head;
                while (temp.next != null)
                {
                    if (temp.data == key)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        //print list

        public void PrintList()
        {
            Console.WriteLine("Linked node list is: ");
            NodeList current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
